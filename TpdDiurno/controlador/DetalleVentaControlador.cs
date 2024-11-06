using System;
using System.Collections.Generic;
using TpdDiurno.entidad;
using TpdDiurno.modelo;

namespace TpdDiurno.controlador
{
    public class DetalleVentaControlador
    {
        private DetalleVentaModel model;

        public DetalleVentaControlador()
        {
            model = new DetalleVentaModel();
        }

        public int Create(EDetalleVenta detalleVenta)
        {
            return model.Crear(detalleVenta);
        }

        public List<EDetalleVenta> GetAll()
        {
            return model.Leer();
        }

        public EDetalleVenta GetById(int id)
        {
            return model.LeerPorId(id);
        }

        public int Update(EDetalleVenta detalleVenta)
        {
            return model.Actualizar(detalleVenta);
        }

        public int Delete(int id)
        {
            return model.Eliminar(id);
        }
    }
}
