

namespace TpdDiurno.entidad
{
    public class EProducto
    {
        private int id, categoria_id;
        private string nombre;
        private double precio, stock;
        private byte[] imagen;

        public EProducto()
        {

        }

        public EProducto(int id, int categoria_id, string nombre, double precio, double stock, byte[] imagen)
        {
            this.id = id;
            this.categoria_id = categoria_id;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.imagen = imagen;
        }

        public int Id { get => id; set => id = value; }
        public int CategoriaId { get => categoria_id; set => categoria_id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Stock { get => stock; set => stock = value; }
        public byte[] Image { get => imagen; set => imagen = value; }
    }
}
