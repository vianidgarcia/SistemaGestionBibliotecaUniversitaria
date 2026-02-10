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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.groupBoxNuevoPrestamo = new System.Windows.Forms.GroupBox();
            this.lblRecurso = new System.Windows.Forms.Label();
            this.cmbRecursos = new System.Windows.Forms.ComboBox();
            this.lblTotalRecursosDisponibles = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblTotalUsuarios = new System.Windows.Forms.Label();
            this.panelInfoUsuario = new System.Windows.Forms.Panel();
            this.lblInfoUsuario = new System.Windows.Forms.Label();
            this.btnRealizarPrestamo = new System.Windows.Forms.Button();
            this.groupBoxPrestamosActivos = new System.Windows.Forms.GroupBox();
            this.dgvPrestamosActivos = new System.Windows.Forms.DataGridView();
            this.colPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalPrestamos = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnRenovar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            this.groupBoxNuevoPrestamo.SuspendLayout();
            this.panelInfoUsuario.SuspendLayout();
            this.groupBoxPrestamosActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosActivos)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panelTitulo.Controls.Add(this.lblTituloForm);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(900, 60);
            this.panelTitulo.TabIndex = 0;
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTituloForm.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloForm.ForeColor = System.Drawing.Color.White;
            this.lblTituloForm.Location = new System.Drawing.Point(0, 0);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(900, 60);
            this.lblTituloForm.TabIndex = 0;
            this.lblTituloForm.Text = "📋 Gestión de Préstamos";
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxNuevoPrestamo
            // 
            this.groupBoxNuevoPrestamo.Controls.Add(this.lblRecurso);
            this.groupBoxNuevoPrestamo.Controls.Add(this.cmbRecursos);
            this.groupBoxNuevoPrestamo.Controls.Add(this.lblTotalRecursosDisponibles);
            this.groupBoxNuevoPrestamo.Controls.Add(this.lblUsuario);
            this.groupBoxNuevoPrestamo.Controls.Add(this.cmbUsuarios);
            this.groupBoxNuevoPrestamo.Controls.Add(this.lblTotalUsuarios);
            this.groupBoxNuevoPrestamo.Controls.Add(this.panelInfoUsuario);
            this.groupBoxNuevoPrestamo.Controls.Add(this.btnRealizarPrestamo);
            this.groupBoxNuevoPrestamo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxNuevoPrestamo.Location = new System.Drawing.Point(20, 80);
            this.groupBoxNuevoPrestamo.Name = "groupBoxNuevoPrestamo";
            this.groupBoxNuevoPrestamo.Size = new System.Drawing.Size(860, 240);
            this.groupBoxNuevoPrestamo.TabIndex = 1;
            this.groupBoxNuevoPrestamo.TabStop = false;
            this.groupBoxNuevoPrestamo.Text = "Realizar Nuevo Préstamo";
            // 
            // lblRecurso
            // 
            this.lblRecurso.AutoSize = true;
            this.lblRecurso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRecurso.Location = new System.Drawing.Point(20, 40);
            this.lblRecurso.Name = "lblRecurso";
            this.lblRecurso.Size = new System.Drawing.Size(135, 20);
            this.lblRecurso.TabIndex = 0;
            this.lblRecurso.Text = "Seleccionar Recurso:";
            // 
            // cmbRecursos
            // 
            this.cmbRecursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecursos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbRecursos.FormattingEnabled = true;
            this.cmbRecursos.Location = new System.Drawing.Point(170, 37);
            this.cmbRecursos.Name = "cmbRecursos";
            this.cmbRecursos.Size = new System.Drawing.Size(500, 28);
            this.cmbRecursos.TabIndex = 1;
            // 
            // lblTotalRecursosDisponibles
            // 
            this.lblTotalRecursosDisponibles.AutoSize = true;
            this.lblTotalRecursosDisponibles.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalRecursosDisponibles.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalRecursosDisponibles.Location = new System.Drawing.Point(680, 42);
            this.lblTotalRecursosDisponibles.Name = "lblTotalRecursosDisponibles";
            this.lblTotalRecursosDisponibles.Size = new System.Drawing.Size(0, 19);
            this.lblTotalRecursosDisponibles.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUsuario.Location = new System.Drawing.Point(20, 85);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(133, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Seleccionar Usuario:";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(170, 82);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(500, 28);
            this.cmbUsuarios.TabIndex = 4;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // lblTotalUsuarios
            // 
            this.lblTotalUsuarios.AutoSize = true;
            this.lblTotalUsuarios.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalUsuarios.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalUsuarios.Location = new System.Drawing.Point(680, 87);
            this.lblTotalUsuarios.Name = "lblTotalUsuarios";
            this.lblTotalUsuarios.Size = new System.Drawing.Size(0, 19);
            this.lblTotalUsuarios.TabIndex = 5;
            // 
            // panelInfoUsuario
            // 
            this.panelInfoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelInfoUsuario.Controls.Add(this.lblInfoUsuario);
            this.panelInfoUsuario.Location = new System.Drawing.Point(170, 125);
            this.panelInfoUsuario.Name = "panelInfoUsuario";
            this.panelInfoUsuario.Size = new System.Drawing.Size(500, 45);
            this.panelInfoUsuario.TabIndex = 6;
            // 
            // lblInfoUsuario
            // 
            this.lblInfoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblInfoUsuario.Location = new System.Drawing.Point(0, 0);
            this.lblInfoUsuario.Name = "lblInfoUsuario";
            this.lblInfoUsuario.Size = new System.Drawing.Size(500, 45);
            this.lblInfoUsuario.TabIndex = 0;
            this.lblInfoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRealizarPrestamo
            // 
            this.btnRealizarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRealizarPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarPrestamo.FlatAppearance.BorderSize = 0;
            this.btnRealizarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarPrestamo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRealizarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnRealizarPrestamo.Location = new System.Drawing.Point(270, 185);
            this.btnRealizarPrestamo.Name = "btnRealizarPrestamo";
            this.btnRealizarPrestamo.Size = new System.Drawing.Size(300, 40);
            this.btnRealizarPrestamo.TabIndex = 7;
            this.btnRealizarPrestamo.Text = "✓ Realizar Préstamo";
            this.btnRealizarPrestamo.UseVisualStyleBackColor = false;
            this.btnRealizarPrestamo.Click += new System.EventHandler(this.btnRealizarPrestamo_Click);
            // 
            // groupBoxPrestamosActivos
            // 
            this.groupBoxPrestamosActivos.Controls.Add(this.dgvPrestamosActivos);
            this.groupBoxPrestamosActivos.Controls.Add(this.lblTotalPrestamos);
            this.groupBoxPrestamosActivos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxPrestamosActivos.Location = new System.Drawing.Point(20, 340);
            this.groupBoxPrestamosActivos.Name = "groupBoxPrestamosActivos";
            this.groupBoxPrestamosActivos.Size = new System.Drawing.Size(860, 280);
            this.groupBoxPrestamosActivos.TabIndex = 2;
            this.groupBoxPrestamosActivos.TabStop = false;
            this.groupBoxPrestamosActivos.Text = "Préstamos Activos";
            // 
            // dgvPrestamosActivos
            // 
            this.dgvPrestamosActivos.AllowUserToAddRows = false;
            this.dgvPrestamosActivos.AllowUserToDeleteRows = false;
            this.dgvPrestamosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamosActivos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrestamosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamosActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPrestamo});
            this.dgvPrestamosActivos.Location = new System.Drawing.Point(20, 30);
            this.dgvPrestamosActivos.MultiSelect = false;
            this.dgvPrestamosActivos.Name = "dgvPrestamosActivos";
            this.dgvPrestamosActivos.ReadOnly = true;
            this.dgvPrestamosActivos.RowHeadersWidth = 51;
            this.dgvPrestamosActivos.RowTemplate.Height = 24;
            this.dgvPrestamosActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamosActivos.Size = new System.Drawing.Size(820, 210);
            this.dgvPrestamosActivos.TabIndex = 0;
            // 
            // colPrestamo
            // 
            this.colPrestamo.HeaderText = "Préstamo";
            this.colPrestamo.MinimumWidth = 6;
            this.colPrestamo.Name = "colPrestamo";
            this.colPrestamo.ReadOnly = true;
            // 
            // lblTotalPrestamos
            // 
            this.lblTotalPrestamos.AutoSize = true;
            this.lblTotalPrestamos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalPrestamos.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalPrestamos.Location = new System.Drawing.Point(20, 250);
            this.lblTotalPrestamos.Name = "lblTotalPrestamos";
            this.lblTotalPrestamos.Size = new System.Drawing.Size(0, 20);
            this.lblTotalPrestamos.TabIndex = 1;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnRenovar);
            this.panelBotones.Controls.Add(this.btnDevolver);
            this.panelBotones.Controls.Add(this.btnCerrar);
            this.panelBotones.Location = new System.Drawing.Point(20, 635);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(860, 60);
            this.panelBotones.TabIndex = 3;
            // 
            // btnRenovar
            // 
            this.btnRenovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnRenovar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenovar.FlatAppearance.BorderSize = 0;
            this.btnRenovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenovar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRenovar.ForeColor = System.Drawing.Color.White;
            this.btnRenovar.Location = new System.Drawing.Point(130, 10);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(200, 40);
            this.btnRenovar.TabIndex = 0;
            this.btnRenovar.Text = "🔄 Renovar Préstamo";
            this.btnRenovar.UseVisualStyleBackColor = false;
            this.btnRenovar.Click += new System.EventHandler(this.btnRenovar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnDevolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolver.FlatAppearance.BorderSize = 0;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.Location = new System.Drawing.Point(350, 10);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(200, 40);
            this.btnDevolver.TabIndex = 1;
            this.btnDevolver.Text = "↩️ Devolver Recurso";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(570, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(200, 40);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "❌ Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormGestionPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 710);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.groupBoxPrestamosActivos);
            this.Controls.Add(this.groupBoxNuevoPrestamo);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormGestionPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Préstamos";
            this.Load += new System.EventHandler(this.FormGestionPrestamos_Load);
            this.panelTitulo.ResumeLayout(false);
            this.groupBoxNuevoPrestamo.ResumeLayout(false);
            this.groupBoxNuevoPrestamo.PerformLayout();
            this.panelInfoUsuario.ResumeLayout(false);
            this.groupBoxPrestamosActivos.ResumeLayout(false);
            this.groupBoxPrestamosActivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamosActivos)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
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