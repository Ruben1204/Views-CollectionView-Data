using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ControlesTipoVista.ViewModel
{
    public class ImgBtnViewModel : INotifyPropertyChanged
    {
        int TotalClick;
        private Label _label;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ContadorCommand { get; set; }

        public ImgBtnViewModel() 
        {
            ContadorCommand = new Command(() =>
            {
                TotalClick +=1;
                LabelView.Text =$"{TotalClick} Veces has dado click{(TotalClick == 1 ? "" : "s")}";
            });
        }

        public Label LabelView
        { 
            get 
            { 
                return _label; 
            }
            set
            {
                if(_label != value) 
                {
                    _label = value;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LabelView"));
            }
        }
    }
}
