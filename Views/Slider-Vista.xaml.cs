namespace ControlesTipoVista.Views;

public partial class Slider_Vista : ContentPage
{
	public Slider_Vista()
	{
		InitializeComponent();
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		double value = e.NewValue;
		rotarEtiqueta.Rotation = value;
		MostrarEtiqueta.Text = String.Format("El valor del slider es {0}", value);
    }
}