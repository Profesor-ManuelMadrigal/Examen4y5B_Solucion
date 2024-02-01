using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

class Vehiculo : ObservableObject
{
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { SetProperty(ref tipo, value); }
        }

        private string provincia;
        public string Provincia
        {
            get { return provincia; }
            set { SetProperty(ref provincia, value); }
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { SetProperty(ref descripcion, value); }
        }

        private string imagen;
        public string Imagen
        {
            get { return imagen; }
            set { SetProperty(ref imagen, value); }
        }

        private bool taller;
        public bool Taller
        {
            get { return taller; }
            set { SetProperty(ref taller, value); }
        }
        
        private double precio;
        public double Precio
        {
            get { return precio; }
            set { SetProperty(ref precio, value); }
        }

        private string estado;

        public string Estado
        {
            get { return estado; }
            set { SetProperty(ref estado, value); }
        }


        public Vehiculo(string tipo, string provincia, string descripcion, string imagen, bool taller, double precio, string estado)
        {
            this.Tipo = tipo;
            this.Provincia = provincia;
            this.Descripcion = descripcion;
            this.Imagen = imagen;
            this.Taller = taller;
            this.Precio = precio;
            this.Estado = estado;
        }

}

