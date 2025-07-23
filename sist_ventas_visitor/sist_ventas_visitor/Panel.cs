using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DAL;                    // para Acceso
using BE;
using BLL;// Catalogo

namespace sist_ventas_visitor
{
    public partial class Panel : Form
    {
        // Controles de UI
        private TreeView treeViewCatalogo;
        private ComboBox comboOperacion;
        private Label lblTasaImpuesto;
        private TextBox txtTasaImpuesto;
        private Button btnEjecutar;
        private TextBox txtResultados;

        // Acceso a datos y servicio de negocio
        private Acceso _acceso;
        private ProductoDAL _productoDal;
        private PaquetePromocionalDAL _paqueteDal;
        private Catalogo _catalogoService;

        public Panel()
        {
            InitializeComponent();
            InitializeDataAccess();
            InitializeService();
            BuildUI();
            LoadCatalogTree();
            InitializeOperations();
        }

        private void InitializeDataAccess()
        {
            _acceso = new Acceso();
            _productoDal = new ProductoDAL(_acceso);
            _paqueteDal = new PaquetePromocionalDAL(_acceso);
        }

        private void InitializeService()
        {
            _catalogoService = new Catalogo();
        }

        private void BuildUI()
        {
            // Explorador: TreeView
            treeViewCatalogo = new TreeView
            {
                Dock = DockStyle.Fill
            };
            tabExplorador.Controls.Add(treeViewCatalogo);

            // Operación: ComboBox, Label, TextBox y Button
            comboOperacion = new ComboBox
            {
                Location = new Point(10, 10),
                Width = 200,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            tabOperacion.Controls.Add(comboOperacion);

            lblTasaImpuesto = new Label
            {
                Text = "Tasa Impuesto:",
                Location = new Point(10, 50),
                AutoSize = true
            };
            tabOperacion.Controls.Add(lblTasaImpuesto);

            txtTasaImpuesto = new TextBox
            {
                Location = new Point(110, 47),
                Width = 100,
                Text = "0.21"
            };
            tabOperacion.Controls.Add(txtTasaImpuesto);

            btnEjecutar = new Button
            {
                Text = "Ejecutar",
                Location = new Point(10, 85),
                AutoSize = true
            };
            btnEjecutar.Click += BtnEjecutar_Click;
            tabOperacion.Controls.Add(btnEjecutar);

            // Resultados: TextBox multiline
            txtResultados = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Both,
                Dock = DockStyle.Fill
            };
            tabResultados.Controls.Add(txtResultados);
        }

        private void LoadCatalogTree()
        {
            treeViewCatalogo.BeginUpdate();
            treeViewCatalogo.Nodes.Clear();

            _acceso.Open();
            var productos = _productoDal.ObtenerTodos();
            var paquetes = _paqueteDal.ObtenerTodos();
            _acceso.Close();

            // Agregar productos como nodos
            foreach (var prod in productos)
            {
                var node = new TreeNode(prod.Nombre) { Tag = prod };
                treeViewCatalogo.Nodes.Add(node);
            }

            // Agregar paquetes recursivamente
            foreach (var paquete in paquetes)
            {
                treeViewCatalogo.Nodes.Add(CreatePackageNode(paquete));
            }

            treeViewCatalogo.EndUpdate();
        }

        private TreeNode CreatePackageNode(PaquetePromocional paquete)
        {
            var node = new TreeNode(paquete.Nombre) { Tag = paquete };
            foreach (var el in paquete.Elementos)
            {
                if (el is Producto prod)
                    node.Nodes.Add(new TreeNode(prod.Nombre) { Tag = prod });
                else if (el is PaquetePromocional sub)
                    node.Nodes.Add(CreatePackageNode(sub));
            }
            return node;
        }

        private void InitializeOperations()
        {
            comboOperacion.Items.AddRange(new[]
            {
                "Calcular Total Ventas",
                "Calcular Impuestos",
                "Generar Etiquetas"
            });
            comboOperacion.SelectedIndex = 0;
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            txtResultados.Clear();
            switch (comboOperacion.SelectedIndex)
            {
                case 0: // Total Ventas
                    var total = _catalogoService.CalcularTotalVentas();
                    txtResultados.Text = $"Total Ventas: {total:0.00}";
                    break;

                case 1: // Impuestos
                    if (!decimal.TryParse(txtTasaImpuesto.Text, out var tasa))
                        tasa = 0m;
                    var lineas = _catalogoService.CalcularImpuestos(tasa);
                    txtResultados.Lines = new List<string>(lineas).ToArray();
                    break;

                case 2: // Etiquetas
                    var etiquetas = _catalogoService.GenerarEtiquetas();
                    txtResultados.Lines = new List<string>(etiquetas).ToArray();
                    break;
            }
        }
    }
}
