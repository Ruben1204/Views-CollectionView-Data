namespace ControlesTipoVista.Views;

public partial class Stepper_Vista : ContentPage
{
	public Stepper_Vista()
	{
		InitializeComponent();
	}

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		double value = e.NewValue;
		_textoParaRotar.Rotation = value;
		_mostrarEtiqueta.Text = string.Format("El valor del stepper es {0}", value);
    }
}