namespace SistemaGestionBibliotecaUniversitaria
{
    partial class FormGestionUsuarios
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelTitulo = new Panel();
            lblTituloForm = new Label();
            groupBoxRegistro = new GroupBox();
            lblTipoUsuario = new Label();
            cmbTipoUsuario = new ComboBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            panelInfo = new Panel();
            lblInfoLimite = new Label();
            lblInfoDias = new Label();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            groupBoxListado = new GroupBox();
            dgvUsuarios = new DataGridView();
            colUsuario = new DataGridViewTextBoxColumn();
            btnCerrar = new Button();
            panelTitulo.SuspendLayout();
            groupBoxRegistro.SuspendLayout();
            panelInfo.SuspendLayout();
            groupBoxListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(46, 204, 113);
            panelTitulo.Controls.Add(lblTituloForm);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(700, 56);
            panelTitulo.TabIndex = 0;
            // 
            // lblTituloForm
            // 
            lblTituloForm.Dock = DockStyle.Fill;
            lblTituloForm.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(0, 0);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(700, 56);
            lblTituloForm.TabIndex = 0;
            lblTituloForm.Text = "👥 Gestión de Usuarios";
            lblTituloForm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxRegistro
            // 
            groupBoxRegistro.Controls.Add(lblTipoUsuario);
            groupBoxRegistro.Controls.Add(cmbTipoUsuario);
            groupBoxRegistro.Controls.Add(lblNombre);
            groupBoxRegistro.Controls.Add(txtNombre);
            groupBoxRegistro.Controls.Add(panelInfo);
            groupBoxRegistro.Controls.Add(btnRegistrar);
            groupBoxRegistro.Controls.Add(btnLimpiar);
            groupBoxRegistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxRegistro.Location = new Point(18, 75);
            groupBoxRegistro.Name = "groupBoxRegistro";
            groupBoxRegistro.Size = new Size(665, 234);
            groupBoxRegistro.TabIndex = 1;
            groupBoxRegistro.TabStop = false;
            groupBoxRegistro.Text = "Registro de Nuevo Usuario";
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Font = new Font("Segoe UI", 9F);
            lblTipoUsuario.Location = new Point(26, 42);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(76, 15);
            lblTipoUsuario.TabIndex = 0;
            lblTipoUsuario.Text = "Tipo Usuario:";
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.Font = new Font("Segoe UI", 9F);
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Items.AddRange(new object[] { "Estudiante", "Profesor" });
            cmbTipoUsuario.Location = new Point(131, 39);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(219, 23);
            cmbTipoUsuario.TabIndex = 1;
            cmbTipoUsuario.SelectedIndexChanged += cmbTipoUsuario_SelectedIndexChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F);
            lblNombre.Location = new Point(26, 89);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.Location = new Point(131, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(219, 23);
            txtNombre.TabIndex = 3;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(236, 240, 241);
            panelInfo.Controls.Add(lblInfoLimite);
            panelInfo.Controls.Add(lblInfoDias);
            panelInfo.Location = new Point(394, 33);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(245, 84);
            panelInfo.TabIndex = 4;
            // 
            // lblInfoLimite
            // 
            lblInfoLimite.AutoSize = true;
            lblInfoLimite.Font = new Font("Segoe UI", 9F);
            lblInfoLimite.Location = new Point(13, 19);
            lblInfoLimite.Name = "lblInfoLimite";
            lblInfoLimite.Size = new Size(115, 15);
            lblInfoLimite.TabIndex = 0;
            lblInfoLimite.Text = "Límite de recursos: 3";
            // 
            // lblInfoDias
            // 
            lblInfoDias.AutoSize = true;
            lblInfoDias.Font = new Font("Segoe UI", 9F);
            lblInfoDias.Location = new Point(13, 47);
            lblInfoDias.Name = "lblInfoDias";
            lblInfoDias.Size = new Size(110, 15);
            lblInfoDias.TabIndex = 1;
            lblInfoDias.Text = "Días de préstamo: 7";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(46, 204, 113);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(131, 169);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(175, 38);
            btnRegistrar.TabIndex = 5;
            btnRegistrar.Text = "✓ Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(241, 196, 15);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(332, 169);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(175, 38);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "🔄 Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // groupBoxListado
            // 
            groupBoxListado.Controls.Add(dgvUsuarios);
            groupBoxListado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxListado.Location = new Point(18, 328);
            groupBoxListado.Name = "groupBoxListado";
            groupBoxListado.Size = new Size(665, 206);
            groupBoxListado.TabIndex = 2;
            groupBoxListado.TabStop = false;
            groupBoxListado.Text = "Usuarios Registrados";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { colUsuario });
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(3, 21);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 24;
            dgvUsuarios.Size = new Size(659, 182);
            dgvUsuarios.TabIndex = 0;
            // 
            // colUsuario
            // 
            colUsuario.HeaderText = "Usuario";
            colUsuario.MinimumWidth = 6;
            colUsuario.Name = "colUsuario";
            colUsuario.ReadOnly = true;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(231, 76, 60);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(262, 553);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(175, 38);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "❌ Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 609);
            Controls.Add(btnCerrar);
            Controls.Add(groupBoxListado);
            Controls.Add(groupBoxRegistro);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormGestionUsuarios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de Usuarios";
            Load += FormGestionUsuarios_Load;
            panelTitulo.ResumeLayout(false);
            groupBoxRegistro.ResumeLayout(false);
            groupBoxRegistro.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            groupBoxListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.GroupBox groupBoxRegistro;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblInfoLimite;
        private System.Windows.Forms.Label lblInfoDias;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBoxListado;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.Button btnCerrar;
    }
}