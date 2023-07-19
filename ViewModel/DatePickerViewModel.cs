using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesTipoVista.ViewModel
{
    public class DatePickerViewModel : INotifyPropertyChanged
    {
        private DateTime minDate;
        private DateTime maxDate;
        private DateTime selectedDate;

        public DateTime MinDate
        {
            get
            {
                return minDate;
            }
            set
            {
                if (minDate != value)
                {
                    minDate = value;
                    OnPropertyChanged(nameof(MinDate));
                }
            }
        }

        public DateTime MaxDate
        {
            get
            {
                return maxDate;
            }
            set
            {
                if (maxDate != value)
                {
                    maxDate = value;
                    OnPropertyChanged(nameof(MaxDate));
                }
            }
        }

        public DateTime SelectedDate
        {
            get
            {
                return selectedDate;
            }
            set
            {
                if (selectedDate != value)
                {
                    selectedDate = value;
                    OnPropertyChanged(nameof(SelectedDate));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public DatePickerViewModel()
        {


            MinDate = new DateTime(2023, 1, 1);
            MaxDate = new DateTime(2023, 12, 31);
            SelectedDate = new DateTime(2023, 5, 17);

        }
    }
}
