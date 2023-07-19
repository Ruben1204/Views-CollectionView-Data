using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ControlesTipoVista.ViewModel
{
    public class EntryViewModel :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand EnterCommand { get; set; }

        private string textoEtiqueta;
        public string TextoEtiqueta
        {
            get
            {
                return textoEtiqueta;
            }
            set
            {
                if (value != textoEtiqueta)
                {
                    textoEtiqueta = value;
                    OnPropertyChanged(nameof(TextoEtiqueta));

                }

            }
        }

        public EntryViewModel()
        {
            EnterCommand = new Command(execute: () =>
            {
                TextoEtiqueta = new string("Se activo el comando");
            });
        }
    }

}
