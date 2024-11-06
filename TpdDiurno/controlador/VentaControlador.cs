using System;
using System.Collections.Generic;
using TpdDiurno.entidad;
using TpdDiurno.modelo;

namespace TpdDiurno.controlador
{
    public class VentaControlador
    {
        private VentaModelo model;

        public VentaControlador()
        {
            model = new VentaModelo();
        }

        public int Create(EVenta venta)
        {
            return model.Crear(venta);
        }

        public List<EVenta> GetAll()
        {
            return model.Leer();
        }

        public EVenta GetById(int id)
        {
            return model.LeerPorId(id);
        }

        public int Update(EVenta venta)
        {
            return model.Actualizar(venta);
        }

        public int Delete(int id)
        {
            return model.Eliminar(id);
        }
    }
}
