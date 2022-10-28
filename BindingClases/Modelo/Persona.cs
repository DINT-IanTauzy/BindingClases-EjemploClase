using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingClases.Modelo
{
    class Persona : INotifyPropertyChanged
    {
        private int edad;
        private string nombre;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (this.nombre != value)
                {
                    this.nombre = value;
                    this.NotifyPropertyChanged("Nombre");
                }
            }
        }

        public int Edad
        {
            get => edad;


            set
            {
                if (this.edad != value)
                {
                    this.edad = value;
                    this.NotifyPropertyChanged("Edad");
                }
            }
        }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public Persona()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
