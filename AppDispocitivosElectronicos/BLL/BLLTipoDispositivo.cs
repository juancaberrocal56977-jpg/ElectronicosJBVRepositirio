using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.BLL.InterfacesBLL;
using UTN.Winform.Electronicos.DAL.InterfacesDAL;
using UTN.Winform.Electronicos.DAL;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.BLL
{
    class BLLTipoDispositivo : IBLLTipo
    {
        public Task<bool> Delete(string pCodigo)
        {
            IDALTipo datosTipo = new DALTipo();
            return datosTipo.Delete(pCodigo);        }

        public Task<IEnumerable<TipoDispositivo>> GetAllObject()
        {
            IDALTipo datosTipo = new DALTipo();
            return datosTipo.GetAllObject();
        }

        public List<TipoDispositivo> GetbyFilter(string pDescripcion)
        {
            IDALTipo datosTipo = new DALTipo();
            return datosTipo.GetObjectByFilter(pDescripcion);
        }

        public TipoDispositivo GetObjectById(string Id)
        {
            IDALTipo datosTipo = new DALTipo();
            return datosTipo.GetObjectById(Id);
        }

        public Task<TipoDispositivo> Save(TipoDispositivo pdatos)
        {
            IDALTipo datosTipo = new DALTipo();
            Task<TipoDispositivo> oObjTipo1 = null;

            if (datosTipo.GetObjectById(pdatos.Codigo) == null)

                oObjTipo1 = datosTipo.Save(pdatos);
            else
                oObjTipo1 = datosTipo.Update(pdatos);

            return oObjTipo1;
        }
    }
}
