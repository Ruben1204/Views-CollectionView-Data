namespace ControlesTipoVista.Views;

public partial class Editor_Vista : ContentPage
{
	public Editor_Vista()
	{
		InitializeComponent();
	}

    private void controlEditor_TextChanged(object sender, TextChangedEventArgs e)
    {
        string newValue = e.NewTextValue;
        resultLabel1.Text= "Hola," + newValue + "!";
    }

    private void controlEditor_Completed(object sender, EventArgs e)
    {
        resultLabel.Text="Suscribete";
    }
}