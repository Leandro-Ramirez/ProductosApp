namespace ProductoApp.Formularios
{
    partial class FormProducto
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
            this.grpBxDatos = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nmrExistencia = new System.Windows.Forms.NumericUpDown();
            this.nmrPrecio = new System.Windows.Forms.NumericUpDown();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpBxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxDatos
            // 
            this.grpBxDatos.Controls.Add(this.cmbUnidadMedida);
            this.grpBxDatos.Controls.Add(this.nmrPrecio);
            this.grpBxDatos.Controls.Add(this.nmrExistencia);
            this.grpBxDatos.Controls.Add(this.txtNombre);
            this.grpBxDatos.Controls.Add(this.lblUnidadMedida);
            this.grpBxDatos.Controls.Add(this.lblFechaVencimiento);
            this.grpBxDatos.Controls.Add(this.lblPrecio);
            this.grpBxDatos.Controls.Add(this.lblExistencia);
            this.grpBxDatos.Controls.Add(this.lblDescripcion);
            this.grpBxDatos.Controls.Add(this.lblNombre);
            this.grpBxDatos.Location = new System.Drawing.Point(12, 12);
            this.grpBxDatos.Name = "grpBxDatos";
            this.grpBxDatos.Size = new System.Drawing.Size(810, 358);
            this.grpBxDatos.TabIndex = 0;
            this.grpBxDatos.TabStop = false;
            this.grpBxDatos.Text = "Datos del Producto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(50, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(53, 96);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(53, 129);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(55, 13);
            this.lblExistencia.TabIndex = 2;
            this.lblExistencia.Text = "Exixtencia";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(53, 162);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(53, 192);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(113, 13);
            this.lblFechaVencimiento.TabIndex = 4;
            this.lblFechaVencimiento.Text = "Fecha de Vencimiento";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(53, 223);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(94, 13);
            this.lblUnidadMedida.TabIndex = 5;
            this.lblUnidadMedida.Text = "Unidad de Medida";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(473, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // nmrExistencia
            // 
            this.nmrExistencia.Location = new System.Drawing.Point(473, 121);
            this.nmrExistencia.Name = "nmrExistencia";
            this.nmrExistencia.Size = new System.Drawing.Size(250, 20);
            this.nmrExistencia.TabIndex = 7;
            // 
            // nmrPrecio
            // 
            this.nmrPrecio.Location = new System.Drawing.Point(473, 162);
            this.nmrPrecio.Name = "nmrPrecio";
            this.nmrPrecio.Size = new System.Drawing.Size(250, 20);
            this.nmrPrecio.TabIndex = 8;
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Items.AddRange(new object[] {
            "Unidades",
            "Litros",
            "Mililitros",
            "Kilogramo",
            "Gramos",
            "Libras"});
            this.cmbUnidadMedida.Location = new System.Drawing.Point(473, 223);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(250, 21);
            this.cmbUnidadMedida.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.ForeColor = System.Drawing.Color.Green;
            this.btnAceptar.Location = new System.Drawing.Point(616, 419);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 30);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(722, 419);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpBxDatos);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.grpBxDatos.ResumeLayout(false);
            this.grpBxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxDatos;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.NumericUpDown nmrPrecio;
        private System.Windows.Forms.NumericUpDown nmrExistencia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}