using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpdDiurno.entidad;

namespace TpdDiurno.vista.ElementosUI
{
    public partial class ProductListItem : UserControl
    {
        public delegate void EventoClick(EProducto data, EventArgs e);

        public event EventoClick ItemEditClick;
        public event EventoClick ItemDeleteClick;


        private EProducto item;

        public EProducto Item
        {
            get => item;
            set
            {
                item = value;
                render();
            }
        }

        private void render()
        {
            lbl_nombre.Text = item.Nombre;
            lbl_categoria.Text = item.CategoriaId.ToString();
            lbl_cantidad.Text = item.Stock.ToString();
            lbl_precio.Text = "" + item.Precio;

            //poner imagen desde array de bytes a picturebox
            if (item.Image != null && item.Image.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(item.Image))
                {
                    Image imagen = Image.FromStream(ms);
                    img_imagen.Image = imagen;
                }
            }
        }

        public ProductListItem()
        {
            InitializeComponent();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            ItemDeleteClick?.Invoke(item, e);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            ItemEditClick?.Invoke(item, e);
        }
    }
}
