using System;

namespace LAB3_U20240388.Forms
{
    partial class frmRegistrarProductoCmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarProductoCmd));
            this.btnGuardar2 = new System.Windows.Forms.Button();
            this.txtStockMinimo2 = new System.Windows.Forms.TextBox();
            this.txtCantidad2 = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario2 = new System.Windows.Forms.TextBox();
            this.txtCategoria2 = new System.Windows.Forms.TextBox();
            this.txtCodigo2 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.lblStockMinimo2 = new System.Windows.Forms.Label();
            this.lblCantidad2 = new System.Windows.Forms.Label();
            this.lblPrecioUnitario2 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.lblCategoria2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRegistro2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar2
            // 
            this.btnGuardar2.BackColor = System.Drawing.Color.Lime;
            this.btnGuardar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar2.Location = new System.Drawing.Point(428, 336);
            this.btnGuardar2.Name = "btnGuardar2";
            this.btnGuardar2.Size = new System.Drawing.Size(98, 41);
            this.btnGuardar2.TabIndex = 31;
            this.btnGuardar2.Text = "Guardar";
            this.btnGuardar2.UseVisualStyleBackColor = false;
            // 
            // txtStockMinimo2
            // 
            this.txtStockMinimo2.Location = new System.Drawing.Point(637, 265);
            this.txtStockMinimo2.Name = "txtStockMinimo2";
            this.txtStockMinimo2.Size = new System.Drawing.Size(220, 22);
            this.txtStockMinimo2.TabIndex = 30;
            // 
            // txtCantidad2
            // 
            this.txtCantidad2.Location = new System.Drawing.Point(368, 265);
            this.txtCantidad2.Name = "txtCantidad2";
            this.txtCantidad2.Size = new System.Drawing.Size(220, 22);
            this.txtCantidad2.TabIndex = 29;
            // 
            // txtPrecioUnitario2
            // 
            this.txtPrecioUnitario2.Location = new System.Drawing.Point(106, 265);
            this.txtPrecioUnitario2.Name = "txtPrecioUnitario2";
            this.txtPrecioUnitario2.Size = new System.Drawing.Size(220, 22);
            this.txtPrecioUnitario2.TabIndex = 28;
            // 
            // txtCategoria2
            // 
            this.txtCategoria2.Location = new System.Drawing.Point(637, 158);
            this.txtCategoria2.Name = "txtCategoria2";
            this.txtCategoria2.Size = new System.Drawing.Size(220, 22);
            this.txtCategoria2.TabIndex = 27;
            // 
            // txtCodigo2
            // 
            this.txtCodigo2.Location = new System.Drawing.Point(368, 158);
            this.txtCodigo2.Name = "txtCodigo2";
            this.txtCodigo2.Size = new System.Drawing.Size(220, 22);
            this.txtCodigo2.TabIndex = 26;
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(106, 158);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(220, 22);
            this.txtNombre2.TabIndex = 25;
            // 
            // lblStockMinimo2
            // 
            this.lblStockMinimo2.AutoSize = true;
            this.lblStockMinimo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMinimo2.Location = new System.Drawing.Point(684, 230);
            this.lblStockMinimo2.Name = "lblStockMinimo2";
            this.lblStockMinimo2.Size = new System.Drawing.Size(117, 18);
            this.lblStockMinimo2.TabIndex = 24;
            this.lblStockMinimo2.Text = "Stock Minimo:";
            // 
            // lblCantidad2
            // 
            this.lblCantidad2.AutoSize = true;
            this.lblCantidad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad2.Location = new System.Drawing.Point(447, 230);
            this.lblCantidad2.Name = "lblCantidad2";
            this.lblCantidad2.Size = new System.Drawing.Size(79, 18);
            this.lblCantidad2.TabIndex = 23;
            this.lblCantidad2.Text = "Cantidad:";
            // 
            // lblPrecioUnitario2
            // 
            this.lblPrecioUnitario2.AutoSize = true;
            this.lblPrecioUnitario2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario2.Location = new System.Drawing.Point(158, 230);
            this.lblPrecioUnitario2.Name = "lblPrecioUnitario2";
            this.lblPrecioUnitario2.Size = new System.Drawing.Size(126, 18);
            this.lblPrecioUnitario2.TabIndex = 22;
            this.lblPrecioUnitario2.Text = "Precio Unitario:";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo2.Location = new System.Drawing.Point(459, 137);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(67, 18);
            this.lblCodigo2.TabIndex = 21;
            this.lblCodigo2.Text = "Codigo:";
            // 
            // lblCategoria2
            // 
            this.lblCategoria2.AutoSize = true;
            this.lblCategoria2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria2.Location = new System.Drawing.Point(702, 137);
            this.lblCategoria2.Name = "lblCategoria2";
            this.lblCategoria2.Size = new System.Drawing.Size(86, 18);
            this.lblCategoria2.TabIndex = 20;
            this.lblCategoria2.Text = "Categoria:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre2.Location = new System.Drawing.Point(182, 137);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(78, 18);
            this.lblNombre2.TabIndex = 19;
            this.lblNombre2.Text = "Nombre: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(428, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "EDICION DE INVENTARIO";
            // 
            // dgvRegistro2
            // 
            this.dgvRegistro2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro2.Location = new System.Drawing.Point(0, 384);
            this.dgvRegistro2.Name = "dgvRegistro2";
            this.dgvRegistro2.RowHeadersWidth = 51;
            this.dgvRegistro2.RowTemplate.Height = 24;
            this.dgvRegistro2.Size = new System.Drawing.Size(955, 332);
            this.dgvRegistro2.TabIndex = 32;
            // 
            // frmRegistrarProductoCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 716);
            this.Controls.Add(this.dgvRegistro2);
            this.Controls.Add(this.btnGuardar2);
            this.Controls.Add(this.txtStockMinimo2);
            this.Controls.Add(this.txtCantidad2);
            this.Controls.Add(this.txtPrecioUnitario2);
            this.Controls.Add(this.txtCategoria2);
            this.Controls.Add(this.txtCodigo2);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.lblStockMinimo2);
            this.Controls.Add(this.lblCantidad2);
            this.Controls.Add(this.lblPrecioUnitario2);
            this.Controls.Add(this.lblCodigo2);
            this.Controls.Add(this.lblCategoria2);
            this.Controls.Add(this.lblNombre2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistrarProductoCmd";
            this.Text = "frmRegistrarProductoCmd";
            this.Load += new System.EventHandler(this.frmRegistrarProductoCmd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmRegistrarProductoCmd_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnGuardar2;
        private System.Windows.Forms.TextBox txtStockMinimo2;
        private System.Windows.Forms.TextBox txtCantidad2;
        private System.Windows.Forms.TextBox txtPrecioUnitario2;
        private System.Windows.Forms.TextBox txtCategoria2;
        private System.Windows.Forms.TextBox txtCodigo2;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Label lblStockMinimo2;
        private System.Windows.Forms.Label lblCantidad2;
        private System.Windows.Forms.Label lblPrecioUnitario2;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Label lblCategoria2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRegistro2;
    }
}