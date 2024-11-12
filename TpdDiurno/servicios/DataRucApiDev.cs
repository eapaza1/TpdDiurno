using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpdDiurno.servicios
{
    public class DataRucApiDev
    {
        string ruc, direccion, direccion_completa, nombre_o_razon_social, estado, condicion, distrito,provincia,departamento, ubigeo_sunat;

        public string Ruc { get => ruc; set => ruc = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Direccion_completa { get => direccion_completa; set => direccion_completa = value; }
        public string Nombre_o_razon_social { get => nombre_o_razon_social; set => nombre_o_razon_social = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Condicion { get => condicion; set => condicion = value; }
        public string Distrito { get => distrito; set => distrito = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Ubigeo_sunat { get => ubigeo_sunat; set => ubigeo_sunat = value; }
    }
}
