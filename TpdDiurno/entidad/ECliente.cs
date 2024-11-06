using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpdDiurno.entidad
{
    public class ECliente
    {
        private int id;
        private string nombres, direccion, documento;

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Documento { get => documento; set => documento = value; }
    }
}
