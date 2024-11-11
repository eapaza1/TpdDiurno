using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpdDiurno.entidad
{
    public class ECategoria
    {
       private int id;
       private string nombre, descripcion;

        public ECategoria()
        {

        }

        public ECategoria(int id, string nombre, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Nombre
        {
            get => nombre; 
            set => nombre = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}
