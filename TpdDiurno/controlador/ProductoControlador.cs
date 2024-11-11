using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpdDiurno.entidad;
using TpdDiurno.modelo;

namespace TpdDiurno.controlador
{
    public class ProductoControlador
    {

        private ProductoModel model;

        public ProductoControlador()
        {
            model = new ProductoModel();
        }
        public int Create(EProducto user)
        {
            return model.Create(user);
        }
        public List<EProducto> GetAll()
        {
            return model.ReadAll();
        }
        public int Update(EProducto user)
        {
            return model.Update(user);
        }
        public int Delete(EProducto user)
        {
            return model.Delete(user);
        }
    }

}
