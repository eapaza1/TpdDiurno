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
    public partial class VentaDetalleItem : UserControl
    {
        public delegate void EventDelegate(EDetalleVenta data,int index,EventArgs e);

        public event EventDelegate event_change;
        public event EventDelegate event_delete;


        private int index = 0;
        private EDetalleVenta item;
        public VentaDetalleItem()
        {
            InitializeComponent();
            btn_delete.Enabled = false;
            btn_down.Visible = false;
            btn_up.Visible = false;

            
        }

        public void setItem(EDetalleVenta item,int index)
        {
            this.item = item;   
            this.index = index;
            render();
        }       

        public int Index { get => index; set => index = value; }

        private void render()
        {
            lbl_cantidad.Text = item.Cantidad.ToString("F1");
            lbl_nombre.Text = item.Producto.Nombre;
            lbl_precio.Text = item.Precio.ToString("F2");
            lbl_total.Text = item.Total.ToString("F2");

            lbl_nombre.TextAlign=ContentAlignment.MiddleLeft;
            lbl_precio.TextAlign=ContentAlignment.MiddleRight;
            lbl_total.TextAlign=ContentAlignment.MiddleRight;

            btn_delete.Enabled = true;
            btn_down.Visible = true;
            btn_up.Visible = true;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            event_delete?.Invoke(item, index, e);
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            item.Cantidad += 1;
            item.Total = item.Cantidad * item.Precio;
            render();
            event_change?.Invoke(item, index, e);

        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            item.Cantidad -= 1;
            if (item.Cantidad <= 0)
            {
                event_delete?.Invoke(item, index, e);
            }
            else
            {
                item.Total = item.Cantidad * item.Precio;
                render();
                event_change?.Invoke(item,index, e);

            }

        }
    }
}
