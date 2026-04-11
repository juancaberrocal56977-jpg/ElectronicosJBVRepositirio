using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.DAL;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.BLL
{
    class BLLMarca
    {
        public void Eliminar(string id)
        {
            DALMarca dal = new DALMarca();
            dal.Eliminar(id);
        }

        public void Gueardar(Marca pMarca)
        {
            if (pMarca == null)
                throw new ArgumentNullException("No puede ser null");
            if (pMarca.Descripcion.Length == 0)
                throw new ApplicationException("Debe indicar el dato  de la marca");

            DALMarca dal = new DALMarca();

            var existe = dal.SeleccionarPorId(pMarca.Codigo);
            if (existe != null) // sí existe
            {
                dal.Editar(pMarca);
            }
            else
            {
                dal.Insertar(pMarca);
            }
        }

        public Marca SeleccionarPorId(string id)
        {
            DALMarca dal = new DALMarca();
            return dal.SeleccionarPorId(id);
        }

        public List<Marca> SeleccionarTodos()
        {
            var lista = new List<Marca>();

            DALMarca dal = new DALMarca();
            lista = dal.SeleccionarTodos();

            return lista.OrderBy(x => x.Codigo).ToList();
        }
    }
}
