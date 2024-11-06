using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpdDiurno.entidad
{
    public class EPerson
    {
        private int id;
        private string nombres,apellidos,nrodoc,direccion,telefono,estado;

        private List<EUser> users;

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nrodoc { get => nrodoc; set => nrodoc = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Estado { get => estado; set => estado = value; }

        public EPerson()
        {
        }

        public EPerson(int id, string nombres, string apellidos, string nrodoc, string direccion, string telefono, string estado)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.nrodoc = nrodoc;
            this.direccion = direccion;
            this.telefono = telefono;
            this.estado = estado;
        }
    }
}
