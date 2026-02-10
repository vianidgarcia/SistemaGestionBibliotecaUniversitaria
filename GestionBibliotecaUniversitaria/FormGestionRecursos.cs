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

        private void FormGestionRecursos_Load(object sender, EventArgs e)
        {
            // Establecer tipo de recurso por defecto
            cmbTipoRecurso.SelectedIndex = 0;

            // Cargar recursos existentes
            CargarRecursos();
        }

        private void cmbTipoRecurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostrar/ocultar controles según el tipo de recurso
            string tipoSeleccionado = cmbTipoRecurso.SelectedItem.ToString();

            switch (tipoSeleccionado)
            {
                case "Libro":
                    lblAutor.Visible = true;
                    txtAutor.Visible = true;
                    lblAño.Visible = true;
                    txtAño.Visible = true;
                    lblEdicion.Visible = false;
                    txtEdicion.Visible = false;
                    break;
                case "Revista":
                    lblAutor.Visible = false;
                    txtAutor.Visible = false;
                    lblAño.Visible = false;
                    txtAño.Visible = false;
                    lblEdicion.Visible = true;
                    txtEdicion.Visible = true;
                    break;
                case "Novela":
                    lblAutor.Visible = true;
                    txtAutor.Visible = true;
                    lblAño.Visible = true;
                    txtAño.Visible = true;
                    lblEdicion.Visible = false;
                    txtEdicion.Visible = false;
                    break;
            }
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

                if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser un número mayor a 0", "Error de Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    return;
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
                CargarRecursos();
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

            gestor.RegistrarLibro(txtTitulo.Text, txtAutor.Text, año, cantidad);
            MessageBox.Show("Libro registrado exitosamente", "Éxito",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegistrarRevista(int cantidad)
        {
            string edicion = txtEdicion.Text;
            gestor.RegistrarRevista(txtTitulo.Text, edicion, cantidad);
            MessageBox.Show("Revista registrada exitosamente", "Éxito",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}