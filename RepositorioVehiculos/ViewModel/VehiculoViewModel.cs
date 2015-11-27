using System;
using BaseRepositorio.ViewModel;
using RepositorioVehiculos.Model;

namespace RepositorioVehiculos.ViewModel
{
    public class VehiculoViewModel:IViewModel<Vehiculo>
    {
        public int idVehiculo { get; set; }
        public int idTipo { get; set; }
        public string matricula { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public int coste { get; set; }
        public Nullable<int> potencia { get; set; }

        public Vehiculo ToBaseDatos()
        {
            return new Vehiculo()
            {
                idVehiculo = idVehiculo,
                idTipo = idTipo,
                matricula = matricula,
                modelo = modelo,
                marca = marca,
                coste = coste,
                potencia = potencia
            };
        }

        public void FromBaseDatos(Vehiculo model)
        {
            idVehiculo = model.idVehiculo;
            idTipo = model.idTipo;
            matricula = model.matricula;
            modelo = model.modelo;
            marca = model.marca;
            coste = model.coste;
            potencia = model.potencia;
        }

        public void UpdateBaseDatos(Vehiculo model)
        {
            model.idVehiculo = idVehiculo;
            model.idTipo = idTipo;
            model.matricula = matricula;
            model.modelo = modelo;
            model.marca = marca;
            model.coste = coste;
            model.potencia = potencia;
        }

        public object[] GetKeys()
        {
            return new object[] {idVehiculo};
        }
    }
}