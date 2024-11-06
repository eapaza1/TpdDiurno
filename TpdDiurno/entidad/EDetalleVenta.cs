using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpdDiurno.entidad
{
    public class EDetalleVenta
    {
        private double total;
        private int producto_id;
        private double cantidad;
        private double precio;
        private int id;
        private int venta_id;

        private EProducto producto;

        public double Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Total { get => total; set => total = value; }
        public int Id { get => id; set => id = value; }
        public int Venta_id { get => venta_id; set => venta_id = value; }
        public int Producto_id { get => producto_id; set => producto_id = value; }

        //relacion de asociacion de clases
        public EProducto Producto { get => producto; set => producto = value; }
    }
}
