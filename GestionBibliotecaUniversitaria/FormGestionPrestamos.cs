using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaGestionBibliotecaUniversitaria
{
    public partial class FormGestionPrestamos : Form
    {
        private GestorBiblioteca gestor;

        public FormGestionPrestamos(GestorBiblioteca gestorBiblioteca)
        {
            InitializeComponent();
            gestor = gestorBiblioteca;
        }

        private Color defaultComboBackColor = Color.White;

        private void FormGestionPrestamos_Load(object sender, EventArgs e)
        {
            // Cargar datos iniciales
            CargarRecursosDisponibles();
            CargarUsuarios();
            CargarPrestamosActivos();

            // Guardar color por defecto
            defaultComboBackColor = cmbRecursos.BackColor;
        }

        #region Realizar Préstamo

        private void btnRealizarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                // Restaurar colores por defecto
                cmbRecursos.BackColor = defaultComboBackColor;
                cmbUsuarios.BackColor = defaultComboBackColor;

                // Validar que se haya seleccionado un recurso
                if (cmbRecursos.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un recurso", "Error de Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbRecursos.BackColor = Color.LightPink;
                    cmbRecursos.Focus();
                    return;
                }

                // Validar que se haya seleccionado un usuario
                if (cmbUsuarios.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un usuario", "Error de Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbUsuarios.BackColor = Color.LightPink;
                    cmbUsuarios.Focus();
                    return;
                }

                // Validar que el usuario no haya alcanzado su límite
                var usuario = gestor.BuscarUsuarioPorIndice(cmbUsuarios.SelectedIndex);
                if (usuario != null)
                {
                    int prestamosActivos = gestor.ContarPrestamosActivosUsuario(usuario.GetId());
                    if (prestamosActivos >= usuario.LimiteRecursos)
                    {
                        MessageBox.Show($"El usuario ha alcanzado su límite de {usuario.LimiteRecursos} recursos simultáneos",
                                      "Límite Alcanzado",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cmbUsuarios.BackColor = Color.LightPink;
                        cmbUsuarios.Focus();
                        return;
                    }
                }

                // Realizar préstamo
                int indiceRecurso = cmbRecursos.SelectedIndex;
                int indiceUsuario = cmbUsuarios.SelectedIndex;

                bool exito = gestor.RealizarPrestamo(indiceRecurso, indiceUsuario);

                if (exito)
                {
                    MessageBox.Show("Préstamo realizado exitosamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar selecciones
                    cmbRecursos.SelectedIndex = -1;
                    cmbUsuarios.SelectedIndex = -1;

                    // Recargar datos
                    CargarRecursosDisponibles();
                    CargarPrestamosActivos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar el préstamo: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Renovar Préstamo - CORREGIDO

        private void btnRenovar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrestamosActivos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un préstamo de la lista", "Error de Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int indicePrestamo = dgvPrestamosActivos.SelectedRows[0].Index;

                // Usar el nuevo método que trabaja con índices de activos
                bool exito = gestor.RenovarPrestamoPorIndiceActivo(indicePrestamo);

                if (exito)
                {
                    MessageBox.Show("Préstamo renovado exitosamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPrestamosActivos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al renovar el préstamo: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Devolver Préstamo - CORREGIDO con visualización de multas

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPrestamosActivos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un préstamo de la lista", "Error de Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int indicePrestamo = dgvPrestamosActivos.SelectedRows[0].Index;

                // Obtener información del préstamo antes de devolver
                var prestamo = gestor.ObtenerPrestamoActivoPorIndice(indicePrestamo);
                if (prestamo == null)
                {
                    MessageBox.Show("Préstamo no encontrado", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calcular multa potencial antes de la devolución
                bool estaVencido = DateTime.Now > prestamo.GetFechaLimite();
                int diasRetraso = estaVencido ? (DateTime.Now - prestamo.GetFechaLimite()).Days : 0;
                double multaPotencial = diasRetraso * prestamo.GetUsuario().GetMultaPorDia();

                // Construir mensaje de confirmación
                string mensajeConfirmacion = "¿Está seguro de que desea registrar la devolución de este préstamo?\n\n";
                mensajeConfirmacion += $"Recurso: {prestamo.GetRecurso().GetTitulo()}\n";
                mensajeConfirmacion += $"Usuario: {prestamo.GetUsuario().GetNombre()}\n";
                mensajeConfirmacion += $"Fecha límite: {prestamo.GetFechaLimite():dd/MM/yyyy}\n";

                if (estaVencido)
                {
                    mensajeConfirmacion += $"\n⚠️ ATENCIÓN: PRÉSTAMO VENCIDO\n";
                    mensajeConfirmacion += $"Días de retraso: {diasRetraso}\n";
                    mensajeConfirmacion += $"Multa estimada: ${multaPotencial:F2}\n";
                }
                else
                {
                    mensajeConfirmacion += "\nPréstamo dentro del plazo ✓\n";
                }

                DialogResult resultado = MessageBox.Show(
                    mensajeConfirmacion,
                    "Confirmar Devolución",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Realizar devolución
                    gestor.DevolverPrestamoPorIndiceActivo(indicePrestamo);

                    // Construir mensaje de resultado
                    string mensajeResultado = "Devolución registrada exitosamente.\n\n";

                    // Obtener el préstamo actualizado (buscar por ID)
                    var prestamosActivos = gestor.ObtenerPrestamosActivosResumidos();

                    if (estaVencido && multaPotencial > 0)
                    {
                        mensajeResultado += $"✅ Se aplicó multa de ${multaPotencial:F2} por {diasRetraso} día(s) de retraso.\n";
                    }
                    else if (estaVencido)
                    {
                        mensajeResultado += "✅ Devolución registrada (con retraso pero sin multa).\n";
                    }
                    else
                    {
                        mensajeResultado += "✅ Devolución a tiempo. Sin multa.\n";
                    }

                    mensajeResultado += $"\nRecurso '{prestamo.GetRecurso().GetTitulo()}' disponible nuevamente.";

                    MessageBox.Show(mensajeResultado, "Devolución Exitosa",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarRecursosDisponibles();
                    CargarPrestamosActivos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al devolver el préstamo: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Métodos de Carga de Datos

        private void CargarRecursosDisponibles()
        {
            try
            {
                cmbRecursos.Items.Clear();
                var recursos = gestor.ObtenerRecursosDisponibles();

                foreach (var recurso in recursos)
                {
                    cmbRecursos.Items.Add(recurso);
                }

                lblTotalRecursosDisponibles.Text = $"Total: {recursos.Count} recursos disponibles";

                // Mostrar advertencia si no hay recursos
                if (recursos.Count == 0)
                {
                    cmbRecursos.Enabled = false;
                    btnRealizarPrestamo.Enabled = false;

                    // Crear label de advertencia si no existe
                    if (!Controls.ContainsKey("lblAdvertenciaRecursos"))
                    {
                        Label lblAdvertencia = new Label();
                        lblAdvertencia.Name = "lblAdvertenciaRecursos";
                        lblAdvertencia.Text = "⚠️ No hay recursos disponibles actualmente. Registre nuevos recursos o espere a que se devuelvan préstamos activos.";
                        lblAdvertencia.ForeColor = Color.Orange;
                        lblAdvertencia.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        lblAdvertencia.Location = new Point(50, 150);
                        lblAdvertencia.Size = new Size(650, 40);
                        lblAdvertencia.TextAlign = ContentAlignment.MiddleCenter;
                        groupBoxNuevoPrestamo.Controls.Add(lblAdvertencia);
                    }
                }
                else
                {
                    cmbRecursos.Enabled = true;

                    // Remover advertencia si existe
                    if (Controls.ContainsKey("lblAdvertenciaRecursos"))
                    {
                        groupBoxNuevoPrestamo.Controls.RemoveByKey("lblAdvertenciaRecursos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar recursos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarUsuarios()
        {
            try
            {
                cmbUsuarios.Items.Clear();
                var usuarios = gestor.ObtenerUsuariosResumidos();

                foreach (var usuario in usuarios)
                {
                    cmbUsuarios.Items.Add(usuario);
                }

                lblTotalUsuarios.Text = $"Total: {usuarios.Count} usuarios";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPrestamosActivos()
        {
            try
            {
                dgvPrestamosActivos.Rows.Clear();
                var prestamos = gestor.ObtenerPrestamosActivosResumidos();

                foreach (var prestamo in prestamos)
                {
                    dgvPrestamosActivos.Rows.Add(prestamo);
                }

                lblTotalPrestamos.Text = $"Total: {prestamos.Count} préstamos activos";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar préstamos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Eventos de Selección

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Restaurar color por defecto
            cmbUsuarios.BackColor = defaultComboBackColor;

            if (cmbUsuarios.SelectedIndex == -1)
            {
                lblInfoUsuario.Text = "";
                btnRealizarPrestamo.Enabled = false;
                btnRealizarPrestamo.Text = "✓ Realizar Préstamo";
                return;
            }

            try
            {
                var usuario = gestor.BuscarUsuarioPorIndice(cmbUsuarios.SelectedIndex);
                if (usuario != null)
                {
                    int prestamosActivos = gestor.ContarPrestamosActivosUsuario(usuario.GetId());
                    lblInfoUsuario.Text = $"Préstamos actuales: {prestamosActivos}/{usuario.LimiteRecursos} | Días permitidos: {usuario.DiasMaximoPrestamo}";

                    // Cambiar color si está cerca del límite
                    if (prestamosActivos >= usuario.LimiteRecursos)
                    {
                        lblInfoUsuario.ForeColor = Color.Red;
                        btnRealizarPrestamo.Enabled = false;
                        btnRealizarPrestamo.Text = "❌ Límite Alcanzado";
                    }
                    else if (prestamosActivos >= usuario.LimiteRecursos - 1)
                    {
                        lblInfoUsuario.ForeColor = Color.Orange;
                        btnRealizarPrestamo.Enabled = true;
                        btnRealizarPrestamo.Text = "✓ Realizar Préstamo";
                    }
                    else
                    {
                        lblInfoUsuario.ForeColor = Color.Green;
                        btnRealizarPrestamo.Enabled = true;
                        btnRealizarPrestamo.Text = "✓ Realizar Préstamo";
                    }
                }
            }
            catch (Exception ex)
            {
                lblInfoUsuario.Text = $"Error: {ex.Message}";
                btnRealizarPrestamo.Enabled = false;
            }
        }


        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPrestamosActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}