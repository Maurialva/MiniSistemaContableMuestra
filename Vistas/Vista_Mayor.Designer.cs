
namespace AplicacionFinal.Vistas
{
    partial class Vista_Mayor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_Mayor));
            this.dataMayores = new System.Windows.Forms.DataGridView();
            this.MayorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mayorDebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mayorHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mayorresultdebe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mayorresulthaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataMayores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMayores
            // 
            this.dataMayores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMayores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMayores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MayorNombre,
            this.mayorDebe,
            this.mayorHaber,
            this.mayorresultdebe,
            this.mayorresulthaber});
            this.dataMayores.Location = new System.Drawing.Point(145, 220);
            this.dataMayores.MultiSelect = false;
            this.dataMayores.Name = "dataMayores";
            this.dataMayores.ReadOnly = true;
            this.dataMayores.Size = new System.Drawing.Size(636, 315);
            this.dataMayores.TabIndex = 0;
            // 
            // MayorNombre
            // 
            this.MayorNombre.HeaderText = "Nombre de Cuenta";
            this.MayorNombre.Name = "MayorNombre";
            this.MayorNombre.ReadOnly = true;
            // 
            // mayorDebe
            // 
            this.mayorDebe.HeaderText = "Debe";
            this.mayorDebe.Name = "mayorDebe";
            this.mayorDebe.ReadOnly = true;
            // 
            // mayorHaber
            // 
            this.mayorHaber.HeaderText = "Haber";
            this.mayorHaber.Name = "mayorHaber";
            this.mayorHaber.ReadOnly = true;
            // 
            // mayorresultdebe
            // 
            this.mayorresultdebe.HeaderText = "Balance Debe";
            this.mayorresultdebe.Name = "mayorresultdebe";
            this.mayorresultdebe.ReadOnly = true;
            // 
            // mayorresulthaber
            // 
            this.mayorresulthaber.HeaderText = "Balance Haber";
            this.mayorresulthaber.Name = "mayorresulthaber";
            this.mayorresulthaber.ReadOnly = true;
            // 
            // Vista_Mayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionFinal.Properties.Resources.fondomayores;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 593);
            this.Controls.Add(this.dataMayores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vista_Mayor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mayores";
            this.Load += new System.EventHandler(this.Vista_Mayor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMayores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMayores;
        private System.Windows.Forms.DataGridViewTextBoxColumn MayorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn mayorDebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn mayorHaber;
        private System.Windows.Forms.DataGridViewTextBoxColumn mayorresultdebe;
        private System.Windows.Forms.DataGridViewTextBoxColumn mayorresulthaber;
    }
}