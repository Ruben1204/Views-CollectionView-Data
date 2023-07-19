using ControlesTipoVista.Data;
using ControlesTipoVista.ViewModel;

namespace ControlesTipoVista.Views;

public partial class CarouselView_Vista : ContentPage
{
	public CarouselView_Vista()
	{
		InitializeComponent();
	}

    private void CarouselView_RemainingItemsThresholdReached(object sender, EventArgs e)
    {
		//colocar el codigo a ejecutar
    }

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        bool isToggled = e.Value;
        carouselView.EmptyView = isToggled ? Resources["VistaVaciaBasica"] : Resources["VistaVaciaAvanzada"];
    }

    private void carouselView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        if (carouselView.IsDragging)
        {
            lbl1.Text = "Variacion Horizontal" + e.HorizontalDelta;
            lbl2.Text = "Variacion Vertical:" + e.VerticalDelta;
            lbl3.Text = "Posicion Relativa Horizontal:" + e.HorizontalOffset;
            lbl4.Text = "Posicion Relativa vertical:" + e.VerticalOffset;
            lbl5.Text = "Indice del primer elemento visible:" + e.FirstVisibleItemIndex;
            lbl6.Text = "Indice del elemento central:" + e.CenterItemIndex;
            lbl7.Text = "Indice del ultimo elemento visible:" + e.LastVisibleItemIndex;
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        //carouselView.ScrollTo(6);
        ListViewModel viewModel = BindingContext as ListViewModel;
        Robot robot = viewModel.Robots.FirstOrDefault(m => m.Nombre == "Robot 9");
        //carouselView.ScrollTo(robot, animate:false);
        carouselView.ScrollTo(robot, position: ScrollToPosition.MakeVisible);
    }
}