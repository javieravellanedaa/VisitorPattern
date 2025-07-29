// UI/Form2.Designer.cs
namespace UI
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageVisor;
        private System.Windows.Forms.TabPage tabPageAdmin;

        // Visor controls
        private System.Windows.Forms.Label lblEstructura;
        private System.Windows.Forms.TreeView treeEstructura;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnCalcularTotalVentas;
        private System.Windows.Forms.Label lblTasaImpuesto;
        private System.Windows.Forms.NumericUpDown nudTasaImpuesto;
        private System.Windows.Forms.Button btnCalcularImpuestos;
        private System.Windows.Forms.Button btnGenerarEtiquetas;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.ListBox lstResultados;

        // Admin controls
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.Label lblProdNombre;
        private System.Windows.Forms.TextBox txtProdNombre;
        private System.Windows.Forms.Label lblProdPrecio;
        private System.Windows.Forms.NumericUpDown nudProdPrecio;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;

        private System.Windows.Forms.GroupBox grpPaquete;
        private System.Windows.Forms.Label lblPaqNombre;
        private System.Windows.Forms.TextBox txtPaqNombre;
        private System.Windows.Forms.Label lblPaqDescuento;
        private System.Windows.Forms.NumericUpDown nudPaqDescuento;
        private System.Windows.Forms.CheckedListBox clbPaqElementos;
        private System.Windows.Forms.Button btnAgregarPaquete;
        private System.Windows.Forms.Button btnModificarPaquete;
        private System.Windows.Forms.DataGridView dgvPaquetes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageVisor = new System.Windows.Forms.TabPage();
            this.lblEstructura = new System.Windows.Forms.Label();
            this.treeEstructura = new System.Windows.Forms.TreeView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCalcularTotalVentas = new System.Windows.Forms.Button();
            this.lblTasaImpuesto = new System.Windows.Forms.Label();
            this.nudTasaImpuesto = new System.Windows.Forms.NumericUpDown();
            this.btnCalcularImpuestos = new System.Windows.Forms.Button();
            this.btnGenerarEtiquetas = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.lblProdNombre = new System.Windows.Forms.Label();
            this.txtProdNombre = new System.Windows.Forms.TextBox();
            this.lblProdPrecio = new System.Windows.Forms.Label();
            this.nudProdPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.grpPaquete = new System.Windows.Forms.GroupBox();
            this.lblPaqNombre = new System.Windows.Forms.Label();
            this.txtPaqNombre = new System.Windows.Forms.TextBox();
            this.lblPaqDescuento = new System.Windows.Forms.Label();
            this.nudPaqDescuento = new System.Windows.Forms.NumericUpDown();
            this.clbPaqElementos = new System.Windows.Forms.CheckedListBox();
            this.btnAgregarPaquete = new System.Windows.Forms.Button();
            this.btnModificarPaquete = new System.Windows.Forms.Button();
            this.dgvPaquetes = new System.Windows.Forms.DataGridView();
            this.tabControlMain.SuspendLayout();
            this.tabPageVisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTasaImpuesto)).BeginInit();
            this.tabPageAdmin.SuspendLayout();
            this.grpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grpPaquete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaqDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageVisor);
            this.tabControlMain.Controls.Add(this.tabPageAdmin);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(820, 480);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageVisor
            // 
            this.tabPageVisor.Controls.Add(this.lblEstructura);
            this.tabPageVisor.Controls.Add(this.treeEstructura);
            this.tabPageVisor.Controls.Add(this.btnCargar);
            this.tabPageVisor.Controls.Add(this.btnCalcularTotalVentas);
            this.tabPageVisor.Controls.Add(this.lblTasaImpuesto);
            this.tabPageVisor.Controls.Add(this.nudTasaImpuesto);
            this.tabPageVisor.Controls.Add(this.btnCalcularImpuestos);
            this.tabPageVisor.Controls.Add(this.btnGenerarEtiquetas);
            this.tabPageVisor.Controls.Add(this.lblResultados);
            this.tabPageVisor.Controls.Add(this.lstResultados);
            this.tabPageVisor.Location = new System.Drawing.Point(4, 25);
            this.tabPageVisor.Name = "tabPageVisor";
            this.tabPageVisor.Size = new System.Drawing.Size(812, 451);
            this.tabPageVisor.TabIndex = 0;
            this.tabPageVisor.Text = "Catálogo";
            this.tabPageVisor.UseVisualStyleBackColor = true;
            // 
            // lblEstructura
            // 
            this.lblEstructura.AutoSize = true;
            this.lblEstructura.Location = new System.Drawing.Point(10, 10);
            this.lblEstructura.Name = "lblEstructura";
            this.lblEstructura.Size = new System.Drawing.Size(69, 16);
            this.lblEstructura.TabIndex = 0;
            this.lblEstructura.Text = "Estructura:";
            // 
            // treeEstructura
            // 
            this.treeEstructura.Location = new System.Drawing.Point(10, 30);
            this.treeEstructura.Name = "treeEstructura";
            this.treeEstructura.Size = new System.Drawing.Size(300, 350);
            this.treeEstructura.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(330, 30);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(150, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar catálogo";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnCalcularTotalVentas
            // 
            this.btnCalcularTotalVentas.Location = new System.Drawing.Point(330, 65);
            this.btnCalcularTotalVentas.Name = "btnCalcularTotalVentas";
            this.btnCalcularTotalVentas.Size = new System.Drawing.Size(150, 23);
            this.btnCalcularTotalVentas.TabIndex = 3;
            this.btnCalcularTotalVentas.Text = "Valor total catálogo";
            this.btnCalcularTotalVentas.UseVisualStyleBackColor = true;
            this.btnCalcularTotalVentas.Click += new System.EventHandler(this.btnCalcularTotalVentas_Click);
            // 
            // lblTasaImpuesto
            // 
            this.lblTasaImpuesto.AutoSize = true;
            this.lblTasaImpuesto.Location = new System.Drawing.Point(330, 105);
            this.lblTasaImpuesto.Name = "lblTasaImpuesto";
            this.lblTasaImpuesto.Size = new System.Drawing.Size(100, 16);
            this.lblTasaImpuesto.TabIndex = 4;
            this.lblTasaImpuesto.Text = "Tasa impuesto:";
            // 
            // nudTasaImpuesto
            // 
            this.nudTasaImpuesto.DecimalPlaces = 2;
            this.nudTasaImpuesto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudTasaImpuesto.Location = new System.Drawing.Point(420, 103);
            this.nudTasaImpuesto.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTasaImpuesto.Name = "nudTasaImpuesto";
            this.nudTasaImpuesto.Size = new System.Drawing.Size(60, 22);
            this.nudTasaImpuesto.TabIndex = 5;
            this.nudTasaImpuesto.Value = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            // 
            // btnCalcularImpuestos
            // 
            this.btnCalcularImpuestos.Location = new System.Drawing.Point(330, 140);
            this.btnCalcularImpuestos.Name = "btnCalcularImpuestos";
            this.btnCalcularImpuestos.Size = new System.Drawing.Size(150, 23);
            this.btnCalcularImpuestos.TabIndex = 6;
            this.btnCalcularImpuestos.Text = "Calcular impuestos";
            this.btnCalcularImpuestos.UseVisualStyleBackColor = true;
            this.btnCalcularImpuestos.Click += new System.EventHandler(this.btnCalcularImpuestos_Click);
            // 
            // btnGenerarEtiquetas
            // 
            this.btnGenerarEtiquetas.Location = new System.Drawing.Point(330, 175);
            this.btnGenerarEtiquetas.Name = "btnGenerarEtiquetas";
            this.btnGenerarEtiquetas.Size = new System.Drawing.Size(150, 23);
            this.btnGenerarEtiquetas.TabIndex = 7;
            this.btnGenerarEtiquetas.Text = "Generar etiquetas";
            this.btnGenerarEtiquetas.UseVisualStyleBackColor = true;
            this.btnGenerarEtiquetas.Click += new System.EventHandler(this.btnGenerarEtiquetas_Click);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(330, 210);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(79, 16);
            this.lblResultados.TabIndex = 8;
            this.lblResultados.Text = "Resultados:";
            // 
            // lstResultados
            // 
            this.lstResultados.ItemHeight = 16;
            this.lstResultados.Location = new System.Drawing.Point(330, 230);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(460, 148);
            this.lstResultados.TabIndex = 9;
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.grpProducto);
            this.tabPageAdmin.Controls.Add(this.dgvProductos);
            this.tabPageAdmin.Controls.Add(this.grpPaquete);
            this.tabPageAdmin.Controls.Add(this.dgvPaquetes);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 25);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Size = new System.Drawing.Size(812, 451);
            this.tabPageAdmin.TabIndex = 1;
            this.tabPageAdmin.Text = "Administración";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // grpProducto
            // 
            this.grpProducto.Controls.Add(this.lblProdNombre);
            this.grpProducto.Controls.Add(this.txtProdNombre);
            this.grpProducto.Controls.Add(this.lblProdPrecio);
            this.grpProducto.Controls.Add(this.nudProdPrecio);
            this.grpProducto.Controls.Add(this.btnAgregarProducto);
            this.grpProducto.Controls.Add(this.btnModificarProducto);
            this.grpProducto.Location = new System.Drawing.Point(10, 10);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(380, 150);
            this.grpProducto.TabIndex = 0;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Productos";
            // 
            // lblProdNombre
            // 
            this.lblProdNombre.AutoSize = true;
            this.lblProdNombre.Location = new System.Drawing.Point(10, 25);
            this.lblProdNombre.Name = "lblProdNombre";
            this.lblProdNombre.Size = new System.Drawing.Size(59, 16);
            this.lblProdNombre.TabIndex = 0;
            this.lblProdNombre.Text = "Nombre:";
            // 
            // txtProdNombre
            // 
            this.txtProdNombre.Location = new System.Drawing.Point(70, 22);
            this.txtProdNombre.Name = "txtProdNombre";
            this.txtProdNombre.Size = new System.Drawing.Size(290, 22);
            this.txtProdNombre.TabIndex = 1;
            // 
            // lblProdPrecio
            // 
            this.lblProdPrecio.AutoSize = true;
            this.lblProdPrecio.Location = new System.Drawing.Point(10, 60);
            this.lblProdPrecio.Name = "lblProdPrecio";
            this.lblProdPrecio.Size = new System.Drawing.Size(49, 16);
            this.lblProdPrecio.TabIndex = 2;
            this.lblProdPrecio.Text = "Precio:";
            // 
            // nudProdPrecio
            // 
            this.nudProdPrecio.DecimalPlaces = 2;
            this.nudProdPrecio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudProdPrecio.Location = new System.Drawing.Point(70, 58);
            this.nudProdPrecio.Name = "nudProdPrecio";
            this.nudProdPrecio.Size = new System.Drawing.Size(80, 22);
            this.nudProdPrecio.TabIndex = 3;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(10, 95);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(90, 23);
            this.btnAgregarProducto.TabIndex = 4;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(110, 95);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(90, 23);
            this.btnModificarProducto.TabIndex = 5;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeight = 29;
            this.dgvProductos.Location = new System.Drawing.Point(10, 170);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(380, 200);
            this.dgvProductos.TabIndex = 1;
            // 
            // grpPaquete
            // 
            this.grpPaquete.Controls.Add(this.lblPaqNombre);
            this.grpPaquete.Controls.Add(this.txtPaqNombre);
            this.grpPaquete.Controls.Add(this.lblPaqDescuento);
            this.grpPaquete.Controls.Add(this.nudPaqDescuento);
            this.grpPaquete.Controls.Add(this.clbPaqElementos);
            this.grpPaquete.Controls.Add(this.btnAgregarPaquete);
            this.grpPaquete.Controls.Add(this.btnModificarPaquete);
            this.grpPaquete.Location = new System.Drawing.Point(410, 10);
            this.grpPaquete.Name = "grpPaquete";
            this.grpPaquete.Size = new System.Drawing.Size(380, 224);
            this.grpPaquete.TabIndex = 2;
            this.grpPaquete.TabStop = false;
            this.grpPaquete.Text = "Paquetes";
            // 
            // lblPaqNombre
            // 
            this.lblPaqNombre.AutoSize = true;
            this.lblPaqNombre.Location = new System.Drawing.Point(10, 25);
            this.lblPaqNombre.Name = "lblPaqNombre";
            this.lblPaqNombre.Size = new System.Drawing.Size(59, 16);
            this.lblPaqNombre.TabIndex = 0;
            this.lblPaqNombre.Text = "Nombre:";
            // 
            // txtPaqNombre
            // 
            this.txtPaqNombre.Location = new System.Drawing.Point(70, 22);
            this.txtPaqNombre.Name = "txtPaqNombre";
            this.txtPaqNombre.Size = new System.Drawing.Size(290, 22);
            this.txtPaqNombre.TabIndex = 1;
            // 
            // lblPaqDescuento
            // 
            this.lblPaqDescuento.AutoSize = true;
            this.lblPaqDescuento.Location = new System.Drawing.Point(10, 60);
            this.lblPaqDescuento.Name = "lblPaqDescuento";
            this.lblPaqDescuento.Size = new System.Drawing.Size(75, 16);
            this.lblPaqDescuento.TabIndex = 2;
            this.lblPaqDescuento.Text = "Descuento:";
            // 
            // nudPaqDescuento
            // 
            this.nudPaqDescuento.DecimalPlaces = 2;
            this.nudPaqDescuento.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPaqDescuento.Location = new System.Drawing.Point(70, 58);
            this.nudPaqDescuento.Name = "nudPaqDescuento";
            this.nudPaqDescuento.Size = new System.Drawing.Size(80, 22);
            this.nudPaqDescuento.TabIndex = 3;
            // 
            // clbPaqElementos
            // 
            this.clbPaqElementos.CheckOnClick = true;
            this.clbPaqElementos.Location = new System.Drawing.Point(10, 95);
            this.clbPaqElementos.Name = "clbPaqElementos";
            this.clbPaqElementos.Size = new System.Drawing.Size(350, 72);
            this.clbPaqElementos.TabIndex = 4;
            // 
            // btnAgregarPaquete
            // 
            this.btnAgregarPaquete.Location = new System.Drawing.Point(10, 185);
            this.btnAgregarPaquete.Name = "btnAgregarPaquete";
            this.btnAgregarPaquete.Size = new System.Drawing.Size(90, 23);
            this.btnAgregarPaquete.TabIndex = 5;
            this.btnAgregarPaquete.Text = "Agregar";
            this.btnAgregarPaquete.UseVisualStyleBackColor = true;
            this.btnAgregarPaquete.Click += new System.EventHandler(this.btnAgregarPaquete_Click);
            // 
            // btnModificarPaquete
            // 
            this.btnModificarPaquete.Location = new System.Drawing.Point(110, 185);
            this.btnModificarPaquete.Name = "btnModificarPaquete";
            this.btnModificarPaquete.Size = new System.Drawing.Size(90, 23);
            this.btnModificarPaquete.TabIndex = 6;
            this.btnModificarPaquete.Text = "Modificar";
            this.btnModificarPaquete.UseVisualStyleBackColor = true;
            this.btnModificarPaquete.Click += new System.EventHandler(this.btnModificarPaquete_Click);
            // 
            // dgvPaquetes
            // 
            this.dgvPaquetes.ColumnHeadersHeight = 29;
            this.dgvPaquetes.Location = new System.Drawing.Point(410, 277);
            this.dgvPaquetes.Name = "dgvPaquetes";
            this.dgvPaquetes.ReadOnly = true;
            this.dgvPaquetes.RowHeadersWidth = 51;
            this.dgvPaquetes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaquetes.Size = new System.Drawing.Size(380, 150);
            this.dgvPaquetes.TabIndex = 3;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(820, 480);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form2";
            this.Text = "Visitor Pattern Demo";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageVisor.ResumeLayout(false);
            this.tabPageVisor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTasaImpuesto)).EndInit();
            this.tabPageAdmin.ResumeLayout(false);
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProdPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grpPaquete.ResumeLayout(false);
            this.grpPaquete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaqDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
