namespace ControlesTipoVista.Views;

public partial class CheckBox_Vista : ContentPage
{
	public CheckBox_Vista()
	{
		InitializeComponent();
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		CheckBox caja = sender as CheckBox;

		if(caja.IsChecked)
		{
			lblprueba.Text="Si este video te esta aportando a tu conocimiento suscribete o apoya el video con un like o compartiendo";
			lblprueba.FontAttributes = FontAttributes.Bold | FontAttributes.Italic;
			lblprueba.FontSize = 18;
		}
		else
		{
			lblprueba.FontAttributes = FontAttributes.None;
			lblprueba.FontSize = 12;
		}
    }
}