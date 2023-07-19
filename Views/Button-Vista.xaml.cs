using System.Diagnostics;
namespace ControlesTipoVista.Views;

public partial class Button_Vista : ContentPage
{
    IDispatcherTimer timer;
    Stopwatch stopwatch = new Stopwatch();
    public Button_Vista()
	{
		InitializeComponent();
        timer = Dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromMilliseconds(16);
        timer.Tick += (s, e) =>
        {
            label.Rotation = 360 * (stopwatch.Elapsed.TotalSeconds % 1);
        };
        
	}

    async void Button_Clicked(object sender, EventArgs e)
    {
        await label.RelRotateTo(360, 1000);
    }

    private void Button_Pressed(object sender, EventArgs e)
    {
        stopwatch.Start();
        timer.Start();
    }

    private void Button_Released(object sender, EventArgs e)
    {
        stopwatch.Stop();
        timer.Stop();
    }
}