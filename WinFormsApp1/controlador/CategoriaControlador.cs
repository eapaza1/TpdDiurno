using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpdDiurno.entidad;
using TpdDiurno.modelo;

namespace TpdDiurno.controlador
{
    public class CategoriaControlador
    {

        private CategoriaModelo model;

        public CategoriaControlador()
        {
            model = new CategoriaModelo();
        }
        public int Create(ECategoria user)
        {
            return model.Create(user);
        }
        public List<ECategoria> GetAll()
        {
            return model.ReadAll();
        }
        public int Update(ECategoria user)
        {
            return 0;
            //return model.Update(user);
        }
        public int Delete(ECategoria user)
        {
            return 0;
            //return model.Delete(user);
        }
    }
}
