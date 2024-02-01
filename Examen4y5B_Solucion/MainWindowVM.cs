using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen4y5B_Solucion
{
    class MainWindowVM : ObservableObject
    {
        private VehiculoService service;
        private ObservableCollection<Vehiculo> listaVehiculos;
        public ObservableCollection<Vehiculo> ListaVehiculos
        {
            get { return listaVehiculos; }
            set { SetProperty(ref listaVehiculos, value); }
        }
        private Vehiculo vehiculoSeleccionado;
        public Vehiculo VehiculoSeleccionado
        {
            get { return vehiculoSeleccionado; }
            set { SetProperty(ref vehiculoSeleccionado, value); }
        }
        private ObservableCollection<String> listaEstados;
        public ObservableCollection<String> ListaEstados
        {
            get { return listaEstados; }
            set { SetProperty(ref listaEstados, value); }
        }
        public MainWindowVM()
        {
            service = new VehiculoService();
            ListaVehiculos = service.GetSamples();
            VehiculoSeleccionado = null;
            ListaEstados = new ObservableCollection<string>();
            ListaEstados.Add("Disponible");
            ListaEstados.Add("Reservado");
            ListaEstados.Add("Vendido");
        }
        public void Eliminar()
        {
            ListaVehiculos.Remove(VehiculoSeleccionado);
        }
        public void LimpiarSeleccion()
        {
            VehiculoSeleccionado = null;
        }
    }
}
