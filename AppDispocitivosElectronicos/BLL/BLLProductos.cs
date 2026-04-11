using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.BLL.InterfacesBLL;
using UTN.Winform.Electronicos.DAL;
using UTN.Winform.Electronicos.DAL.InterfacesDAL;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.BLL
{
    class BLLProductos : IBLLProducto
    {
        public Task<bool> Delete(string pCodigo) { 
        
        IDALProducto producto= new DALProducto();

            return producto.Delete(pCodigo);
           
        }

        public Task<IEnumerable<Productos>> GetAllObject()
        {
            IDALProducto producto = new DALProducto();

            return producto.GetAllObject();
        }

        public List<Productos> GetByFilter(string pDescripcion)
        {
            IDALProducto producto = new DALProducto();

            return producto.GetObjectByFilter(pDescripcion);
       }

        public Productos GetObjectById(string Id)
        {
            IDALProducto producto = new DALProducto();

            return producto.GetObjectById(Id);
        }

        public Task<Productos> Save(Productos pdatos)
        {
            IDALProducto productosDatos = new DALProducto();
            Task<Productos> oProductos = null;

            if (productosDatos.GetObjectById(pdatos.Codigo) == null)
                oProductos = productosDatos.Save(pdatos);
            else
                oProductos = productosDatos.Update(pdatos);

            return oProductos;
        }
    }
}
