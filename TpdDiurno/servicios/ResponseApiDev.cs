using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpdDiurno.servicios
{
    public class ResponseApiDev<T>
    {
        bool success;
        T data;

        public bool Success { get => success; set => success = value; }
        public T Data { get => data; set => data = value; }
    } 
}
