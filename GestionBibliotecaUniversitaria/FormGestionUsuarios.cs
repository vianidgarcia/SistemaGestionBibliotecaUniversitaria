using System;
using System.Windows.Forms;

namespace SistemaGestionBibliotecaUniversitaria
{
    public partial class FormGestionUsuarios : Form
    {
        private GestorBiblioteca gestor;

        public FormGestionUsuarios(GestorBiblioteca gestorBiblioteca)
        {
            InitializeComponent();
            gestor = gestorBiblioteca;
        }

        private void FormGestionUsuarios_Load(object sender, EventArgs e)
        {
            // Establecer tipo de usuario por defecto
            cmbTipoUsuario.SelectedIndex = 0;

            // Cargar usuarios existentes
            CargarUsuarios();
        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Actualizar información según el tipo de usuario seleccionado
            string tipoSeleccionado = cmbTipoUsuario.SelectedItem.ToString();

            if (tipoSeleccionado == "Estudiante")
            {
                lblInfoLimite.Text = "Límite de recursos: 3";
                lblInfoDias.Text = "Días de préstamo: 7";
            }
            else if (tipoSeleccionado == "Profesor")
            {
                lblInfoLimite.Text = "Límite de recursos: 5";
                lblInfoDias.Text = "Días de préstamo: 30";
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Restaurar color
                txtNombre.BackColor = Color.White;

                // Validar campo obligatorio
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio", "Error de Validación",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.BackColor = Color.LightPink;
                    txtNombre.Focus();
                    return;
                }

                string tipoSeleccionado = cmbTipoUsuario.SelectedItem.ToString();

                if (tipoSeleccionado == "Estudiante")
                {
                    gestor.RegistrarEstudiante(txtNombre.Text);
                    MessageBox.Show("Estudiante registrado exitosamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tipoSeleccionado == "Profesor")
                {
                    gestor.RegistrarProfesor(txtNombre.Text);
                    MessageBox.Show("Profesor registrado exitosamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpiarCampos();
                CargarUsuarios();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error de validación: {ex.Message}", "Error de Validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.BackColor = Color.LightPink;
                txtNombre.Focus();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el usuario: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            cmbTipoUsuario.SelectedIndex = 0;
            txtNombre.Focus();
        }

        private void CargarUsuarios()
        {
            try
            {
                var usuarios = gestor.ObtenerUsuariosResumidos();
                dgvUsuarios.Rows.Clear();

                foreach (var usuario in usuarios)
                {
                    dgvUsuarios.Rows.Add(usuario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}