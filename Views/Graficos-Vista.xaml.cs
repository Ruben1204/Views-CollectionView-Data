namespace ControlesTipoVista.Views;
using ControlesTipoVista.Data;

public partial class Graficos_Vista : ContentPage
{
	public Graficos_Vista()
	{
		InitializeComponent();
	}

    private void OnStartHoverInteraction(object sender, TouchEventArgs args)
    {
        if (sender is GraphicsView graphicsView && graphicsView.Drawable is GraphicsDrawable drawable)
        {
            drawable.LineColor = Colors.Blue;
            graphicsView.Invalidate();
        }
    }
}