
namespace AplicacionFinal
{
    partial class formInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInicio));
            this.btnEstadoContable = new System.Windows.Forms.Button();
            this.btnMenuHoy = new System.Windows.Forms.Button();
            this.btnMenuArchivado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstadoContable
            // 
            this.btnEstadoContable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEstadoContable.BackgroundImage")));
            this.btnEstadoContable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstadoContable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstadoContable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoContable.Location = new System.Drawing.Point(185, 367);
            this.btnEstadoContable.Name = "btnEstadoContable";
            this.btnEstadoContable.Size = new System.Drawing.Size(149, 67);
            this.btnEstadoContable.TabIndex = 0;
            this.btnEstadoContable.Text = "Estado Contable";
            this.btnEstadoContable.UseVisualStyleBackColor = true;
            this.btnEstadoContable.Click += new System.EventHandler(this.btnFichaStock_Click);
            // 
            // btnMenuHoy
            // 
            this.btnMenuHoy.BackgroundImage = global::AplicacionFinal.Properties.Resources.btn;
            this.btnMenuHoy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuHoy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuHoy.Location = new System.Drawing.Point(185, 156);
            this.btnMenuHoy.Name = "btnMenuHoy";
            this.btnMenuHoy.Size = new System.Drawing.Size(149, 67);
            this.btnMenuHoy.TabIndex = 0;
            this.btnMenuHoy.Text = "Activad Actual";
            this.btnMenuHoy.UseVisualStyleBackColor = true;
            this.btnMenuHoy.Click += new System.EventHandler(this.ClickHoy);
            // 
            // btnMenuArchivado
            // 
            this.btnMenuArchivado.BackgroundImage = global::AplicacionFinal.Properties.Resources.btn;
            this.btnMenuArchivado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuArchivado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuArchivado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuArchivado.Location = new System.Drawing.Point(185, 255);
            this.btnMenuArchivado.Name = "btnMenuArchivado";
            this.btnMenuArchivado.Size = new System.Drawing.Size(149, 67);
            this.btnMenuArchivado.TabIndex = 0;
            this.btnMenuArchivado.Text = "Actividades Archivadas";
            this.btnMenuArchivado.UseVisualStyleBackColor = true;
            this.btnMenuArchivado.Click += new System.EventHandler(this.btnMenuArchivado_Click);
            // 
            // formInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionFinal.Properties.Resources.fondomain;
            this.ClientSize = new System.Drawing.Size(847, 584);
            this.Controls.Add(this.btnEstadoContable);
            this.Controls.Add(this.btnMenuArchivado);
            this.Controls.Add(this.btnMenuHoy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem MauriTronic";
            this.Load += new System.EventHandler(this.formInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEstadoContable;
        private System.Windows.Forms.Button btnMenuHoy;
        private System.Windows.Forms.Button btnMenuArchivado;
    }
}

