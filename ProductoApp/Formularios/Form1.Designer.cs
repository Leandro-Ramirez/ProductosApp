namespace ProductoApp.Formularios
{
    partial class Form1
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbBuscador = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pnlRangoPrecio = new System.Windows.Forms.Panel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.pnlId = new System.Windows.Forms.Panel();
            this.cmbId = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pnlRangoPrecio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.pnlId.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(510, 419);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 30);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(616, 419);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 30);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(722, 419);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // cmbBuscador
            // 
            this.cmbBuscador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscador.FormattingEnabled = true;
            this.cmbBuscador.Items.AddRange(new object[] {
            "Id",
            "Unidad e Medida",
            "Rango de Precio",
            "Fecha de Vencimiento"});
            this.cmbBuscador.Location = new System.Drawing.Point(12, 12);
            this.cmbBuscador.Name = "cmbBuscador";
            this.cmbBuscador.Size = new System.Drawing.Size(200, 21);
            this.cmbBuscador.TabIndex = 3;
            this.cmbBuscador.SelectedIndexChanged += new System.EventHandler(this.CmbBuscador_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(3, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // pnlRangoPrecio
            // 
            this.pnlRangoPrecio.Controls.Add(this.numericUpDown2);
            this.pnlRangoPrecio.Controls.Add(this.numericUpDown1);
            this.pnlRangoPrecio.Location = new System.Drawing.Point(221, 57);
            this.pnlRangoPrecio.Name = "pnlRangoPrecio";
            this.pnlRangoPrecio.Size = new System.Drawing.Size(320, 27);
            this.pnlRangoPrecio.TabIndex = 5;
            this.pnlRangoPrecio.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlRangoPrecio_Paint);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(159, 4);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(150, 20);
            this.numericUpDown2.TabIndex = 6;
            // 
            // pnlId
            // 
            this.pnlId.Controls.Add(this.cmbId);
            this.pnlId.Location = new System.Drawing.Point(218, 12);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(320, 27);
            this.pnlId.TabIndex = 6;
            // 
            // cmbId
            // 
            this.cmbId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbId.FormattingEnabled = true;
            this.cmbId.Location = new System.Drawing.Point(3, 3);
            this.cmbId.Name = "cmbId";
            this.cmbId.Size = new System.Drawing.Size(300, 21);
            this.cmbId.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 133);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(810, 280);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pnlId);
            this.Controls.Add(this.pnlRangoPrecio);
            this.Controls.Add(this.cmbBuscador);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pnlRangoPrecio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.pnlId.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbBuscador;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel pnlRangoPrecio;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.ComboBox cmbId;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}