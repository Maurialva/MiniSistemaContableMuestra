
namespace AplicacionFinal.Vistas
{
    partial class Vista_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_Stock));
            this.dataFichaStock = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidaCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saliPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saliTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataFichaStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataFichaStock
            // 
            this.dataFichaStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFichaStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFichaStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Detalle,
            this.entCantidad,
            this.entPrecio,
            this.entTotal,
            this.salidaCant,
            this.saliPrecio,
            this.saliTotal,
            this.saldoCantidad,
            this.saldoPrecio,
            this.saldoTotal});
            this.dataFichaStock.Location = new System.Drawing.Point(89, 202);
            this.dataFichaStock.MultiSelect = false;
            this.dataFichaStock.Name = "dataFichaStock";
            this.dataFichaStock.ReadOnly = true;
            this.dataFichaStock.Size = new System.Drawing.Size(918, 323);
            this.dataFichaStock.TabIndex = 0;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            // 
            // entCantidad
            // 
            this.entCantidad.HeaderText = "Ent. Cantidad";
            this.entCantidad.Name = "entCantidad";
            this.entCantidad.ReadOnly = true;
            // 
            // entPrecio
            // 
            this.entPrecio.HeaderText = "Ent. Precio";
            this.entPrecio.Name = "entPrecio";
            this.entPrecio.ReadOnly = true;
            // 
            // entTotal
            // 
            this.entTotal.HeaderText = "Ent. Total";
            this.entTotal.Name = "entTotal";
            this.entTotal.ReadOnly = true;
            // 
            // salidaCant
            // 
            this.salidaCant.HeaderText = "Sali. Cantidad";
            this.salidaCant.Name = "salidaCant";
            this.salidaCant.ReadOnly = true;
            // 
            // saliPrecio
            // 
            this.saliPrecio.HeaderText = "Sali. Precio";
            this.saliPrecio.Name = "saliPrecio";
            this.saliPrecio.ReadOnly = true;
            // 
            // saliTotal
            // 
            this.saliTotal.HeaderText = "Sali. Total";
            this.saliTotal.Name = "saliTotal";
            this.saliTotal.ReadOnly = true;
            // 
            // saldoCantidad
            // 
            this.saldoCantidad.HeaderText = "Saldo Cantidad";
            this.saldoCantidad.Name = "saldoCantidad";
            this.saldoCantidad.ReadOnly = true;
            // 
            // saldoPrecio
            // 
            this.saldoPrecio.HeaderText = "Saldo Precio";
            this.saldoPrecio.Name = "saldoPrecio";
            this.saldoPrecio.ReadOnly = true;
            // 
            // saldoTotal
            // 
            this.saldoTotal.HeaderText = "Saldo Total";
            this.saldoTotal.Name = "saldoTotal";
            this.saldoTotal.ReadOnly = true;
            // 
            // Vista_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionFinal.Properties.Resources.fondostock;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 601);
            this.Controls.Add(this.dataFichaStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vista_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ficha De Stock";
            this.Load += new System.EventHandler(this.Vista_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFichaStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataFichaStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn entCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn entPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn entTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn salidaCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn saliPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn saliTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoTotal;
    }
}