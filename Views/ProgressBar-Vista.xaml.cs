namespace ControlesTipoVista.Views;

public partial class ProgressBar_Vista : ContentPage
{
	public ProgressBar_Vista()
	{
		InitializeComponent();
	}

    private async void Button_Clicked25(object sender, EventArgs e)
    {
        await progressBar.ProgressTo(0.25, 500, Easing.Linear);
    }
    private async void Button_Clicked50(object sender, EventArgs e)
    {
        await progressBar.ProgressTo(0.50, 500, Easing.Linear);
    }
    private async void Button_Clicked75(object sender, EventArgs e)
    {
        await progressBar.ProgressTo(0.75, 500, Easing.Linear);
    }
    private async void Button_Clicked100(object sender, EventArgs e)
    {
        await progressBar.ProgressTo(1, 500, Easing.Linear);
    }
}