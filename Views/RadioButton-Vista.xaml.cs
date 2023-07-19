namespace ControlesTipoVista.Views;

public partial class RadioButton_Vista : ContentPage
{
	public RadioButton_Vista()
	{
		InitializeComponent();
	}

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		RadioButton radioButton = sender as RadioButton;

		if(radioButton.IsChecked)
		{
			labelradio.Text = $"Seleccionaste la accion {radioButton.Content}";
		}
    }
}