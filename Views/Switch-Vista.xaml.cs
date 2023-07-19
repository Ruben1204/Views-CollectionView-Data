namespace ControlesTipoVista.Views;

public partial class Switch_Vista : ContentPage
{
	public Switch_Vista()
	{
		InitializeComponent();
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
		bool variable = e.Value;

		if (variable == true)
		{
			lblMensaje.Text = "Si este Video ha aportado a tu conocomiento !SUSCRIBETE!";

		}
		else
			lblMensaje.Text = "";
    }
}