using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ControlesTipoVista.ViewModel
{
    
    public class RefreshViewModel : INotifyPropertyChanged

    {
        private ObservableCollection<Color> _colors;
        private bool _isRefreshing;

        public ICommand RefreshCommand { get; set; }    

        public RefreshViewModel()
        {
            Colores= new ObservableCollection<Color>()
            {
                Colors.Yellow,
                Colors.Blue,
                Colors.Red
            };

            RefreshCommand = new Command(async () => await RefreshData());
        }

        public ObservableCollection<Color> Colores
        {
            get 
            {
                return _colors;
            }
            set
            {
                _colors = value;
                OnPropertyChanged(nameof(Colores));
            }
        }

        public bool IsRefreshing
        {
            get
            {
                return _isRefreshing;
            }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        private async Task RefreshData()
        {
            await Task.Delay(2000);
            Colores.Clear();
            Colores.Add(Colors.Orange);
            Colores.Add(Colors.Pink);
            Colores.Add(Colors.LightGreen);

            IsRefreshing = false;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
