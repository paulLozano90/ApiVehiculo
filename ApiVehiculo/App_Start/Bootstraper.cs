using System.Data.Entity;
using BaseRepositorio.Repositorio;
using Microsoft.Practices.Unity;
using RepositorioVehiculos.Model;
using RepositorioVehiculos.ViewModel;

namespace ApiVehiculo.App_Start
{
    public class Bootstraper
    {
        public static void Init(UnityContainer container)
        {
            container.RegisterType<DbContext, AutenticacionVehiculosEntities>();
            container.RegisterType<IRepositorio<TipoVehiculo, TipoVehiculoViewModel>,
                                   RepositorioEntity<TipoVehiculo, TipoVehiculoViewModel>>();
            container.RegisterType<IRepositorio<Vehiculo, VehiculoViewModel>,
                                   RepositorioEntity<Vehiculo, VehiculoViewModel>>();
        }
    }
}