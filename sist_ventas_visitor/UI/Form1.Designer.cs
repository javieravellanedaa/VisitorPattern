namespace UI
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxVisitors = new System.Windows.Forms.GroupBox();
            this.labelPorcentaje = new System.Windows.Forms.Label();
            this.numericUpDownTasa = new System.Windows.Forms.NumericUpDown();
            this.labelTasaImpuesto = new System.Windows.Forms.Label();
            this.buttonGenerarEtiquetas = new System.Windows.Forms.Button();
            this.buttonCalcularImpuestos = new System.Windows.Forms.Button();
            this.buttonCalcularVentas = new System.Windows.Forms.Button();
            this.groupBoxResultados = new System.Windows.Forms.GroupBox();
            this.richTextBoxResultados = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiarResultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarSeleccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDetalles = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTotalVentas = new System.Windows.Forms.Label();
            this.groupBoxCatalogo = new System.Windows.Forms.GroupBox();
            this.buttonLimpiarResultados = new System.Windows.Forms.Button();
            this.buttonCargarCatalogo = new System.Windows.Forms.Button();
            this.listViewCatalogo = new System.Windows.Forms.ListView();
            this.columnHeaderTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescuento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadorVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicadorImpuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generadorEtiquetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxVisitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTasa)).BeginInit();
            this.groupBoxResultados.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxCatalogo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVisitors
            // 
            this.groupBoxVisitors.Controls.Add(this.labelPorcentaje);
            this.groupBoxVisitors.Controls.Add(this.numericUpDownTasa);
            this.groupBoxVisitors.Controls.Add(this.labelTasaImpuesto);
            this.groupBoxVisitors.Controls.Add(this.buttonGenerarEtiquetas);
            this.groupBoxVisitors.Controls.Add(this.buttonCalcularImpuestos);
            this.groupBoxVisitors.Controls.Add(this.buttonCalcularVentas);
            this.groupBoxVisitors.Location = new System.Drawing.Point(16, 46);
            this.groupBoxVisitors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxVisitors.Name = "groupBoxVisitors";
            this.groupBoxVisitors.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxVisitors.Size = new System.Drawing.Size(1035, 98);
            this.groupBoxVisitors.TabIndex = 0;
            this.groupBoxVisitors.TabStop = false;
            this.groupBoxVisitors.Text = "Patrones Visitor - Operaciones sobre el Catálogo";
            // 
            // labelPorcentaje
            // 
            this.labelPorcentaje.AutoSize = true;
            this.labelPorcentaje.Location = new System.Drawing.Point(588, 43);
            this.labelPorcentaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPorcentaje.Name = "labelPorcentaje";
            this.labelPorcentaje.Size = new System.Drawing.Size(19, 16);
            this.labelPorcentaje.TabIndex = 5;
            this.labelPorcentaje.Text = "%";
            // 
            // numericUpDownTasa
            // 
            this.numericUpDownTasa.DecimalPlaces = 2;
            this.numericUpDownTasa.Location = new System.Drawing.Point(500, 41);
            this.numericUpDownTasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownTasa.Name = "numericUpDownTasa";
            this.numericUpDownTasa.Size = new System.Drawing.Size(80, 22);
            this.numericUpDownTasa.TabIndex = 4;
            this.numericUpDownTasa.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // labelTasaImpuesto
            // 
            this.labelTasaImpuesto.AutoSize = true;
            this.labelTasaImpuesto.Location = new System.Drawing.Point(380, 43);
            this.labelTasaImpuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTasaImpuesto.Name = "labelTasaImpuesto";
            this.labelTasaImpuesto.Size = new System.Drawing.Size(100, 16);
            this.labelTasaImpuesto.TabIndex = 3;
            this.labelTasaImpuesto.Text = "Tasa Impuesto:";
            // 
            // buttonGenerarEtiquetas
            // 
            this.buttonGenerarEtiquetas.Location = new System.Drawing.Point(633, 31);
            this.buttonGenerarEtiquetas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGenerarEtiquetas.Name = "buttonGenerarEtiquetas";
            this.buttonGenerarEtiquetas.Size = new System.Drawing.Size(160, 55);
            this.buttonGenerarEtiquetas.TabIndex = 2;
            this.buttonGenerarEtiquetas.Text = "Generar Etiquetas\r\n(GeneradorEtiquetasVisitor)";
            this.buttonGenerarEtiquetas.UseVisualStyleBackColor = true;
            this.buttonGenerarEtiquetas.Click += new System.EventHandler(this.buttonGenerarEtiquetas_Click);
            // 
            // buttonCalcularImpuestos
            // 
            this.buttonCalcularImpuestos.Location = new System.Drawing.Point(200, 31);
            this.buttonCalcularImpuestos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCalcularImpuestos.Name = "buttonCalcularImpuestos";
            this.buttonCalcularImpuestos.Size = new System.Drawing.Size(160, 55);
            this.buttonCalcularImpuestos.TabIndex = 1;
            this.buttonCalcularImpuestos.Text = "Aplicar Impuestos\r\n(AplicadorImpuestosVisitor)";
            this.buttonCalcularImpuestos.UseVisualStyleBackColor = true;
            this.buttonCalcularImpuestos.Click += new System.EventHandler(this.buttonCalcularImpuestos_Click);
            // 
            // buttonCalcularVentas
            // 
            this.buttonCalcularVentas.Location = new System.Drawing.Point(20, 31);
            this.buttonCalcularVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCalcularVentas.Name = "buttonCalcularVentas";
            this.buttonCalcularVentas.Size = new System.Drawing.Size(160, 55);
            this.buttonCalcularVentas.TabIndex = 0;
            this.buttonCalcularVentas.Text = "Calcular Ventas\r\n(CalculadorVentasVisitor)";
            this.buttonCalcularVentas.UseVisualStyleBackColor = true;
            this.buttonCalcularVentas.Click += new System.EventHandler(this.buttonCalcularVentas_Click);
            // 
            // groupBoxResultados
            // 
            this.groupBoxResultados.Controls.Add(this.richTextBoxResultados);
            this.groupBoxResultados.Controls.Add(this.labelDetalles);
            this.groupBoxResultados.Controls.Add(this.textBoxTotal);
            this.groupBoxResultados.Controls.Add(this.labelTotalVentas);
            this.groupBoxResultados.Location = new System.Drawing.Point(533, 160);
            this.groupBoxResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxResultados.Name = "groupBoxResultados";
            this.groupBoxResultados.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxResultados.Size = new System.Drawing.Size(517, 357);
            this.groupBoxResultados.TabIndex = 1;
            this.groupBoxResultados.TabStop = false;
            this.groupBoxResultados.Text = "Resultados de Visitors";
            // 
            // richTextBoxResultados
            // 
            this.richTextBoxResultados.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBoxResultados.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxResultados.Location = new System.Drawing.Point(20, 92);
            this.richTextBoxResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxResultados.Name = "richTextBoxResultados";
            this.richTextBoxResultados.ReadOnly = true;
            this.richTextBoxResultados.Size = new System.Drawing.Size(479, 245);
            this.richTextBoxResultados.TabIndex = 3;
            this.richTextBoxResultados.Text = "Seleccione una operación Visitor para ver los resultados...";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarResultadosToolStripMenuItem,
            this.limpiarSeleccionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 52);
            // 
            // copiarResultadosToolStripMenuItem
            // 
            this.copiarResultadosToolStripMenuItem.Name = "copiarResultadosToolStripMenuItem";
            this.copiarResultadosToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.copiarResultadosToolStripMenuItem.Text = "&Copiar resultados";
            this.copiarResultadosToolStripMenuItem.Click += new System.EventHandler(this.copiarResultadosToolStripMenuItem_Click);
            // 
            // limpiarSeleccionToolStripMenuItem
            // 
            this.limpiarSeleccionToolStripMenuItem.Name = "limpiarSeleccionToolStripMenuItem";
            this.limpiarSeleccionToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.limpiarSeleccionToolStripMenuItem.Text = "&Limpiar selección";
            this.limpiarSeleccionToolStripMenuItem.Click += new System.EventHandler(this.limpiarSeleccionToolStripMenuItem_Click);
            // 
            // labelDetalles
            // 
            this.labelDetalles.AutoSize = true;
            this.labelDetalles.Location = new System.Drawing.Point(20, 68);
            this.labelDetalles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDetalles.Name = "labelDetalles";
            this.labelDetalles.Size = new System.Drawing.Size(122, 16);
            this.labelDetalles.TabIndex = 2;
            this.labelDetalles.Text = "Detalles del Visitor:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBoxTotal.Location = new System.Drawing.Point(160, 27);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(159, 26);
            this.textBoxTotal.TabIndex = 1;
            this.textBoxTotal.Text = "$0.00";
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTotalVentas
            // 
            this.labelTotalVentas.AutoSize = true;
            this.labelTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalVentas.Location = new System.Drawing.Point(20, 31);
            this.labelTotalVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalVentas.Name = "labelTotalVentas";
            this.labelTotalVentas.Size = new System.Drawing.Size(128, 17);
            this.labelTotalVentas.TabIndex = 0;
            this.labelTotalVentas.Text = "Total de Ventas:";
            // 
            // groupBoxCatalogo
            // 
            this.groupBoxCatalogo.Controls.Add(this.buttonLimpiarResultados);
            this.groupBoxCatalogo.Controls.Add(this.buttonCargarCatalogo);
            this.groupBoxCatalogo.Controls.Add(this.listViewCatalogo);
            this.groupBoxCatalogo.Location = new System.Drawing.Point(16, 160);
            this.groupBoxCatalogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCatalogo.Name = "groupBoxCatalogo";
            this.groupBoxCatalogo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCatalogo.Size = new System.Drawing.Size(500, 357);
            this.groupBoxCatalogo.TabIndex = 2;
            this.groupBoxCatalogo.TabStop = false;
            this.groupBoxCatalogo.Text = "Estructura del Catálogo (IVisitado)";
            // 
            // buttonLimpiarResultados
            // 
            this.buttonLimpiarResultados.Location = new System.Drawing.Point(173, 295);
            this.buttonLimpiarResultados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLimpiarResultados.Name = "buttonLimpiarResultados";
            this.buttonLimpiarResultados.Size = new System.Drawing.Size(133, 43);
            this.buttonLimpiarResultados.TabIndex = 2;
            this.buttonLimpiarResultados.Text = "Limpiar Todo";
            this.buttonLimpiarResultados.UseVisualStyleBackColor = true;
            this.buttonLimpiarResultados.Click += new System.EventHandler(this.buttonLimpiarResultados_Click);
            // 
            // buttonCargarCatalogo
            // 
            this.buttonCargarCatalogo.Location = new System.Drawing.Point(20, 295);
            this.buttonCargarCatalogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCargarCatalogo.Name = "buttonCargarCatalogo";
            this.buttonCargarCatalogo.Size = new System.Drawing.Size(133, 43);
            this.buttonCargarCatalogo.TabIndex = 1;
            this.buttonCargarCatalogo.Text = "Cargar desde BD";
            this.buttonCargarCatalogo.UseVisualStyleBackColor = true;
            this.buttonCargarCatalogo.Click += new System.EventHandler(this.buttonCargarCatalogo_Click);
            // 
            // listViewCatalogo
            // 
            this.listViewCatalogo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTipo,
            this.columnHeaderNombre,
            this.columnHeaderPrecio,
            this.columnHeaderDescuento});
            this.listViewCatalogo.FullRowSelect = true;
            this.listViewCatalogo.GridLines = true;
            this.listViewCatalogo.HideSelection = false;
            this.listViewCatalogo.Location = new System.Drawing.Point(20, 31);
            this.listViewCatalogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewCatalogo.Name = "listViewCatalogo";
            this.listViewCatalogo.Size = new System.Drawing.Size(459, 245);
            this.listViewCatalogo.TabIndex = 0;
            this.listViewCatalogo.UseCompatibleStateImageBehavior = false;
            this.listViewCatalogo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTipo
            // 
            this.columnHeaderTipo.Text = "Tipo";
            this.columnHeaderTipo.Width = 80;
            // 
            // columnHeaderNombre
            // 
            this.columnHeaderNombre.Text = "Nombre";
            this.columnHeaderNombre.Width = 150;
            // 
            // columnHeaderPrecio
            // 
            this.columnHeaderPrecio.Text = "Precio";
            this.columnHeaderPrecio.Width = 70;
            // 
            // columnHeaderDescuento
            // 
            this.columnHeaderDescuento.Text = "Descuento";
            this.columnHeaderDescuento.Width = 70;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel1.Text = "Listo...";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(133, 18);
            this.toolStripProgressBar1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.visitorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // visitorsToolStripMenuItem
            // 
            this.visitorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadorVentasToolStripMenuItem,
            this.aplicadorImpuestosToolStripMenuItem,
            this.generadorEtiquetasToolStripMenuItem});
            this.visitorsToolStripMenuItem.Name = "visitorsToolStripMenuItem";
            this.visitorsToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.visitorsToolStripMenuItem.Text = "&Visitors";
            // 
            // calculadorVentasToolStripMenuItem
            // 
            this.calculadorVentasToolStripMenuItem.Name = "calculadorVentasToolStripMenuItem";
            this.calculadorVentasToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.calculadorVentasToolStripMenuItem.Text = "&Calculador de Ventas";
            this.calculadorVentasToolStripMenuItem.Click += new System.EventHandler(this.calculadorVentasToolStripMenuItem_Click);
            // 
            // aplicadorImpuestosToolStripMenuItem
            // 
            this.aplicadorImpuestosToolStripMenuItem.Name = "aplicadorImpuestosToolStripMenuItem";
            this.aplicadorImpuestosToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.aplicadorImpuestosToolStripMenuItem.Text = "&Aplicador Impuestos";
            this.aplicadorImpuestosToolStripMenuItem.Click += new System.EventHandler(this.aplicadorImpuestosToolStripMenuItem_Click);
            // 
            // generadorEtiquetasToolStripMenuItem
            // 
            this.generadorEtiquetasToolStripMenuItem.Name = "generadorEtiquetasToolStripMenuItem";
            this.generadorEtiquetasToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.generadorEtiquetasToolStripMenuItem.Text = "&Generador Etiquetas";
            this.generadorEtiquetasToolStripMenuItem.Click += new System.EventHandler(this.generadorEtiquetasToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxCatalogo);
            this.Controls.Add(this.groupBoxResultados);
            this.Controls.Add(this.groupBoxVisitors);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Catálogo - Patrón Visitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxVisitors.ResumeLayout(false);
            this.groupBoxVisitors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTasa)).EndInit();
            this.groupBoxResultados.ResumeLayout(false);
            this.groupBoxResultados.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxCatalogo.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVisitors;
        private System.Windows.Forms.Label labelPorcentaje;
        private System.Windows.Forms.NumericUpDown numericUpDownTasa;
        private System.Windows.Forms.Label labelTasaImpuesto;
        private System.Windows.Forms.Button buttonGenerarEtiquetas;
        private System.Windows.Forms.Button buttonCalcularImpuestos;
        private System.Windows.Forms.Button buttonCalcularVentas;
        private System.Windows.Forms.GroupBox groupBoxResultados;
        private System.Windows.Forms.RichTextBox richTextBoxResultados;
        private System.Windows.Forms.Label labelDetalles;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotalVentas;
        private System.Windows.Forms.GroupBox groupBoxCatalogo;
        private System.Windows.Forms.Button buttonLimpiarResultados;
        private System.Windows.Forms.Button buttonCargarCatalogo;
        private System.Windows.Forms.ListView listViewCatalogo;
        private System.Windows.Forms.ColumnHeader columnHeaderTipo;
        private System.Windows.Forms.ColumnHeader columnHeaderNombre;
        private System.Windows.Forms.ColumnHeader columnHeaderPrecio;
        private System.Windows.Forms.ColumnHeader columnHeaderDescuento;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadorVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicadorImpuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generadorEtiquetasToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copiarResultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarSeleccionToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}