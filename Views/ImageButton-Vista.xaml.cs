using ControlesTipoVista.ViewModel;

namespace ControlesTipoVista.Views;

public partial class ImageButton_Vista : ContentPage
{
	int TotalClicks;
	public ImageButton_Vista()
	{
		InitializeComponent();
        //var vm = new ImgBtnViewModel();
        //vm.LabelView = label;
        //BindingContext= vm;
        

	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        TotalClicks +=1;
        label.Text =$"{TotalClicks} Veces has dado click{(TotalClicks == 1 ? "" : "s")}";
    }
}