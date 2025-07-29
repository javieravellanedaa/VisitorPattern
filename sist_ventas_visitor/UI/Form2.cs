using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class Form2 : Form
    {
        private readonly Catalogo _catalogo;
        private List<IVisitado> _estructura;

        public Form2()
        {
            InitializeComponent();
            _catalogo = new Catalogo();

            Load += Form2_Load;
            dgvProductos.SelectionChanged += DgvProductos_SelectionChanged;
            dgvPaquetes.SelectionChanged += DgvPaquetes_SelectionChanged;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadAdminData();
        }

        // --- Pestaña Catálogo ---

        private void btnCargar_Click(object sender, EventArgs e)
        {
            treeEstructura.Nodes.Clear();
            _estructura = _catalogo.ObtenerEstructura();
            foreach (var item in _estructura)
                AgregarNodo(item, treeEstructura.Nodes);
            treeEstructura.ExpandAll();
        }

        private void btnCalcularTotalVentas_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
            lstResultados.Items.Add($"Valor total catálogo: ${_catalogo.CalcularTotalVentas():0.00}");
        }

        private void btnCalcularImpuestos_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
            foreach (var linea in _catalogo.CalcularImpuestos(nudTasaImpuesto.Value))
                lstResultados.Items.Add(linea);
        }

        private void btnGenerarEtiquetas_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
            foreach (var etiqueta in _catalogo.GenerarEtiquetas())
                lstResultados.Items.Add(etiqueta);
        }

        private void AgregarNodo(IVisitado elemento, TreeNodeCollection nodos)
        {
            if (elemento is Producto prod)
            {
                nodos.Add($"{prod.Nombre} — ${prod.Precio:0.00}");
            }
            else if (elemento is PaquetePromocional pkg)
            {
                var node = nodos.Add($"Paquete \"{pkg.Nombre}\" ({pkg.Descuento:P})");
                foreach (var sub in pkg.Elementos)
                    AgregarNodo(sub, node.Nodes);
            }
        }


        private void LoadAdminData()
        {
            dgvProductos.DataSource = _catalogo.ObtenerProductos().ToList();
            dgvPaquetes.DataSource = _catalogo.ObtenerPaquetes().ToList();

            _estructura = _catalogo.ObtenerEstructura();
            clbPaqElementos.Items.Clear();
            clbPaqElementos.Items.AddRange(_estructura.ToArray());
        }

        private void DgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null) return;
            var prod = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            txtProdNombre.Text = prod.Nombre;
            nudProdPrecio.Value = prod.Precio;
        }

        private void DgvPaquetes_SelectionChanged(object sender, EventArgs e)
        {
           
            if (_estructura == null || dgvPaquetes.CurrentRow == null) return;

            var pkg = (PaquetePromocional)dgvPaquetes.CurrentRow.DataBoundItem;
            txtPaqNombre.Text = pkg.Nombre;
            nudPaqDescuento.Value = pkg.Descuento;

    
            for (int i = 0; i < clbPaqElementos.Items.Count; i++)
                clbPaqElementos.SetItemChecked(i, false);

       
            for (int i = 0; i < _estructura.Count; i++)
            {
                var elem = _estructura[i];
                bool isChecked = pkg.Elementos.Any(x =>
                    (x is Producto p && elem is Producto ep && p.Id == ep.Id) ||
                    (x is PaquetePromocional sp && elem is PaquetePromocional esp && sp.Id == esp.Id)
                );
                clbPaqElementos.SetItemChecked(i, isChecked);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            _catalogo.AgregarProducto(txtProdNombre.Text.Trim(), nudProdPrecio.Value);
            LoadAdminData();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null) return;
            var prod = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            prod.Nombre = txtProdNombre.Text.Trim();
            prod.Precio = nudProdPrecio.Value;
            _catalogo.ModificarProducto(prod);
            LoadAdminData();
        }

        private void btnAgregarPaquete_Click(object sender, EventArgs e)
        {
            var nombre = txtPaqNombre.Text.Trim();
            var descuento = nudPaqDescuento.Value;

            var elementos = clbPaqElementos.CheckedItems
                .Cast<IVisitado>()
                .Select(iv =>
                {
                    if (iv is Producto p) return ('P', p.Id);
                    if (iv is PaquetePromocional pp) return ('C', pp.Id);
                    throw new InvalidOperationException("Elemento no válido");
                })
                .ToList();

            _catalogo.AgregarPaquete(nombre, descuento, elementos);
            LoadAdminData();
        }

        private void btnModificarPaquete_Click(object sender, EventArgs e)
        {
            if (dgvPaquetes.CurrentRow == null) return;
            var pkg = (PaquetePromocional)dgvPaquetes.CurrentRow.DataBoundItem;

            pkg.Nombre = txtPaqNombre.Text.Trim();
            pkg.Descuento = nudPaqDescuento.Value;

            var elementos = clbPaqElementos.CheckedItems
                .Cast<IVisitado>()
                .Select(iv =>
                {
                    if (iv is Producto p) return ('P', p.Id);
                    if (iv is PaquetePromocional pp) return ('C', pp.Id);
                    throw new InvalidOperationException("Elemento no válido");
                })
                .ToList();

            _catalogo.ModificarPaquete(pkg, elementos);
            LoadAdminData();
        }
    }
}
