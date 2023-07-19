using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ControlesTipoVista.ViewModel
{
    public class SaludarViewModel: INotifyPropertyChanged
    {
       

        private string resultado;
        public string Resultado
        {
            get
            {
                return resultado;
            }
            set
            {
                if (value != resultado)
                {
                    resultado = value;
                    OnPropertyChanged(nameof(Resultado));

                }

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand ConsultarDatosCommand { get; }

        public SaludarViewModel()
        {
            ConsultarDatosCommand = new Command(async () => await ConsultarDatos());
        }

        public async Task ConsultarDatos()
        {
            await Task.Delay(500);

            Resultado = "Saludos Acabas de usar el comando";
        }


    }
}
