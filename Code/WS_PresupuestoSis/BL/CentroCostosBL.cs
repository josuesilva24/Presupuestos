using System;
using LD;
using System.Collections.Generic;
using ModelMap;
using System.Linq;

namespace BL
{
    public class CentroCostosBL:BaseModel
    {

#region Dependencias
        readonly Lazy<CentroCostosLD> _centroCostosLd = new Lazy<CentroCostosLD>(() => new CentroCostosLD());
        CentroCostosLD CentroCostosLd { get { return _centroCostosLd.Value; } }
        #endregion


        public List<CentroCostosMap> getCentroCostos()
        {
            var ListaCentroCostos = new List<CentroCostosMap>();
            foreach (var item in CentroCostosLd.getCentrosCosto().ToList())
            {
                ListaCentroCostos.Add
                    (
                        new CentroCostosMap
                        {
                            IdBD = item.Id,
                            Descripcion = item.Descripcion,
                            Codigo = item.Codigo,
                            Estado = item.Activo  ? "Activo":"Inactivo"
                        }
                        );


            }

            return ListaCentroCostos;
        }


        public bool updateCentroCosto(int id, bool estado)
        {
          return  CentroCostosLd.updateCentroCosto(id,estado);

        }


        public List<ProyectoCentroCostosMap> getProyectoCentroCostos()
        {
            var ListaProyectos = new List<ProyectoCentroCostosMap>();
            foreach (var item in CentroCostosLd.getProyectosCentrosCosto().ToList())
            {
                ListaProyectos.Add
                    (
                        new ProyectoCentroCostosMap
                        {
                            IdBD = item.Id,
                            Descripcion = item.DESCRIPCION,
                            Codigo = item.CODIGO,
                            Estado = item.ACTIVO == true ? "Activo" : "Inactivo",
                            CentroCosto = "CentroCosto"
                        }
                    );
            }

            return ListaProyectos;
        }


    }
}
