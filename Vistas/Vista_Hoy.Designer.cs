
namespace AplicacionFinal.Vistas
{
    partial class Vista_Hoy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_Hoy));
            this.btnMayores = new System.Windows.Forms.Button();
            this.btnFichaStock = new System.Windows.Forms.Button();
            this.btnNuevoAsiento = new System.Windows.Forms.Button();
            this.btnLibroDiario = new System.Windows.Forms.Button();
            this.btnCerrarDia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMayores
            // 
            this.btnMayores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMayores.BackgroundImage")));
            this.btnMayores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMayores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMayores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayores.Location = new System.Drawing.Point(624, 401);
            this.btnMayores.Name = "btnMayores";
            this.btnMayores.Size = new System.Drawing.Size(149, 67);
            this.btnMayores.TabIndex = 2;
            this.btnMayores.Text = "Mayores";
            this.btnMayores.UseVisualStyleBackColor = true;
            this.btnMayores.Click += new System.EventHandler(this.btnMayores_Click);
            // 
            // btnFichaStock
            // 
            this.btnFichaStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFichaStock.BackgroundImage")));
            this.btnFichaStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFichaStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFichaStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFichaStock.Location = new System.Drawing.Point(149, 401);
            this.btnFichaStock.Name = "btnFichaStock";
            this.btnFichaStock.Size = new System.Drawing.Size(149, 67);
            this.btnFichaStock.TabIndex = 3;
            this.btnFichaStock.Text = "Ficha De Stock";
            this.btnFichaStock.UseVisualStyleBackColor = true;
            this.btnFichaStock.Click += new System.EventHandler(this.btnFichaStock_Click);
            // 
            // btnNuevoAsiento
            // 
            this.btnNuevoAsiento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoAsiento.BackgroundImage")));
            this.btnNuevoAsiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoAsiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAsiento.Location = new System.Drawing.Point(394, 254);
            this.btnNuevoAsiento.Name = "btnNuevoAsiento";
            this.btnNuevoAsiento.Size = new System.Drawing.Size(149, 67);
            this.btnNuevoAsiento.TabIndex = 5;
            this.btnNuevoAsiento.Text = "Nuevo Asiento";
            this.btnNuevoAsiento.UseVisualStyleBackColor = true;
            this.btnNuevoAsiento.Click += new System.EventHandler(this.btnNuevoAsiento_Click);
            // 
            // btnLibroDiario
            // 
            this.btnLibroDiario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLibroDiario.BackgroundImage")));
            this.btnLibroDiario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLibroDiario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLibroDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibroDiario.Location = new System.Drawing.Point(394, 401);
            this.btnLibroDiario.Name = "btnLibroDiario";
            this.btnLibroDiario.Size = new System.Drawing.Size(149, 67);
            this.btnLibroDiario.TabIndex = 6;
            this.btnLibroDiario.Text = "Libro Diario";
            this.btnLibroDiario.UseVisualStyleBackColor = true;
            this.btnLibroDiario.Click += new System.EventHandler(this.btnLibroDiario_Click);
            // 
            // btnCerrarDia
            // 
            this.btnCerrarDia.BackgroundImage = global::AplicacionFinal.Properties.Resources.btncerrar;
            this.btnCerrarDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarDia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarDia.Location = new System.Drawing.Point(12, 544);
            this.btnCerrarDia.Name = "btnCerrarDia";
            this.btnCerrarDia.Size = new System.Drawing.Size(122, 44);
            this.btnCerrarDia.TabIndex = 6;
            this.btnCerrarDia.Text = "Cierre de Actividad";
            this.btnCerrarDia.UseVisualStyleBackColor = true;
            this.btnCerrarDia.Click += new System.EventHandler(this.btnCerrarDia_Click);
            // 
            // Vista_Hoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionFinal.Properties.Resources.fondomenuactivo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 600);
            this.Controls.Add(this.btnMayores);
            this.Controls.Add(this.btnFichaStock);
            this.Controls.Add(this.btnNuevoAsiento);
            this.Controls.Add(this.btnCerrarDia);
            this.Controls.Add(this.btnLibroDiario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vista_Hoy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu Activo";
            this.Load += new System.EventHandler(this.Vista_Hoy_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMayores;
        private System.Windows.Forms.Button btnFichaStock;
        private System.Windows.Forms.Button btnNuevoAsiento;
        private System.Windows.Forms.Button btnLibroDiario;
        private System.Windows.Forms.Button btnCerrarDia;
    }
}