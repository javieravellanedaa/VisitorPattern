using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BE;
using BLL;

namespace UI
{
    public partial class Form1 : Form
    {
        private Catalogo catalogo;
        private List<IVisitado> estructuraCatalogo;

        public Form1()
        {
            InitializeComponent();
            catalogo = new Catalogo();
            estructuraCatalogo = new List<IVisitado>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarEstado("Sistema iniciado - Patrón Visitor implementado");
        
        }

      

        private void buttonCargarCatalogo_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarEstado("Cargando catálogo desde base de datos...");
                MostrarProgreso(true);


                timer1.Start();

                CargarCatalogoDesdeDB();

                ActualizarEstado($"Catálogo cargado: {listViewCatalogo.Items.Count} elementos");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar catálogo: {ex.Message}\n\nDetalles: {ex.ToString()}",
                              "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActualizarEstado("Error al cargar catálogo");
            }
            finally
            {
                MostrarProgreso(false);
            }
        }

        private void CargarCatalogoDesdeDB()
        {
            listViewCatalogo.Items.Clear();
            estructuraCatalogo.Clear();

            try
            {
                
                estructuraCatalogo = CargarEstructuraCompleta();

                foreach (var elemento in estructuraCatalogo)
                {
                    if (elemento is Producto producto)
                    {
                        var item = new ListViewItem("Producto");
                        item.SubItems.Add(producto.Nombre);
                        item.SubItems.Add($"${producto.Precio:N2}");
                        item.SubItems.Add("-");
                        item.Tag = producto;
                        listViewCatalogo.Items.Add(item);
                    }
                    else if (elemento is PaquetePromocional paquete)
                    {
                        var item = new ListViewItem("Paquete");
                        item.SubItems.Add(paquete.Nombre);
                        item.SubItems.Add("-");
                        item.SubItems.Add($"{paquete.Descuento:P}");
                        item.Tag = paquete;
                        listViewCatalogo.Items.Add(item);

                        AgregarElementosPaquete(paquete, 1);
                    }
                }
            }
            catch (Exception ex)
            {
          
                MessageBox.Show("No se pudo conectar a la BD. Cargando datos de prueba...",
                              "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             
            }
        }

        private List<IVisitado> CargarEstructuraCompleta()
        {
            return catalogo.ObtenerEstructura();
        }


      

        private void AgregarElementosPaquete(PaquetePromocional paquete, int nivel)
        {
            string indentacion = new string(' ', nivel * 4);

            foreach (var elemento in paquete.Elementos)
            {
                if (elemento is Producto prod)
                {
                    var item = new ListViewItem($"{indentacion}├─ Producto");
                    item.SubItems.Add(prod.Nombre);
                    item.SubItems.Add($"${prod.Precio:N2}");
                    item.SubItems.Add("-");
                    item.Tag = prod;
                    item.ForeColor = System.Drawing.Color.Gray;
                    listViewCatalogo.Items.Add(item);
                }
                else if (elemento is PaquetePromocional subPaq)
                {
                    var item = new ListViewItem($"{indentacion}├─ SubPaquete");
                    item.SubItems.Add(subPaq.Nombre);
                    item.SubItems.Add("-");
                    item.SubItems.Add($"{subPaq.Descuento:P}");
                    item.Tag = subPaq;
                    item.ForeColor = System.Drawing.Color.Blue;
                    listViewCatalogo.Items.Add(item);

                    AgregarElementosPaquete(subPaq, nivel + 1);
                }
            }
        }

        private void buttonCalcularVentas_Click(object sender, EventArgs e)
        {
            if (!ValidarCatalogoCargado()) return;

            try
            {
                ActualizarEstado("Ejecutando CalculadorDeVentasVisitor...");

                var visitor = new CalculadorDeVentasVisitor();

                richTextBoxResultados.Clear();
                richTextBoxResultados.AppendText("=== VISITOR: CalculadorDeVentasVisitor ===\n\n");
                richTextBoxResultados.AppendText("Procesando elementos del catálogo...\n\n");

                decimal totalReal = 0;
                try
                {
                    totalReal = catalogo.CalcularTotalVentas();
                }
                catch
                {
           
                    foreach (var elemento in estructuraCatalogo)
                    {
                        elemento.Aceptar(visitor);
                    }
                    totalReal = visitor.Total;
                }

                textBoxTotal.Text = $"${totalReal:N2}";

                richTextBoxResultados.AppendText($"RESULTADO:\n");
                richTextBoxResultados.AppendText($"├─ Total calculado: ${totalReal:N2}\n\n");

                richTextBoxResultados.AppendText("LÓGICA DEL VISITOR:\n");
                richTextBoxResultados.AppendText("├─ Productos: suma precio directamente\n");
                richTextBoxResultados.AppendText("├─ Paquetes: suma elementos y aplica descuento\n");
                richTextBoxResultados.AppendText("└─ Fórmula: (suma_elementos) × (1 - descuento)\n\n");

                richTextBoxResultados.AppendText("ELEMENTOS PROCESADOS:\n");
                foreach (var elemento in estructuraCatalogo)
                {
                    if (elemento is Producto prod)
                        richTextBoxResultados.AppendText($"├─ {prod.Nombre}: ${prod.Precio:N2}\n");
                    else if (elemento is PaquetePromocional paq)
                        richTextBoxResultados.AppendText($"├─ {paq.Nombre}: {paq.Descuento:P} descuento\n");
                }

                ActualizarEstado($"CalculadorVentasVisitor completado: ${totalReal:N2}");
            }
            catch (Exception ex)
            {
                MostrarError("Error en CalculadorVentasVisitor", ex);
            }
        }

        private void buttonCalcularImpuestos_Click(object sender, EventArgs e)
        {
            if (!ValidarCatalogoCargado()) return;

            try
            {
                ActualizarEstado("Ejecutando AplicadorDeImpuestosVisitor...");

                decimal tasa = numericUpDownTasa.Value / 100;

                richTextBoxResultados.Clear();
                richTextBoxResultados.AppendText($"=== VISITOR: AplicadorDeImpuestosVisitor ===\n\n");
                richTextBoxResultados.AppendText($"Tasa de impuesto: {numericUpDownTasa.Value}%\n\n");

                IEnumerable<string> lineasImpuestos;
                try
                {
                    lineasImpuestos = catalogo.CalcularImpuestos(tasa);
                }
                catch
                {
                    // Calcular con datos locales si falla BD
                    var visitor = new AplicadorDeImpuestosVisitor(tasa);
                    foreach (var elemento in estructuraCatalogo)
                    {
                        elemento.Aceptar(visitor);
                    }
                    lineasImpuestos = visitor.LineasImpuestos;
                }

                richTextBoxResultados.AppendText("CÁLCULOS DE IMPUESTOS:\n");
                foreach (var linea in lineasImpuestos)
                {
                    richTextBoxResultados.AppendText($"├─ {linea}\n");
                }

                var totalLineas = lineasImpuestos.Count();
                richTextBoxResultados.AppendText($"\n└─ Total elementos procesados: {totalLineas}\n\n");

                richTextBoxResultados.AppendText("LÓGICA DEL VISITOR:\n");
                richTextBoxResultados.AppendText("├─ Solo procesa productos individuales\n");
                richTextBoxResultados.AppendText("├─ Fórmula: precio_base × tasa = impuesto\n");
                richTextBoxResultados.AppendText("├─ Total: precio_base + impuesto\n");
                richTextBoxResultados.AppendText("└─ Paquetes: procesa elementos internos recursivamente\n");

                ActualizarEstado($"AplicadorImpuestosVisitor completado: {totalLineas} elementos");
            }
            catch (Exception ex)
            {
                MostrarError("Error en AplicadorImpuestosVisitor", ex);
            }
        }

        private void buttonGenerarEtiquetas_Click(object sender, EventArgs e)
        {
            if (!ValidarCatalogoCargado()) return;

            try
            {
                ActualizarEstado("Ejecutando GeneradorDeEtiquetasVisitor...");

                richTextBoxResultados.Clear();
                richTextBoxResultados.AppendText("=== VISITOR: GeneradorDeEtiquetasVisitor ===\n\n");

                IEnumerable<string> etiquetas;
                try
                {
                    etiquetas = catalogo.GenerarEtiquetas();
                }
                catch
                {
                    // Generar con datos locales si falla BD
                    var visitor = new GeneradorDeEtiquetasVisitor();
                    foreach (var elemento in estructuraCatalogo)
                    {
                        elemento.Aceptar(visitor);
                    }
                    etiquetas = visitor.Etiquetas;
                }

                richTextBoxResultados.AppendText("ETIQUETAS GENERADAS:\n\n");
                int contador = 1;
                foreach (var etiqueta in etiquetas)
                {
                    richTextBoxResultados.AppendText($"{contador:D2}. {etiqueta}\n\n");
                    contador++;
                }

                var totalEtiquetas = etiquetas.Count();
                richTextBoxResultados.AppendText($"├─ Total etiquetas: {totalEtiquetas}\n\n");

                richTextBoxResultados.AppendText("LÓGICA DEL VISITOR:\n");
                richTextBoxResultados.AppendText("├─ Productos: \"Nombre — $Precio\"\n");
                richTextBoxResultados.AppendText("├─ Paquetes: \"Paquete 'Nombre' — Incluye: items (X% OFF)\"\n");
                richTextBoxResultados.AppendText("└─ Formateo específico según tipo de elemento\n");

                ActualizarEstado($"GeneradorEtiquetasVisitor completado: {totalEtiquetas} etiquetas");
            }
            catch (Exception ex)
            {
                MostrarError("Error en GeneradorEtiquetasVisitor", ex);
            }
        }

        private void buttonLimpiarResultados_Click(object sender, EventArgs e)
        {
            richTextBoxResultados.Clear();
            textBoxTotal.Text = "$0.00";
            listViewCatalogo.Items.Clear();
            estructuraCatalogo.Clear();
            ActualizarEstado("Resultados limpiados");
         
        }

        // Eventos del menú
        private void calculadorVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonCalcularVentas_Click(sender, e);
        }

        private void aplicadorImpuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonCalcularImpuestos_Click(sender, e);
        }

        private void generadorEtiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonGenerarEtiquetas_Click(sender, e);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmar",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    
        private void copiarResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBoxResultados.Text))
            {
                Clipboard.SetText(richTextBoxResultados.Text);
                ActualizarEstado("Resultados copiados al portapapeles");
            }
        }

        private void limpiarSeleccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxResultados.Clear();
            ActualizarEstado("Selección limpiada");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MostrarProgreso(false);
        }

        // Métodos auxiliares
        private bool ValidarCatalogoCargado()
        {
            if (estructuraCatalogo.Count == 0)
            {
                MessageBox.Show("Debe cargar el catálogo primero.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ActualizarEstado(string mensaje)
        {
            toolStripStatusLabel1.Text = mensaje;
            Application.DoEvents();
        }

        private void MostrarProgreso(bool mostrar)
        {
            toolStripProgressBar1.Visible = mostrar;
            if (mostrar)
            {
                toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            }
        }

        private void MostrarError(string titulo, Exception ex)
        {
            MessageBox.Show($"{titulo}:\n{ex.Message}", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            ActualizarEstado($"Error: {titulo}");
        }
    }
}