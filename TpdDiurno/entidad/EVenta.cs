using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpdDiurno.entidad
{
    public class EVenta
    {
        private int id, cliente_id;
        private DateTime fecha;
        private double total_pagar;

        private ECliente cliente;
        private List<EDetalleVenta> items;

        public int Id { get => id; set => id = value; }
        public int Cliente_id { get => cliente_id; set => cliente_id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Total_pagar { get => total_pagar; set => total_pagar = value; }

        //ecapsulamiento no son campos de la base de datos
        public ECliente Cliente { get => cliente; set => cliente = value; }
        public List<EDetalleVenta> Items { get => items; set => items = value; }


        public void addItem(EDetalleVenta item)
        {
            if (items == null)
            {
                items = new List<EDetalleVenta>();
            }

            items.Add(item);
            total_pagar += item.Total;
        }
        public void removeItem(int indice)
        {
            if (items.Count > 0)
            {
                total_pagar -= items[indice].Total;
                items.RemoveAt(indice);
            }
        }

        public void changeItem(EDetalleVenta item, int indice)
        {
            total_pagar = 0;
            foreach (var itemd in items)
            {
                total_pagar += itemd.Total;
                
            }
        }
    }
}
