using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaGestionBibliotecaUniversitaria
{
    public partial class FormGestionRecursos : Form
    {
        private GestorBiblioteca gestor;

        public FormGestionRecursos(GestorBiblioteca gestorBiblioteca)
        {
            InitializeComponent();
            gestor = gestorBiblioteca;
        }

        private bool isUpdating = false;

        // Agregar variable de control al inicio de la clase
        private bool isInitializing = false;

        private void FormGestionRecursos_Load(object sender, EventArgs e)
        {
            isInitializing = true;

            // Establecer visibilidad manualmente antes de seleccionar
            lblAutor.Visible = true;
            txtAutor.Visible = true;
            lblAño.Visible = true;
            txtAño.Visible = true;
            lblEdicion.Visible = false;
            txtEdicion.Visible = false;

            // Establecer tipo de recurso por defecto
            cmbTipoRecurso.SelectedIndex = 0;

            isInitializing = false;

            // Cargar recursos existentes
            CargarRecursos();
        }

        private void cmbTipoRecurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing || cmbTipoRecurso.SelectedItem == null) return;

            // Mostrar/ocultar controles según el tipo de recurso
            string tipoSeleccionado = cmbTipoRecurso.SelectedItem.ToString();

            // Resto del código sin cambios...
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                {
                    MessageBox.Show("El título es obligatorio", "Error de Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTitulo.Focus();
                    return;
                }
                else
                {
                    txtTitulo.BackColor = Color.White;
                }

                if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser un número mayor a 0", "Error de Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    return;
                }
                else
                {
                    txtCantidad.BackColor = Color.White;
                }

                string tipoSeleccionado = cmbTipoRecurso.SelectedItem.ToString();

                switch (tipoSeleccionado)
                {
                    case "Libro":
                        RegistrarLibro(cantidad);
                        break;
                    case "Revista":
                        RegistrarRevista(cantidad);
                        break;
                    case "Novela":
                        RegistrarNovela(cantidad);
                        break;
                }
                LimpiarCampos();
                isUpdating = true;
                CargarRecursos();
                isUpdating = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el recurso: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrarLibro(int cantidad)
        {
            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("El autor es obligatorio para libros", "Error de Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAutor.Focus();
                return;
            }

            if (!int.TryParse(txtAño.Text, out int año))
            {
                MessageBox.Show("El año debe ser un número válido", "Error de Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAño.Focus();
                return;
            }

            // Validación de rango de año
            int añoMaximoPermitido = DateTime.Now.Year + 10;
            if (año < 1000 || año > añoMaximoPermitido)
            {
                MessageBox.Show($"El año debe estar entre 1000 y {añoMaximoPermitido}", "Error de Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAño.Focus();
                return;
            }

            try
            {
                gestor.RegistrarLibro(txtTitulo.Text, txtAutor.Text, año, cantidad);
                MessageBox.Show("Libro registrado exitosamente", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error de validación: {ex.Message}", "Error de Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return;
            }
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            if (!isUpdating)
            {
                CargarRecursos();
            }
        }

        private void RegistrarRevista(int cantidad)
        {
            // VALIDACIÓN DE EDICIÓN (NUEVO)
            string edicion = string.IsNullOrWhiteSpace(txtEdicion.Text)
                ? "(Sin edición especificada)"
                : txtEdicion.Text.Trim();

            try
            {
                gestor.RegistrarRevista(txtTitulo.Text, edicion, cantidad);
                MessageBox.Show("Revista registrada exitosamente", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error de validación: {ex.Message}", "Error de Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return;
            }
        }


        private void RegistrarNovela(int cantidad)
        {
            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("El autor es obligatorio para novelas", "Error de Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAutor.Focus();
                return;
            }

            if (!int.TryParse(txtAño.Text, out int año))
            {
                MessageBox.Show("El año debe ser un número válido", "Error de Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAño.Focus();
                return;
            }

            // VALIDACIÓN DE RANGO DE AÑO (NUEVO)
            int añoMaximoPermitido = DateTime.Now.Year + 10;
            if (año < 1000 || año > añoMaximoPermitido)
            {
                MessageBox.Show($"El año debe estar entre 1000 y {añoMaximoPermitido}", "Error de Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAño.Focus();
                return;
            }

            gestor.RegistrarNovela(txtTitulo.Text, txtAutor.Text, año, cantidad);
            MessageBox.Show("Novela registrada exitosamente", "Éxito",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAño.Clear();
            txtEdicion.Clear();
            txtCantidad.Text = "1";
            cmbTipoRecurso.SelectedIndex = 0;
            txtTitulo.Focus();
        }

        private void CargarRecursos()
        {
            try
            {
                var recursos = gestor.ObtenerTodosLosRecursosResumidos();
                dgvRecursos.Rows.Clear();

                foreach (var recurso in recursos)
                {
                    dgvRecursos.Rows.Add(recurso);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar recursos: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnActualizarLista_Click(object sender, EventArgs e)
        {

        }
    }
}