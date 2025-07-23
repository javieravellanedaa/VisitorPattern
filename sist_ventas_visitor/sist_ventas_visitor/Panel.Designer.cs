using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace sist_ventas_visitor
{
    partial class Panel : Form
    {
        private IContainer components = null;
        private TabControl tabControlMain;
        private TabPage tabExplorador;
        private TabPage tabOperacion;
        private TabPage tabResultados;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
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
        /// Método necesario para soporte de Diseñador. No modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new Container();
            this.tabControlMain = new TabControl();
            this.tabExplorador = new TabPage();
            this.tabOperacion = new TabPage();
            this.tabResultados = new TabPage();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabExplorador);
            this.tabControlMain.Controls.Add(this.tabOperacion);
            this.tabControlMain.Controls.Add(this.tabResultados);
            this.tabControlMain.Dock = DockStyle.Fill;
            this.tabControlMain.Location = new Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new Size(800, 450);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabExplorador
            // 
            this.tabExplorador.Location = new Point(4, 22);
            this.tabExplorador.Name = "tabExplorador";
            this.tabExplorador.Padding = new Padding(3);
            this.tabExplorador.Size = new Size(792, 424);
            this.tabExplorador.TabIndex = 0;
            this.tabExplorador.Text = "Explorador";
            this.tabExplorador.UseVisualStyleBackColor = true;
            // 
            // tabOperacion
            // 
            this.tabOperacion.Location = new Point(4, 22);
            this.tabOperacion.Name = "tabOperacion";
            this.tabOperacion.Padding = new Padding(3);
            this.tabOperacion.Size = new Size(792, 424);
            this.tabOperacion.TabIndex = 1;
            this.tabOperacion.Text = "Operación";
            this.tabOperacion.UseVisualStyleBackColor = true;
            // 
            // tabResultados
            // 
            this.tabResultados.Location = new Point(4, 22);
            this.tabResultados.Name = "tabResultados";
            this.tabResultados.Padding = new Padding(3);
            this.tabResultados.Size = new Size(792, 424);
            this.tabResultados.TabIndex = 2;
            this.tabResultados.Text = "Resultados";
            this.tabResultados.UseVisualStyleBackColor = true;
            // 
            // Panel
            // 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Panel";
            this.Text = "Sistema de Ventas - Visitor";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
