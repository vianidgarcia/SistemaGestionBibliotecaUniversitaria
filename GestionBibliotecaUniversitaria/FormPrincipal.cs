using System;
using System.Windows.Forms;

namespace SistemaGestionBibliotecaUniversitaria
{
    public partial class FormPrincipal : Form
    {
        private GestorBiblioteca gestor;

        public FormPrincipal()
        {
            InitializeComponent();
            gestor = new GestorBiblioteca();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Configuración inicial
            this.CenterToScreen();
        }

        private void btnGestionRecursos_Click(object sender, EventArgs e)
        {
            FormGestionRecursos formRecursos = new FormGestionRecursos(gestor);
            formRecursos.ShowDialog();
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            FormGestionUsuarios formUsuarios = new FormGestionUsuarios(gestor);
            formUsuarios.ShowDialog();
        }

        private void btnGestionPrestamos_Click(object sender, EventArgs e)
        {
            FormGestionPrestamos formPrestamos = new FormGestionPrestamos(gestor);
            formPrestamos.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea salir del sistema?",
                              "Confirmar Salida",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}