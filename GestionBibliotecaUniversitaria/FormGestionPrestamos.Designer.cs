namespace SistemaGestionBibliotecaUniversitaria
{
    partial class FormGestionPrestamos
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
            groupBoxNuevoPrestamo = new GroupBox();
            lblRecurso = new Label();
            cmbRecursos = new ComboBox();
            lblTotalRecursosDisponibles = new Label();
            lblUsuario = new Label();
            cmbUsuarios = new ComboBox();
            lblTotalUsuarios = new Label();
            panelInfoUsuario = new Panel();
            lblInfoUsuario = new Label();
            btnRealizarPrestamo = new Button();
            groupBoxPrestamosActivos = new GroupBox();
            dgvPrestamosActivos = new DataGridView();
            colPrestamo = new DataGridViewTextBoxColumn();
            lblTotalPrestamos = new Label();
            panelBotones = new Panel();
            btnRenovar = new Button();
            btnDevolver = new Button();
            btnCerrar = new Button();
            panelTitulo.SuspendLayout();
            groupBoxNuevoPrestamo.SuspendLayout();
            panelInfoUsuario.SuspendLayout();
            groupBoxPrestamosActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamosActivos).BeginInit();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(155, 89, 182);
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
            lblTituloForm.Text = "📋 Gestión de Préstamos";
            lblTituloForm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxNuevoPrestamo
            // 
            groupBoxNuevoPrestamo.Controls.Add(lblRecurso);
            groupBoxNuevoPrestamo.Controls.Add(cmbRecursos);
            groupBoxNuevoPrestamo.Controls.Add(lblTotalRecursosDisponibles);
            groupBoxNuevoPrestamo.Controls.Add(lblUsuario);
            groupBoxNuevoPrestamo.Controls.Add(cmbUsuarios);
            groupBoxNuevoPrestamo.Controls.Add(lblTotalUsuarios);
            groupBoxNuevoPrestamo.Controls.Add(panelInfoUsuario);
            groupBoxNuevoPrestamo.Controls.Add(btnRealizarPrestamo);
            groupBoxNuevoPrestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxNuevoPrestamo.Location = new Point(18, 75);
            groupBoxNuevoPrestamo.Name = "groupBoxNuevoPrestamo";
            groupBoxNuevoPrestamo.Size = new Size(752, 225);
            groupBoxNuevoPrestamo.TabIndex = 1;
            groupBoxNuevoPrestamo.TabStop = false;
            groupBoxNuevoPrestamo.Text = "Realizar Nuevo Préstamo";
            // 
            // lblRecurso
            // 
            lblRecurso.AutoSize = true;
            lblRecurso.Font = new Font("Segoe UI", 9F);
            lblRecurso.Location = new Point(18, 38);
            lblRecurso.Name = "lblRecurso";
            lblRecurso.Size = new Size(115, 15);
            lblRecurso.TabIndex = 0;
            lblRecurso.Text = "Seleccionar Recurso:";
            // 
            // cmbRecursos
            // 
            cmbRecursos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecursos.Font = new Font("Segoe UI", 9F);
            cmbRecursos.FormattingEnabled = true;
            cmbRecursos.Location = new Point(149, 35);
            cmbRecursos.Name = "cmbRecursos";
            cmbRecursos.Size = new Size(438, 23);
            cmbRecursos.TabIndex = 1;
            // 
            // lblTotalRecursosDisponibles
            // 
            lblTotalRecursosDisponibles.AutoSize = true;
            lblTotalRecursosDisponibles.Font = new Font("Segoe UI", 8F);
            lblTotalRecursosDisponibles.ForeColor = Color.Gray;
            lblTotalRecursosDisponibles.Location = new Point(595, 39);
            lblTotalRecursosDisponibles.Name = "lblTotalRecursosDisponibles";
            lblTotalRecursosDisponibles.Size = new Size(0, 13);
            lblTotalRecursosDisponibles.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F);
            lblUsuario.Location = new Point(18, 80);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(113, 15);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Seleccionar Usuario:";
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuarios.Font = new Font("Segoe UI", 9F);
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(149, 77);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(438, 23);
            cmbUsuarios.TabIndex = 4;
            cmbUsuarios.SelectedIndexChanged += cmbUsuarios_SelectedIndexChanged;
            // 
            // lblTotalUsuarios
            // 
            lblTotalUsuarios.AutoSize = true;
            lblTotalUsuarios.Font = new Font("Segoe UI", 8F);
            lblTotalUsuarios.ForeColor = Color.Gray;
            lblTotalUsuarios.Location = new Point(595, 82);
            lblTotalUsuarios.Name = "lblTotalUsuarios";
            lblTotalUsuarios.Size = new Size(0, 13);
            lblTotalUsuarios.TabIndex = 5;
            // 
            // panelInfoUsuario
            // 
            panelInfoUsuario.BackColor = Color.FromArgb(236, 240, 241);
            panelInfoUsuario.Controls.Add(lblInfoUsuario);
            panelInfoUsuario.Location = new Point(149, 117);
            panelInfoUsuario.Name = "panelInfoUsuario";
            panelInfoUsuario.Size = new Size(438, 42);
            panelInfoUsuario.TabIndex = 6;
            // 
            // lblInfoUsuario
            // 
            lblInfoUsuario.Dock = DockStyle.Fill;
            lblInfoUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInfoUsuario.ForeColor = Color.FromArgb(52, 73, 94);
            lblInfoUsuario.Location = new Point(0, 0);
            lblInfoUsuario.Name = "lblInfoUsuario";
            lblInfoUsuario.Size = new Size(438, 42);
            lblInfoUsuario.TabIndex = 0;
            lblInfoUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRealizarPrestamo
            // 
            btnRealizarPrestamo.BackColor = Color.FromArgb(46, 204, 113);
            btnRealizarPrestamo.Cursor = Cursors.Hand;
            btnRealizarPrestamo.FlatAppearance.BorderSize = 0;
            btnRealizarPrestamo.FlatStyle = FlatStyle.Flat;
            btnRealizarPrestamo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRealizarPrestamo.ForeColor = Color.White;
            btnRealizarPrestamo.Location = new Point(236, 173);
            btnRealizarPrestamo.Name = "btnRealizarPrestamo";
            btnRealizarPrestamo.Size = new Size(262, 38);
            btnRealizarPrestamo.TabIndex = 7;
            btnRealizarPrestamo.Text = "✓ Realizar Préstamo";
            btnRealizarPrestamo.UseVisualStyleBackColor = false;
            btnRealizarPrestamo.Click += btnRealizarPrestamo_Click;
            // 
            // groupBoxPrestamosActivos
            // 
            groupBoxPrestamosActivos.Controls.Add(dgvPrestamosActivos);
            groupBoxPrestamosActivos.Controls.Add(lblTotalPrestamos);
            groupBoxPrestamosActivos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxPrestamosActivos.Location = new Point(18, 319);
            groupBoxPrestamosActivos.Name = "groupBoxPrestamosActivos";
            groupBoxPrestamosActivos.Size = new Size(752, 262);
            groupBoxPrestamosActivos.TabIndex = 2;
            groupBoxPrestamosActivos.TabStop = false;
            groupBoxPrestamosActivos.Text = "Préstamos Activos";
            // 
            // dgvPrestamosActivos
            // 
            dgvPrestamosActivos.AllowUserToAddRows = false;
            dgvPrestamosActivos.AllowUserToDeleteRows = false;
            dgvPrestamosActivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamosActivos.BackgroundColor = Color.White;
            dgvPrestamosActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamosActivos.Columns.AddRange(new DataGridViewColumn[] { colPrestamo });
            dgvPrestamosActivos.Location = new Point(18, 28);
            dgvPrestamosActivos.MultiSelect = false;
            dgvPrestamosActivos.Name = "dgvPrestamosActivos";
            dgvPrestamosActivos.ReadOnly = true;
            dgvPrestamosActivos.RowHeadersWidth = 51;
            dgvPrestamosActivos.RowTemplate.Height = 24;
            dgvPrestamosActivos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamosActivos.Size = new Size(718, 197);
            dgvPrestamosActivos.TabIndex = 0;
            dgvPrestamosActivos.CellContentClick += dgvPrestamosActivos_CellContentClick;
            // 
            // colPrestamo
            // 
            colPrestamo.HeaderText = "Préstamo";
            colPrestamo.MinimumWidth = 6;
            colPrestamo.Name = "colPrestamo";
            colPrestamo.ReadOnly = true;
            // 
            // lblTotalPrestamos
            // 
            lblTotalPrestamos.AutoSize = true;
            lblTotalPrestamos.Font = new Font("Segoe UI", 9F);
            lblTotalPrestamos.ForeColor = Color.Gray;
            lblTotalPrestamos.Location = new Point(18, 234);
            lblTotalPrestamos.Name = "lblTotalPrestamos";
            lblTotalPrestamos.Size = new Size(0, 15);
            lblTotalPrestamos.TabIndex = 1;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnRenovar);
            panelBotones.Controls.Add(btnDevolver);
            panelBotones.Controls.Add(btnCerrar);
            panelBotones.Location = new Point(18, 595);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(752, 56);
            panelBotones.TabIndex = 3;
            // 
            // btnRenovar
            // 
            btnRenovar.BackColor = Color.FromArgb(52, 152, 219);
            btnRenovar.Cursor = Cursors.Hand;
            btnRenovar.FlatAppearance.BorderSize = 0;
            btnRenovar.FlatStyle = FlatStyle.Flat;
            btnRenovar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRenovar.ForeColor = Color.White;
            btnRenovar.Location = new Point(114, 9);
            btnRenovar.Name = "btnRenovar";
            btnRenovar.Size = new Size(175, 38);
            btnRenovar.TabIndex = 0;
            btnRenovar.Text = "🔄 Renovar Préstamo";
            btnRenovar.UseVisualStyleBackColor = false;
            btnRenovar.Click += btnRenovar_Click;
            // 
            // btnDevolver
            // 
            btnDevolver.BackColor = Color.FromArgb(241, 196, 15);
            btnDevolver.Cursor = Cursors.Hand;
            btnDevolver.FlatAppearance.BorderSize = 0;
            btnDevolver.FlatStyle = FlatStyle.Flat;
            btnDevolver.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDevolver.ForeColor = Color.White;
            btnDevolver.Location = new Point(306, 9);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(175, 38);
            btnDevolver.TabIndex = 1;
            btnDevolver.Text = "↩️ Devolver Recurso";
            btnDevolver.UseVisualStyleBackColor = false;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(231, 76, 60);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(499, 9);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(175, 38);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "❌ Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormGestionPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(788, 666);
            Controls.Add(panelBotones);
            Controls.Add(groupBoxPrestamosActivos);
            Controls.Add(groupBoxNuevoPrestamo);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormGestionPrestamos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de Préstamos";
            Load += FormGestionPrestamos_Load;
            panelTitulo.ResumeLayout(false);
            groupBoxNuevoPrestamo.ResumeLayout(false);
            groupBoxNuevoPrestamo.PerformLayout();
            panelInfoUsuario.ResumeLayout(false);
            groupBoxPrestamosActivos.ResumeLayout(false);
            groupBoxPrestamosActivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamosActivos).EndInit();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.GroupBox groupBoxNuevoPrestamo;
        private System.Windows.Forms.Label lblRecurso;
        private System.Windows.Forms.ComboBox cmbRecursos;
        private System.Windows.Forms.Label lblTotalRecursosDisponibles;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label lblTotalUsuarios;
        private System.Windows.Forms.Panel panelInfoUsuario;
        private System.Windows.Forms.Label lblInfoUsuario;
        private System.Windows.Forms.Button btnRealizarPrestamo;
        private System.Windows.Forms.GroupBox groupBoxPrestamosActivos;
        private System.Windows.Forms.DataGridView dgvPrestamosActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrestamo;
        private System.Windows.Forms.Label lblTotalPrestamos;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnRenovar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnCerrar;
    }
}