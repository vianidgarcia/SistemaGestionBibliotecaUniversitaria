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

        private void FormGestionPrestamos_Load(object sender, EventArgs e)
        {
            // Cargar datos iniciales
            CargarRecursosDisponibles();
            CargarUsuarios();
            CargarPrestamosActivos();
        }

        #region Realizar Préstamo

        private void btnRealizarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya seleccionado un recurso
                if (cmbRecursos.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un recurso", "Error de Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbRecursos.Focus();
                    return;
                }

                // Validar que se haya seleccionado un usuario
                if (cmbUsuarios.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un usuario", "Error de Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbUsuarios.Focus();
                    return;
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

        #region Renovar Préstamo

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

                bool exito = gestor.RenovarPrestamo(indicePrestamo);

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

        #region Devolver Préstamo

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

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea registrar la devolución de este préstamo?",
                    "Confirmar Devolución",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    gestor.DevolverPrestamo(indicePrestamo);
                    MessageBox.Show("Devolución registrada exitosamente", "Éxito",
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
            if (cmbUsuarios.SelectedIndex == -1)
            {
                lblInfoUsuario.Text = "";
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
                    }
                    else if (prestamosActivos >= usuario.LimiteRecursos - 1)
                    {
                        lblInfoUsuario.ForeColor = Color.Orange;
                    }
                    else
                    {
                        lblInfoUsuario.ForeColor = Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                lblInfoUsuario.Text = $"Error: {ex.Message}";
            }
        }

        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}