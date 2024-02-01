using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen4y5B_Solucion
{
    class VehiculoService : ObservableObject
    {
        public ObservableCollection<Vehiculo> GetSamples()
        {
            ObservableCollection<Vehiculo> lista = new ObservableCollection<Vehiculo>();

            lista.Add(new Vehiculo("coche", "Madrid", "Volkswagen Touran | Advance 2.0 TDI | 2020 | 65.387 Km | 115 CV | Diésel | Manual", "imagenes/touran.jpg", true, 19742, "Vendido"));
            lista.Add(new Vehiculo("coche", "Barcelona", "Peugeot 508 | 5P GT Line BlueHDi (130) |  2019 | 102.476 Km | 130 CV | Diésel | Automático", "imagenes/peugeot508.jpg", false, 16503, "Disponible"));
            lista.Add(new Vehiculo("coche", "Alicante", "Toyota C-HR | 1.8 125H Advance |  2020 | 49.608 Km | 122 CV | Híbrido | Automático", "imagenes/toyotaCHR.jpg", true, 18008, "Disponible"));
            lista.Add(new Vehiculo("furgoneta", "Málaga", "Peugeot EXPERT 1.5 HDI | Kilometraje:28.900 km | Potencia:88 kW (119,65 PS) | Año de la primera matriculación:2.022 | Combustible: diesel", "imagenes/furgonetaPeugeot.jpg", false, 21404, "Disponible"));
            lista.Add(new Vehiculo("furgoneta", "Sevilla", "VW Crafter | Kilometraje:46.211 km | Potencia:103 kW (140,04 PS) | Año de la primera matriculación:2.019 | Combustible: diesel", "imagenes/furgonetaVW.jpg", true, 28842, "Disponible"));
            lista.Add(new Vehiculo("moto", "Valencia", "YAMAHA YZF 600 R THUNDER CAT | Año: 1998 | Cilindrada: 600 c | Kilómetros: 49000", "imagenes/motoYamaha.jpg", false, 1488, "Disponible"));
            lista.Add(new Vehiculo("moto", "Alicante", "HARLEY DAVIDSON XL 883 SPORTSTER | Año: 2005 | Cilindrada: 883 c | Kilómetros: 37500", "imagenes/motoHD.jpg", false, 4090, "Disponible"));

            return lista;
        }
    }
}
