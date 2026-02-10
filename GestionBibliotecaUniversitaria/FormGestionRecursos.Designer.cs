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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.groupBoxRegistro = new System.Windows.Forms.GroupBox();
            this.lblTipoRecurso = new System.Windows.Forms.Label();
            this.cmbTipoRecurso = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBoxListado = new System.Windows.Forms.GroupBox();
            this.dgvRecursos = new System.Windows.Forms.DataGridView();
            this.colRecurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            this.groupBoxRegistro.SuspendLayout();
            this.groupBoxListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
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
            this.lblTituloForm.Text = "📚 Gestión de Recursos Bibliográficos";
            this.lblTituloForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxRegistro
            // 
            this.groupBoxRegistro.Controls.Add(this.lblTipoRecurso);
            this.groupBoxRegistro.Controls.Add(this.cmbTipoRecurso);
            this.groupBoxRegistro.Controls.Add(this.lblTitulo);
            this.groupBoxRegistro.Controls.Add(this.txtTitulo);
            this.groupBoxRegistro.Controls.Add(this.lblAutor);
            this.groupBoxRegistro.Controls.Add(this.txtAutor);
            this.groupBoxRegistro.Controls.Add(this.lblAño);
            this.groupBoxRegistro.Controls.Add(this.txtAño);
            this.groupBoxRegistro.Controls.Add(this.lblEdicion);
            this.groupBoxRegistro.Controls.Add(this.txtEdicion);
            this.groupBoxRegistro.Controls.Add(this.lblCantidad);
            this.groupBoxRegistro.Controls.Add(this.txtCantidad);
            this.groupBoxRegistro.Controls.Add(this.btnRegistrar);
            this.groupBoxRegistro.Controls.Add(this.btnLimpiar);
            this.groupBoxRegistro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxRegistro.Location = new System.Drawing.Point(20, 80);
            this.groupBoxRegistro.Name = "groupBoxRegistro";
            this.groupBoxRegistro.Size = new System.Drawing.Size(860, 220);
            this.groupBoxRegistro.TabIndex = 1;
            this.groupBoxRegistro.TabStop = false;
            this.groupBoxRegistro.Text = "Registro de Nuevo Recurso";
            // 
            // lblTipoRecurso
            // 
            this.lblTipoRecurso.AutoSize = true;
            this.lblTipoRecurso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipoRecurso.Location = new System.Drawing.Point(20, 35);
            this.lblTipoRecurso.Name = "lblTipoRecurso";
            this.lblTipoRecurso.Size = new System.Drawing.Size(99, 20);
            this.lblTipoRecurso.TabIndex = 0;
            this.lblTipoRecurso.Text = "Tipo Recurso:";
            // 
            // cmbTipoRecurso
            // 
            this.cmbTipoRecurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoRecurso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbTipoRecurso.FormattingEnabled = true;
            this.cmbTipoRecurso.Items.AddRange(new object[] {
            "Libro",
            "Revista",
            "Novela"});
            this.cmbTipoRecurso.Location = new System.Drawing.Point(130, 32);
            this.cmbTipoRecurso.Name = "cmbTipoRecurso";
            this.cmbTipoRecurso.Size = new System.Drawing.Size(200, 28);
            this.cmbTipoRecurso.TabIndex = 1;
            this.cmbTipoRecurso.SelectedIndexChanged += new System.EventHandler(this.cmbTipoRecurso_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTitulo.Location = new System.Drawing.Point(20, 75);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(50, 20);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitulo.Location = new System.Drawing.Point(130, 72);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(300, 27);
            this.txtTitulo.TabIndex = 3;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAutor.Location = new System.Drawing.Point(20, 115);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(49, 20);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAutor.Location = new System.Drawing.Point(130, 112);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(300, 27);
            this.txtAutor.TabIndex = 5;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAño.Location = new System.Drawing.Point(470, 35);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(39, 20);
            this.lblAño.TabIndex = 6;
            this.lblAño.Text = "Año:";
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAño.Location = new System.Drawing.Point(540, 32);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(150, 27);
            this.txtAño.TabIndex = 7;
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEdicion.Location = new System.Drawing.Point(470, 75);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(62, 20);
            this.lblEdicion.TabIndex = 8;
            this.lblEdicion.Text = "Edición:";
            this.lblEdicion.Visible = false;
            // 
            // txtEdicion
            // 
            this.txtEdicion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEdicion.Location = new System.Drawing.Point(540, 72);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(150, 27);
            this.txtEdicion.TabIndex = 9;
            this.txtEdicion.Visible = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCantidad.Location = new System.Drawing.Point(470, 115);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 20);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantidad.Location = new System.Drawing.Point(540, 112);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(150, 27);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.Text = "1";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(130, 160);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(200, 40);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "✓ Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(350, 160);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(200, 40);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "🔄 Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBoxListado
            // 
            this.groupBoxListado.Controls.Add(this.dgvRecursos);
            this.groupBoxListado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxListado.Location = new System.Drawing.Point(20, 320);
            this.groupBoxListado.Name = "groupBoxListado";
            this.groupBoxListado.Size = new System.Drawing.Size(860, 250);
            this.groupBoxListado.TabIndex = 2;
            this.groupBoxListado.TabStop = false;
            this.groupBoxListado.Text = "Recursos Registrados";
            // 
            // dgvRecursos
            // 
            this.dgvRecursos.AllowUserToAddRows = false;
            this.dgvRecursos.AllowUserToDeleteRows = false;
            this.dgvRecursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecursos.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecurso});
            this.dgvRecursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecursos.Location = new System.Drawing.Point(3, 26);
            this.dgvRecursos.Name = "dgvRecursos";
            this.dgvRecursos.ReadOnly = true;
            this.dgvRecursos.RowHeadersWidth = 51;
            this.dgvRecursos.RowTemplate.Height = 24;
            this.dgvRecursos.Size = new System.Drawing.Size(854, 221);
            this.dgvRecursos.TabIndex = 0;
            // 
            // colRecurso
            // 
            this.colRecurso.HeaderText = "Recurso";
            this.colRecurso.MinimumWidth = 6;
            this.colRecurso.Name = "colRecurso";
            this.colRecurso.ReadOnly = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(350, 590);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(200, 40);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "❌ Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormGestionRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBoxListado);
            this.Controls.Add(this.groupBoxRegistro);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormGestionRecursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Recursos";
            this.Load += new System.EventHandler(this.FormGestionRecursos_Load);
            this.panelTitulo.ResumeLayout(false);
            this.groupBoxRegistro.ResumeLayout(false);
            this.groupBoxRegistro.PerformLayout();
            this.groupBoxListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).EndInit();
            this.ResumeLayout(false);
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