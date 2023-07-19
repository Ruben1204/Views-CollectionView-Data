using ControlesTipoVista.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ControlesTipoVista.ViewModel
{
    public class ListViewModel :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Propiedad para ejemplo de Picker

        private Robot selectedRobot;

        public Robot SelectedRobot
        {
            get
            {
                return selectedRobot;
            }
            set
            {
                if(selectedRobot != value)
                {
                    selectedRobot = value;
                    OnPropertyChanged(nameof(SelectedRobot));
                    OnPropertyChanged("SelectedRobotIndex");
                }
            }
        }

        public int SelectedRobotIndex
        {
            get
            {
                return Robots.IndexOf(SelectedRobot);
            }
        }

        private List<Robot> _robots;

        public List<Robot> Robots
        {
            get
            {
                return _robots;
            }
            set
            {
                _robots = value;
                OnPropertyChanged(nameof(Robots));

            }
        }
        //Propiedades para manejar el nombre actual y previo de los elementos

        private Robot previousRobot;
        public Robot PreviousRobot
        {
            get { return previousRobot; }
            set
            {
                previousRobot = value;
                OnPropertyChanged(nameof(PreviousRobot));
            }
        }

        private Robot currentRobot;
        public Robot CurrentRobot
        {
            get { return currentRobot; }
            set
            {
                currentRobot = value;
                OnPropertyChanged(nameof(CurrentRobot));
            }
        }

        public ICommand ItemChangedCommand => new Command<Robot>((item) =>
        {
            PreviousRobot = CurrentRobot;
            CurrentRobot = item;
        });

        //Propiedades para manejar la posición

        private int previousPosition;
        public int PreviousPosition
        {
            get { return previousPosition; }
            set
            {
                previousPosition = value;
                OnPropertyChanged(nameof(PreviousPosition));
            }
        }

        private int currentPosition;
        public int CurrentPosition
        {
            get { return currentPosition; }
            set
            {
                currentPosition = value;
                OnPropertyChanged(nameof(CurrentPosition));
            }
        }

        public ICommand PositionChangedCommand => new Command<int>((position) =>
        {
            PreviousPosition = CurrentPosition;
            CurrentPosition = position;
        });
        public ListViewModel()
        {
            Robots = new List<Robot>
            {
                 new Robot {Nombre = "Robot 1", Imagen = "dotnet_bot.png", Peso = 25.5, Details="Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},
                new Robot {Nombre = "LogoMaui", Imagen = "dotnet_bot.png", Peso = 10.5, Details="Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},
                new Robot {Nombre = "Robot 3", Imagen = "dotnet_bot.png", Peso = 20.5, Details="Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},
                new Robot {Nombre = "LogoMaui", Imagen = "dotnet_bot.png", Peso = 25.5, Details="Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},
                new Robot {Nombre = "Robot 5", Imagen = "dotnet_bot.png", Peso = 10.5, Details = "Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},
                new Robot {Nombre = "Robot 6", Imagen = "dotnet_bot.png", Peso = 20.5, Details = "Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},
                new Robot {Nombre = "LogoMaui", Imagen = "dotnet_bot.png", Peso = 25.5, Details = "Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},
                new Robot {Nombre = "Robot 8", Imagen = "dotnet_bot.png", Peso = 10.5, Details = "Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},
                new Robot {Nombre = "LogoMaui", Imagen = "dotnet_bot.png", Peso = 20.5, Details = "Este Robot se llama dotnet_bot y es la imagen visual de NETMAUI"},

            };
        }
    }
}
