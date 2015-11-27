using System;
using BaseRepositorio.ViewModel;
using RepositorioVehiculos.Model;

namespace RepositorioVehiculos.ViewModel
{
    public class TipoVehiculoViewModel:IViewModel<TipoVehiculo>
    {
        public int idTipo { get; set; }
        public string nombreTipo { get; set; }
        public string descripcionTipo { get; set; }

        public TipoVehiculo ToBaseDatos()
        {
            return new TipoVehiculo()
            {
                idTipo = idTipo,
                nombreTipo = nombreTipo,
                descripcionTipo = descripcionTipo
            };
        }

        public void FromBaseDatos(TipoVehiculo model)
        {
            idTipo = model.idTipo;
            nombreTipo = model.nombreTipo;
            descripcionTipo = model.descripcionTipo;
        }

        public void UpdateBaseDatos(TipoVehiculo model)
        {
            model.idTipo = idTipo;
            model.nombreTipo = nombreTipo;
            model.descripcionTipo = descripcionTipo;
        }

        public object[] GetKeys()
        {
            return new Object[] {idTipo};
        }
    }
}