
namespace AplicacionFinal.Vistas
{
    partial class Vista_Archivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_Archivos));
            this.btnLibroSeleccionado = new System.Windows.Forms.Button();
            this.cboxLibros = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnLibroSeleccionado
            // 
            this.btnLibroSeleccionado.BackgroundImage = global::AplicacionFinal.Properties.Resources.btn;
            this.btnLibroSeleccionado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLibroSeleccionado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLibroSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibroSeleccionado.Location = new System.Drawing.Point(275, 241);
            this.btnLibroSeleccionado.Name = "btnLibroSeleccionado";
            this.btnLibroSeleccionado.Size = new System.Drawing.Size(199, 61);
            this.btnLibroSeleccionado.TabIndex = 0;
            this.btnLibroSeleccionado.Text = "Archivo Seleccionado";
            this.btnLibroSeleccionado.UseVisualStyleBackColor = true;
            this.btnLibroSeleccionado.Click += new System.EventHandler(this.btnLibroSeleccionado_Click);
            // 
            // cboxLibros
            // 
            this.cboxLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxLibros.FormattingEnabled = true;
            this.cboxLibros.Location = new System.Drawing.Point(192, 166);
            this.cboxLibros.Name = "cboxLibros";
            this.cboxLibros.Size = new System.Drawing.Size(372, 26);
            this.cboxLibros.TabIndex = 1;
            // 
            // Vista_Archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionFinal.Properties.Resources.fondoarchivo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.cboxLibros);
            this.Controls.Add(this.btnLibroSeleccionado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vista_Archivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Archivo de Actividades";
            this.Load += new System.EventHandler(this.Vista_Archivos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLibroSeleccionado;
        private System.Windows.Forms.ComboBox cboxLibros;
    }
}