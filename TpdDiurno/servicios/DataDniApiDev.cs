using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpdDiurno.servicios
{
    public class DataDniApiDev
    {
        //clase creado para recibir data de dni desde peruapi.dev
        string numero, nombre_completo, nombres;
        string apellido_paterno, apellido_materno;
        int codigo_verificacion;

        public string Numero { get => numero; set => numero = value; }
        public string Nombre_completo { get => nombre_completo; set => nombre_completo = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellido_paterno { get => apellido_paterno; set => apellido_paterno = value; }
        public string Apellido_materno { get => apellido_materno; set => apellido_materno = value; }
        public int Codigo_verificacion { get => codigo_verificacion; set => codigo_verificacion = value; }

    }
}
