using System;
using System.Collections.Generic;
using TpdDiurno.entidad;
using TpdDiurno.modelo;

namespace TpdDiurno.controlador
{
    public class ClienteControlador
    {
        private ClienteModelo model;

        public ClienteControlador()
        {
            model = new ClienteModelo();
        }

        public int Create(ECliente cliente)
        {
            return model.Crear(cliente);
        }

        public List<ECliente> GetAll()
        {
            return model.getAll();
        }

        public ECliente GetById(int id)
        {
            return model.getById(id);
        }

        public ECliente GetByNroDoc(string nrodoc)
        {
            return model.getByNroDoc(nrodoc);
        }

        public int Update(ECliente cliente)
        {
            return model.Actualizar(cliente);
        }

        public int Delete(int id)
        {
            return model.Eliminar(id);
        }
    }
}
