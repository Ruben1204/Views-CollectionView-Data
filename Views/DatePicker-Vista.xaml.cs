namespace ControlesTipoVista.Views;

public partial class DatePicker_Vista : ContentPage
{
	public DatePicker_Vista()
	{
		InitializeComponent();
	}

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
		lblDatePicker.Text = "Ha Seleccionado una fecha (SUSCRIBETE)";
		lblDatePicker.TextColor = Colors.Purple;
    }
}