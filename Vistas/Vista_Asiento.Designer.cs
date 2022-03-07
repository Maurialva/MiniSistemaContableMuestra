
namespace AplicacionFinal.Vistas
{
    partial class Vista_Asiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_Asiento));
            this.button1 = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cbCuenta = new System.Windows.Forms.ComboBox();
            this.lblTransaccion = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblMetodo1 = new System.Windows.Forms.Label();
            this.cbTransaccion = new System.Windows.Forms.ComboBox();
            this.cbMetodoPago = new System.Windows.Forms.ComboBox();
            this.cmMetodo2 = new System.Windows.Forms.ComboBox();
            this.lblMetodo2 = new System.Windows.Forms.Label();
            this.numMetodo1 = new System.Windows.Forms.NumericUpDown();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.checkMetodo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPorcentaje1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMetodo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AplicacionFinal.Properties.Resources.btn;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(304, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(526, 117);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(147, 20);
            this.txtMonto.TabIndex = 1;
            // 
            // cbCuenta
            // 
            this.cbCuenta.FormattingEnabled = true;
            this.cbCuenta.Location = new System.Drawing.Point(304, 117);
            this.cbCuenta.Name = "cbCuenta";
            this.cbCuenta.Size = new System.Drawing.Size(147, 21);
            this.cbCuenta.TabIndex = 2;
            this.cbCuenta.Text = "Seleccione";
            this.cbCuenta.SelectedIndexChanged += new System.EventHandler(this.cbCuenta_SelectedIndexChanged);
            // 
            // lblTransaccion
            // 
            this.lblTransaccion.AutoSize = true;
            this.lblTransaccion.Location = new System.Drawing.Point(85, 79);
            this.lblTransaccion.Name = "lblTransaccion";
            this.lblTransaccion.Size = new System.Drawing.Size(66, 13);
            this.lblTransaccion.TabIndex = 3;
            this.lblTransaccion.Text = "Transaccion";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(523, 86);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "Monto";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(301, 79);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(41, 13);
            this.lblCuenta.TabIndex = 3;
            this.lblCuenta.Text = "Cuenta";
            // 
            // lblMetodo1
            // 
            this.lblMetodo1.AutoSize = true;
            this.lblMetodo1.Location = new System.Drawing.Point(85, 194);
            this.lblMetodo1.Name = "lblMetodo1";
            this.lblMetodo1.Size = new System.Drawing.Size(86, 13);
            this.lblMetodo1.TabIndex = 3;
            this.lblMetodo1.Text = "Metodo de Pago";
            // 
            // cbTransaccion
            // 
            this.cbTransaccion.FormattingEnabled = true;
            this.cbTransaccion.Items.AddRange(new object[] {
            "Compra",
            "Venta",
            "Devolucion por Venta",
            "Devolucion por Compra",
            "Ingreso",
            "Salida"});
            this.cbTransaccion.Location = new System.Drawing.Point(88, 117);
            this.cbTransaccion.Name = "cbTransaccion";
            this.cbTransaccion.Size = new System.Drawing.Size(147, 21);
            this.cbTransaccion.TabIndex = 2;
            this.cbTransaccion.Text = "Seleccione";
            this.cbTransaccion.SelectedIndexChanged += new System.EventHandler(this.cbTransaccion_SelectedIndexChanged);
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.FormattingEnabled = true;
            this.cbMetodoPago.Location = new System.Drawing.Point(88, 232);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(147, 21);
            this.cbMetodoPago.TabIndex = 2;
            this.cbMetodoPago.Text = "Seleccione";
            // 
            // cmMetodo2
            // 
            this.cmMetodo2.FormattingEnabled = true;
            this.cmMetodo2.Location = new System.Drawing.Point(304, 232);
            this.cmMetodo2.Name = "cmMetodo2";
            this.cmMetodo2.Size = new System.Drawing.Size(147, 21);
            this.cmMetodo2.TabIndex = 2;
            this.cmMetodo2.Text = "Seleccione";
            // 
            // lblMetodo2
            // 
            this.lblMetodo2.AutoSize = true;
            this.lblMetodo2.Location = new System.Drawing.Point(301, 194);
            this.lblMetodo2.Name = "lblMetodo2";
            this.lblMetodo2.Size = new System.Drawing.Size(95, 13);
            this.lblMetodo2.TabIndex = 3;
            this.lblMetodo2.Text = "Metodo de Pago 2";
            // 
            // numMetodo1
            // 
            this.numMetodo1.Location = new System.Drawing.Point(88, 298);
            this.numMetodo1.Name = "numMetodo1";
            this.numMetodo1.Size = new System.Drawing.Size(147, 20);
            this.numMetodo1.TabIndex = 4;
            this.numMetodo1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(526, 194);
            this.numCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(147, 20);
            this.numCantidad.TabIndex = 4;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(523, 168);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // checkMetodo
            // 
            this.checkMetodo.AutoSize = true;
            this.checkMetodo.Location = new System.Drawing.Point(526, 235);
            this.checkMetodo.Name = "checkMetodo";
            this.checkMetodo.Size = new System.Drawing.Size(151, 17);
            this.checkMetodo.TabIndex = 5;
            this.checkMetodo.Text = "Segundo Metodo de Pago";
            this.checkMetodo.UseVisualStyleBackColor = true;
            this.checkMetodo.CheckedChanged += new System.EventHandler(this.checkMetodo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "$";
            // 
            // lblPorcentaje1
            // 
            this.lblPorcentaje1.AutoSize = true;
            this.lblPorcentaje1.Location = new System.Drawing.Point(85, 273);
            this.lblPorcentaje1.Name = "lblPorcentaje1";
            this.lblPorcentaje1.Size = new System.Drawing.Size(58, 13);
            this.lblPorcentaje1.TabIndex = 3;
            this.lblPorcentaje1.Text = "Porcentaje";
            // 
            // Vista_Asiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplicacionFinal.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 457);
            this.Controls.Add(this.checkMetodo);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.numMetodo1);
            this.Controls.Add(this.lblMetodo2);
            this.Controls.Add(this.lblMetodo1);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPorcentaje1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblTransaccion);
            this.Controls.Add(this.cbTransaccion);
            this.Controls.Add(this.cmMetodo2);
            this.Controls.Add(this.cbMetodoPago);
            this.Controls.Add(this.cbCuenta);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vista_Asiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Asiento";
            this.Load += new System.EventHandler(this.Vista_Cuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMetodo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cbCuenta;
        private System.Windows.Forms.Label lblTransaccion;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblMetodo1;
        private System.Windows.Forms.ComboBox cbTransaccion;
        private System.Windows.Forms.ComboBox cbMetodoPago;
        private System.Windows.Forms.ComboBox cmMetodo2;
        private System.Windows.Forms.Label lblMetodo2;
        private System.Windows.Forms.NumericUpDown numMetodo1;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.CheckBox checkMetodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPorcentaje1;
    }
}