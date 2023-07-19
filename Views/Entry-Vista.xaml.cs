namespace ControlesTipoVista.Views;

public partial class Entry_Vista : ContentPage
{
	public Entry_Vista()
	{
		InitializeComponent();
	}

    private void entrada_TextChanged(object sender, TextChangedEventArgs e)
    {
        string newValue = e.NewTextValue;
        resultLabel1.Text = "Hola, " + newValue + "!";
    }

    private void entrada_Completed(object sender, EventArgs e)
    {
        resultLabel.Text= "Suscribete";
    }
}