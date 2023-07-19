using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesTipoVista.ViewModel
{
    public class TimePickerViewModel : INotifyPropertyChanged
    {
        private TimeSpan selectedTime;
        public TimeSpan SelectedTime
        {
            get
            {
                return selectedTime;
            }
            set
            {
                if (value != selectedTime)
                {
                    selectedTime = value;
                    OnPropertyChanged(nameof(SelectedTime));

                }

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public TimePickerViewModel()
        {
            SelectedTime = new TimeSpan(4, 15, 26);
        }
    }
}
