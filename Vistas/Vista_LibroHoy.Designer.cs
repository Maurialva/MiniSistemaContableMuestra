
namespace AplicacionFinal.Vistas
{
    partial class Vista_LibroHoy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_LibroHoy));
            this.dataLibro = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLibro
            // 
            this.dataLibro.AllowUserToResizeRows = false;
            this.dataLibro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLibro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Cuenta_Tipo,
            this.Cuenta_Nombre,
            this.Concepto,
            this.Cuenta_Debe,
            this.Cuenta_Haber});
            this.dataLibro.Location = new System.Drawing.Point(117, 138);
            this.dataLibro.MultiSelect = false;
            this.dataLibro.Name = "dataLibro";
            this.dataLibro.ReadOnly = true;
            this.dataLibro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataLibro.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLibro.Size = new System.Drawing.Size(804, 475);
            this.dataLibro.TabIndex = 0;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Cuenta_Tipo
            // 
            this.Cuenta_Tipo.HeaderText = "Var";
            this.Cuenta_Tipo.Name = "Cuenta_Tipo";
            this.Cuenta_Tipo.ReadOnly = true;
            // 
            // Cuenta_Nombre
            // 
            this.Cuenta_Nombre.HeaderText = "Concepto";
            this.Cuenta_Nombre.Name = "Cuenta_Nombre";
            this.Cuenta_Nombre.ReadOnly = true;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Cuenta_Debe
            // 
            this.Cuenta_Debe.HeaderText = "Debe";
            this.Cuenta_Debe.Name = "Cuenta_Debe";
            this.Cuenta_Debe.ReadOnly = true;
            // 
            // Cuenta_Haber
            // 
            this.Cuenta_Haber.HeaderText = "Haber";
            this.Cuenta_Haber.Name = "Cuenta_Haber";
            this.Cuenta_Haber.ReadOnly = true;
            // 
            // Vista_LibroHoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionFinal.Properties.Resources.fondolibrodiario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1033, 664);
            this.Controls.Add(this.dataLibro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vista_LibroHoy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Libro Diario";
            this.Load += new System.EventHandler(this.Vista_LibroHoy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Haber;
    }
}