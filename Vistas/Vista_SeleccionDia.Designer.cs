
namespace AplicacionFinal.Vistas
{
    partial class Vista_SeleccionDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_SeleccionDia));
            this.btnMayores = new System.Windows.Forms.Button();
            this.btnFichaStock = new System.Windows.Forms.Button();
            this.btnLibroDiario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMayores
            // 
            this.btnMayores.BackgroundImage = global::AplicacionFinal.Properties.Resources.btn;
            this.btnMayores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMayores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMayores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayores.Location = new System.Drawing.Point(553, 187);
            this.btnMayores.Name = "btnMayores";
            this.btnMayores.Size = new System.Drawing.Size(149, 67);
            this.btnMayores.TabIndex = 7;
            this.btnMayores.Text = "Mayores";
            this.btnMayores.UseVisualStyleBackColor = true;
            this.btnMayores.Click += new System.EventHandler(this.btnMayores_Click);
            // 
            // btnFichaStock
            // 
            this.btnFichaStock.BackgroundImage = global::AplicacionFinal.Properties.Resources.btn;
            this.btnFichaStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFichaStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFichaStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFichaStock.Location = new System.Drawing.Point(78, 187);
            this.btnFichaStock.Name = "btnFichaStock";
            this.btnFichaStock.Size = new System.Drawing.Size(149, 67);
            this.btnFichaStock.TabIndex = 8;
            this.btnFichaStock.Text = "Ficha De Stock";
            this.btnFichaStock.UseVisualStyleBackColor = true;
            this.btnFichaStock.Click += new System.EventHandler(this.btnFichaStock_Click);
            // 
            // btnLibroDiario
            // 
            this.btnLibroDiario.BackgroundImage = global::AplicacionFinal.Properties.Resources.btn;
            this.btnLibroDiario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLibroDiario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLibroDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibroDiario.Location = new System.Drawing.Point(323, 187);
            this.btnLibroDiario.Name = "btnLibroDiario";
            this.btnLibroDiario.Size = new System.Drawing.Size(149, 67);
            this.btnLibroDiario.TabIndex = 9;
            this.btnLibroDiario.Text = "Libro Diario";
            this.btnLibroDiario.UseVisualStyleBackColor = true;
            this.btnLibroDiario.Click += new System.EventHandler(this.btnLibroDiario_Click);
            // 
            // Vista_SeleccionDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionFinal.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMayores);
            this.Controls.Add(this.btnFichaStock);
            this.Controls.Add(this.btnLibroDiario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vista_SeleccionDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu Actividad Seleccionada";
            this.Load += new System.EventHandler(this.Vista_SeleccionDia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMayores;
        private System.Windows.Forms.Button btnFichaStock;
        private System.Windows.Forms.Button btnLibroDiario;
    }
}