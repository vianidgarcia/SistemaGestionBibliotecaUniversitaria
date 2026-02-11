namespace SistemaGestionBibliotecaUniversitaria
{
    partial class FormGestionRecursos
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
            lblTipoRecurso = new Label();
            cmbTipoRecurso = new ComboBox();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblAutor = new Label();
            txtAutor = new TextBox();
            lblAño = new Label();
            txtAño = new TextBox();
            lblEdicion = new Label();
            txtEdicion = new TextBox();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            groupBoxListado = new GroupBox();
            dgvRecursos = new DataGridView();
            colRecurso = new DataGridViewTextBoxColumn();
            btnCerrar = new Button();
            panelTitulo.SuspendLayout();
            groupBoxRegistro.SuspendLayout();
            groupBoxListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecursos).BeginInit();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(52, 152, 219);
            panelTitulo.Controls.Add(lblTituloForm);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(788, 56);
            panelTitulo.TabIndex = 0;
            // 
            // lblTituloForm
            // 
            lblTituloForm.Dock = DockStyle.Fill;
            lblTituloForm.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(0, 0);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(788, 56);
            lblTituloForm.TabIndex = 0;
            lblTituloForm.Text = "📚 Gestión de Recursos Bibliográficos";
            lblTituloForm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxRegistro
            // 
            groupBoxRegistro.Controls.Add(lblTipoRecurso);
            groupBoxRegistro.Controls.Add(cmbTipoRecurso);
            groupBoxRegistro.Controls.Add(lblTitulo);
            groupBoxRegistro.Controls.Add(txtTitulo);
            groupBoxRegistro.Controls.Add(lblAutor);
            groupBoxRegistro.Controls.Add(txtAutor);
            groupBoxRegistro.Controls.Add(lblAño);
            groupBoxRegistro.Controls.Add(txtAño);
            groupBoxRegistro.Controls.Add(lblEdicion);
            groupBoxRegistro.Controls.Add(txtEdicion);
            groupBoxRegistro.Controls.Add(lblCantidad);
            groupBoxRegistro.Controls.Add(txtCantidad);
            groupBoxRegistro.Controls.Add(btnRegistrar);
            groupBoxRegistro.Controls.Add(btnLimpiar);
            groupBoxRegistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxRegistro.Location = new Point(18, 75);
            groupBoxRegistro.Name = "groupBoxRegistro";
            groupBoxRegistro.Size = new Size(752, 206);
            groupBoxRegistro.TabIndex = 1;
            groupBoxRegistro.TabStop = false;
            groupBoxRegistro.Text = "Registro de Nuevo Recurso";
            // 
            // lblTipoRecurso
            // 
            lblTipoRecurso.AutoSize = true;
            lblTipoRecurso.Font = new Font("Segoe UI", 9F);
            lblTipoRecurso.Location = new Point(18, 33);
            lblTipoRecurso.Name = "lblTipoRecurso";
            lblTipoRecurso.Size = new Size(78, 15);
            lblTipoRecurso.TabIndex = 0;
            lblTipoRecurso.Text = "Tipo Recurso:";
            // 
            // cmbTipoRecurso
            // 
            cmbTipoRecurso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoRecurso.Font = new Font("Segoe UI", 9F);
            cmbTipoRecurso.FormattingEnabled = true;
            cmbTipoRecurso.Items.AddRange(new object[] { "Libro", "Revista", "Novela" });
            cmbTipoRecurso.Location = new Point(114, 30);
            cmbTipoRecurso.Name = "cmbTipoRecurso";
            cmbTipoRecurso.Size = new Size(176, 23);
            cmbTipoRecurso.TabIndex = 1;
            cmbTipoRecurso.SelectedIndexChanged += cmbTipoRecurso_SelectedIndexChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 9F);
            lblTitulo.Location = new Point(18, 70);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(40, 15);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 9F);
            txtTitulo.Location = new Point(114, 68);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(263, 23);
            txtTitulo.TabIndex = 3;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 9F);
            lblAutor.Location = new Point(18, 108);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 4;
            lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            txtAutor.Font = new Font("Segoe UI", 9F);
            txtAutor.Location = new Point(114, 105);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(263, 23);
            txtAutor.TabIndex = 5;
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Segoe UI", 9F);
            lblAño.Location = new Point(411, 33);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(32, 15);
            lblAño.TabIndex = 6;
            lblAño.Text = "Año:";
            // 
            // txtAño
            // 
            txtAño.Font = new Font("Segoe UI", 9F);
            txtAño.Location = new Point(472, 30);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(132, 23);
            txtAño.TabIndex = 7;
            // 
            // lblEdicion
            // 
            lblEdicion.AutoSize = true;
            lblEdicion.Font = new Font("Segoe UI", 9F);
            lblEdicion.Location = new Point(411, 70);
            lblEdicion.Name = "lblEdicion";
            lblEdicion.Size = new Size(49, 15);
            lblEdicion.TabIndex = 8;
            lblEdicion.Text = "Edición:";
            lblEdicion.Visible = false;
            // 
            // txtEdicion
            // 
            txtEdicion.Font = new Font("Segoe UI", 9F);
            txtEdicion.Location = new Point(472, 68);
            txtEdicion.Name = "txtEdicion";
            txtEdicion.Size = new Size(132, 23);
            txtEdicion.TabIndex = 9;
            txtEdicion.Visible = false;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 9F);
            lblCantidad.Location = new Point(411, 108);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 9F);
            txtCantidad.Location = new Point(472, 105);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(132, 23);
            txtCantidad.TabIndex = 11;
            txtCantidad.Text = "1";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(46, 204, 113);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(114, 150);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(175, 38);
            btnRegistrar.TabIndex = 12;
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
            btnLimpiar.Location = new Point(306, 150);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(175, 38);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "🔄 Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // groupBoxListado
            // 
            groupBoxListado.Controls.Add(dgvRecursos);
            groupBoxListado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxListado.Location = new Point(18, 300);
            groupBoxListado.Name = "groupBoxListado";
            groupBoxListado.Size = new Size(752, 234);
            groupBoxListado.TabIndex = 2;
            groupBoxListado.TabStop = false;
            groupBoxListado.Text = "Recursos Registrados";
            // 
            // dgvRecursos
            // 
            dgvRecursos.AllowUserToAddRows = false;
            dgvRecursos.AllowUserToDeleteRows = false;
            dgvRecursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecursos.BackgroundColor = Color.White;
            dgvRecursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecursos.Columns.AddRange(new DataGridViewColumn[] { colRecurso });
            dgvRecursos.Dock = DockStyle.Fill;
            dgvRecursos.Location = new Point(3, 21);
            dgvRecursos.Name = "dgvRecursos";
            dgvRecursos.ReadOnly = true;
            dgvRecursos.RowHeadersWidth = 51;
            dgvRecursos.RowTemplate.Height = 24;
            dgvRecursos.Size = new Size(746, 210);
            dgvRecursos.TabIndex = 0;
            // 
            // colRecurso
            // 
            colRecurso.HeaderText = "Recurso";
            colRecurso.MinimumWidth = 6;
            colRecurso.Name = "colRecurso";
            colRecurso.ReadOnly = true;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(231, 76, 60);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(306, 553);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(175, 38);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "❌ Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormGestionRecursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(788, 609);
            Controls.Add(btnCerrar);
            Controls.Add(groupBoxListado);
            Controls.Add(groupBoxRegistro);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormGestionRecursos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de Recursos";
            Load += FormGestionRecursos_Load;
            panelTitulo.ResumeLayout(false);
            groupBoxRegistro.ResumeLayout(false);
            groupBoxRegistro.PerformLayout();
            groupBoxListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecursos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.GroupBox groupBoxRegistro;
        private System.Windows.Forms.Label lblTipoRecurso;
        private System.Windows.Forms.ComboBox cmbTipoRecurso;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBoxListado;
        private System.Windows.Forms.DataGridView dgvRecursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecurso;
        private System.Windows.Forms.Button btnCerrar;
    }
}