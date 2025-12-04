namespace Presentacion
{
    partial class EditarUsuarioEmergente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAsignarUsuario = new System.Windows.Forms.Label();
            this.tbNuevoNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNuevaContrasena = new System.Windows.Forms.TextBox();
            this.cbSelecEmpleado = new System.Windows.Forms.ComboBox();
            this.lblSelecEmpleado = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cbxBloqueado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblAsignarUsuario
            // 
            this.lblAsignarUsuario.AutoSize = true;
            this.lblAsignarUsuario.Location = new System.Drawing.Point(201, 44);
            this.lblAsignarUsuario.Name = "lblAsignarUsuario";
            this.lblAsignarUsuario.Size = new System.Drawing.Size(103, 16);
            this.lblAsignarUsuario.TabIndex = 0;
            this.lblAsignarUsuario.Text = "Asignar Usuario";
            // 
            // tbNuevoNombreUsuario
            // 
            this.tbNuevoNombreUsuario.Location = new System.Drawing.Point(122, 101);
            this.tbNuevoNombreUsuario.Name = "tbNuevoNombreUsuario";
            this.tbNuevoNombreUsuario.Size = new System.Drawing.Size(307, 22);
            this.tbNuevoNombreUsuario.TabIndex = 1;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(122, 79);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(122, 16);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña";
            // 
            // tbNuevaContrasena
            // 
            this.tbNuevaContrasena.Location = new System.Drawing.Point(122, 167);
            this.tbNuevaContrasena.Name = "tbNuevaContrasena";
            this.tbNuevaContrasena.Size = new System.Drawing.Size(307, 22);
            this.tbNuevaContrasena.TabIndex = 3;
            // 
            // cbSelecEmpleado
            // 
            this.cbSelecEmpleado.FormattingEnabled = true;
            this.cbSelecEmpleado.Location = new System.Drawing.Point(122, 240);
            this.cbSelecEmpleado.Name = "cbSelecEmpleado";
            this.cbSelecEmpleado.Size = new System.Drawing.Size(307, 24);
            this.cbSelecEmpleado.TabIndex = 5;
            // 
            // lblSelecEmpleado
            // 
            this.lblSelecEmpleado.AutoSize = true;
            this.lblSelecEmpleado.Location = new System.Drawing.Point(122, 221);
            this.lblSelecEmpleado.Name = "lblSelecEmpleado";
            this.lblSelecEmpleado.Size = new System.Drawing.Size(144, 16);
            this.lblSelecEmpleado.TabIndex = 6;
            this.lblSelecEmpleado.Text = "Seleccionar empleado";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(24, 386);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(106, 31);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(204, 358);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(106, 31);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cbxBloqueado
            // 
            this.cbxBloqueado.AutoSize = true;
            this.cbxBloqueado.Location = new System.Drawing.Point(122, 299);
            this.cbxBloqueado.Name = "cbxBloqueado";
            this.cbxBloqueado.Size = new System.Drawing.Size(96, 20);
            this.cbxBloqueado.TabIndex = 9;
            this.cbxBloqueado.Text = "Bloqueado";
            this.cbxBloqueado.UseVisualStyleBackColor = true;
            // 
            // EditarUsuarioEmergente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 448);
            this.Controls.Add(this.cbxBloqueado);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblSelecEmpleado);
            this.Controls.Add(this.cbSelecEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNuevaContrasena);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.tbNuevoNombreUsuario);
            this.Controls.Add(this.lblAsignarUsuario);
            this.Name = "EditarUsuarioEmergente";
            this.Text = "EditarUsuarioEmergente";
            this.Load += new System.EventHandler(this.EditarUsuarioEmergente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsignarUsuario;
        private System.Windows.Forms.TextBox tbNuevoNombreUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNuevaContrasena;
        private System.Windows.Forms.ComboBox cbSelecEmpleado;
        private System.Windows.Forms.Label lblSelecEmpleado;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.CheckBox cbxBloqueado;
    }
}