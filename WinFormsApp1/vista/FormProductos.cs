using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpdDiurno.controlador;
using TpdDiurno.entidad;
using TpdDiurno.vista.ElementosUI;

namespace TpdDiurno.vista
{
    public partial class FormProductos : Form
    {
        private ProductoControlador producControl;

        List<EProducto> products;
        public FormProductos()
        {
            InitializeComponent();
            producControl = new ProductoControlador();

            Listar();

            RenderProducts(products);

            layout_fill.Resize += Layout_fill_Resize;

        }



        private void Listar()
        {
            try
            {
                products = producControl.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error en listar: " + ex.Message + " con codigo: " + ex.StackTrace);
            }
        }

        private void RenderProducts(List<EProducto> products)
        {
            layout_fill.Controls.Clear();

            foreach (var item in products)
            {
                ProductListItem elemento = new ProductListItem();
                elemento.Width = layout_fill.Width - 25;
                elemento.Margin = new Padding(0, 0, 0, 3);
                elemento.Item = item;
                elemento.ItemEditClick += Item_Edit_Click;
                elemento.ItemDeleteClick += Item_Delete_Click;
                layout_fill.Controls.Add(elemento);
            }

        }

        private void Item_Delete_Click(EProducto data, EventArgs e)
        {
            MessageBox.Show("Mensaje desde boton eliminar " + data.Nombre);
        }

        private void Item_Edit_Click(EProducto data, EventArgs e)
        {
            MessageBox.Show("Mensaje desde boton Editar:  con producto: " + data.Nombre);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Layout_fill_Resize(object? sender, EventArgs e)
        {
            foreach (ProductListItem control in layout_fill.Controls)
            {
                control.Width = layout_fill.ClientSize.Width;
            }
        }

        private void txt_filtar_TextChanged(object sender, EventArgs e)
        {
            string texto=txt_filtrar.Text.ToLower();
            //edu
            //p.Nombre="Eduar apaza"==>"eduar apaza"
            var filtrados= products.Where(p=>p.Nombre.ToLower().Contains(texto)).ToList();

            RenderProducts(filtrados);

        }
    }
}
