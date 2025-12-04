namespace Presentacion
{
    partial class ProveedorPanel
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
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.btnEditarProveedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AllowUserToResizeColumns = false;
            this.dgvProveedores.AllowUserToResizeRows = false;
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(9, 11);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.RowTemplate.Height = 24;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(877, 423);
            this.dgvProveedores.TabIndex = 1;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(735, 452);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(151, 41);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.Location = new System.Drawing.Point(532, 452);
            this.btnNuevoProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(151, 41);
            this.btnNuevoProveedor.TabIndex = 3;
            this.btnNuevoProveedor.Text = "Nuevo Proveedor";
            this.btnNuevoProveedor.UseVisualStyleBackColor = true;
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.Location = new System.Drawing.Point(325, 452);
            this.btnEditarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(151, 41);
            this.btnEditarProveedor.TabIndex = 4;
            this.btnEditarProveedor.Text = "Editar Proveedor";
            this.btnEditarProveedor.UseVisualStyleBackColor = true;
            this.btnEditarProveedor.Click += new System.EventHandler(this.btnEditarProveedor_Click);
            // 
            // ProveedorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 527);
            this.Controls.Add(this.btnEditarProveedor);
            this.Controls.Add(this.btnNuevoProveedor);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvProveedores);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProveedorPanel";
            this.Text = "ProveedorPanel";
            this.Load += new System.EventHandler(this.ProveedorPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNuevoProveedor;
        private System.Windows.Forms.Button btnEditarProveedor;
    }
}