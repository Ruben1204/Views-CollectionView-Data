using ControlesTipoVista.Data;

namespace ControlesTipoVista.Views;

public partial class Lista_Vista : ContentPage
{
	public Lista_Vista()
	{
		InitializeComponent();
	}

    private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Robot item = e.SelectedItem as Robot;
        SelecionEtiqueta.Text = "Haz selecionado un nuevo elemento  "+ item.Nombre;
        SelecionEtiqueta.TextColor = Colors.Black;
    }

    private void ListView_Scrolled(object sender, ScrolledEventArgs e)
    {
        SelecionEtiqueta1.Text = "ACABAS DE HACER ESCROLL EN LA LISTA";
        SelecionEtiqueta1.TextColor= Colors.Purple;
    }
}