namespace SistemaGestionBibliotecaUniversitaria
{
    partial class FormPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnGestionRecursos = new System.Windows.Forms.Button();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.btnGestionPrestamos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelTitulo.Controls.Add(this.lblSubtitulo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(600, 100);
            this.panelTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(600, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema de Gestión";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 60);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(600, 40);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Biblioteca Universitaria";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnGestionRecursos);
            this.panelBotones.Controls.Add(this.btnGestionUsuarios);
            this.panelBotones.Controls.Add(this.btnGestionPrestamos);
            this.panelBotones.Controls.Add(this.btnSalir);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotones.Location = new System.Drawing.Point(0, 100);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Padding = new System.Windows.Forms.Padding(80, 40, 80, 40);
            this.panelBotones.Size = new System.Drawing.Size(600, 350);
            this.panelBotones.TabIndex = 1;
            // 
            // btnGestionRecursos
            // 
            this.btnGestionRecursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnGestionRecursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionRecursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionRecursos.FlatAppearance.BorderSize = 0;
            this.btnGestionRecursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionRecursos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGestionRecursos.ForeColor = System.Drawing.Color.White;
            this.btnGestionRecursos.Location = new System.Drawing.Point(80, 40);
            this.btnGestionRecursos.Name = "btnGestionRecursos";
            this.btnGestionRecursos.Size = new System.Drawing.Size(440, 50);
            this.btnGestionRecursos.TabIndex = 0;
            this.btnGestionRecursos.Text = "📚 Gestión de Recursos";
            this.btnGestionRecursos.UseVisualStyleBackColor = false;
            this.btnGestionRecursos.Click += new System.EventHandler(this.btnGestionRecursos_Click);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnGestionUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionUsuarios.FlatAppearance.BorderSize = 0;
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGestionUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(80, 90);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(440, 50);
            this.btnGestionUsuarios.TabIndex = 1;
            this.btnGestionUsuarios.Text = "👥 Gestión de Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // btnGestionPrestamos
            // 
            this.btnGestionPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnGestionPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionPrestamos.FlatAppearance.BorderSize = 0;
            this.btnGestionPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionPrestamos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGestionPrestamos.ForeColor = System.Drawing.Color.White;
            this.btnGestionPrestamos.Location = new System.Drawing.Point(80, 140);
            this.btnGestionPrestamos.Name = "btnGestionPrestamos";
            this.btnGestionPrestamos.Size = new System.Drawing.Size(440, 50);
            this.btnGestionPrestamos.TabIndex = 2;
            this.btnGestionPrestamos.Text = "📋 Gestión de Préstamos";
            this.btnGestionPrestamos.UseVisualStyleBackColor = false;
            this.btnGestionPrestamos.Click += new System.EventHandler(this.btnGestionPrestamos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(80, 260);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(440, 50);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "❌ Salir del Sistema";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión Bibliotecaria";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnGestionRecursos;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Button btnGestionPrestamos;
        private System.Windows.Forms.Button btnSalir;
    }
}