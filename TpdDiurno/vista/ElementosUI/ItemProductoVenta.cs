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
    public partial class ItemProductoVenta : UserControl
    {
        //interface para los eventos
        public delegate void EventoItemProducto(EProducto data, EventArgs e);

        public event EventoItemProducto eventAddCart;

        private EProducto item;

      

        public ItemProductoVenta()
        {
            InitializeComponent();
        }
        
        public EProducto Item
        {
            get { return item; }
            set { 
                item = value;
                mostrar();            
            }
        }
        private void mostrar()
        {
            lbl_nombre.Text = item.Nombre;
            lbl_precio.Text=""+item.Precio;

        }


        private void pb_btn_add_Click(object sender, EventArgs e)
        {
            eventAddCart?.Invoke(item,e);

        }

    }
}
