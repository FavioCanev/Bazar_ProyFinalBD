namespace Presentacion
{
    partial class EditarProveedorEmergente
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
            this.tbRucProveedor = new System.Windows.Forms.TextBox();
            this.lblRuc = new System.Windows.Forms.Label();
            this.tbDireccionProveedor = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.tbNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblCrearProveedor = new System.Windows.Forms.Label();
            this.cbxActivo = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRucProveedor
            // 
            this.tbRucProveedor.Location = new System.Drawing.Point(66, 196);
            this.tbRucProveedor.Name = "tbRucProveedor";
            this.tbRucProveedor.Size = new System.Drawing.Size(125, 20);
            this.tbRucProveedor.TabIndex = 12;
            // 
            // lblRuc
            // 
            this.lblRuc.AutoSize = true;
            this.lblRuc.Location = new System.Drawing.Point(69, 180);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(30, 13);
            this.lblRuc.TabIndex = 11;
            this.lblRuc.Text = "RUC";
            // 
            // tbDireccionProveedor
            // 
            this.tbDireccionProveedor.Location = new System.Drawing.Point(66, 142);
            this.tbDireccionProveedor.Name = "tbDireccionProveedor";
            this.tbDireccionProveedor.Size = new System.Drawing.Size(267, 20);
            this.tbDireccionProveedor.TabIndex = 10;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(69, 126);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Location = new System.Drawing.Point(66, 68);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProveedor.TabIndex = 8;
            this.lblNombreProveedor.Text = "Nombre";
            // 
            // tbNombreProveedor
            // 
            this.tbNombreProveedor.Location = new System.Drawing.Point(66, 87);
            this.tbNombreProveedor.Name = "tbNombreProveedor";
            this.tbNombreProveedor.Size = new System.Drawing.Size(267, 20);
            this.tbNombreProveedor.TabIndex = 7;
            // 
            // lblCrearProveedor
            // 
            this.lblCrearProveedor.AutoSize = true;
            this.lblCrearProveedor.Location = new System.Drawing.Point(150, 37);
            this.lblCrearProveedor.Name = "lblCrearProveedor";
            this.lblCrearProveedor.Size = new System.Drawing.Size(84, 13);
            this.lblCrearProveedor.TabIndex = 13;
            this.lblCrearProveedor.Text = "Crear Proveedor";
            // 
            // cbxActivo
            // 
            this.cbxActivo.AutoSize = true;
            this.cbxActivo.Location = new System.Drawing.Point(255, 196);
            this.cbxActivo.Name = "cbxActivo";
            this.cbxActivo.Size = new System.Drawing.Size(56, 17);
            this.cbxActivo.TabIndex = 16;
            this.cbxActivo.Text = "Activo";
            this.cbxActivo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(66, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(258, 246);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // EditarProveedorEmergente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 313);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbxActivo);
            this.Controls.Add(this.lblCrearProveedor);
            this.Controls.Add(this.tbRucProveedor);
            this.Controls.Add(this.lblRuc);
            this.Controls.Add(this.tbDireccionProveedor);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombreProveedor);
            this.Controls.Add(this.tbNombreProveedor);
            this.Name = "EditarProveedorEmergente";
            this.Text = "EditarProveedorEmergente";
            this.Load += new System.EventHandler(this.EditarProveedorEmergente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRucProveedor;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.TextBox tbDireccionProveedor;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.TextBox tbNombreProveedor;
        private System.Windows.Forms.Label lblCrearProveedor;
        private System.Windows.Forms.CheckBox cbxActivo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}