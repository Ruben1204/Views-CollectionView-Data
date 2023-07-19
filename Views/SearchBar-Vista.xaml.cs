using ControlesTipoVista.Services;

namespace ControlesTipoVista.Views;

public partial class SearchBar_Vista : ContentPage
{
	public SearchBar_Vista()
	{
		InitializeComponent();
	}

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        SearchBar searchBar = (SearchBar)sender;
        searchResults.ItemsSource = DataService.SearchCountries(searchBar.Text);

    }

    private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        lblprueba.Text = "Presionaste el icono buscar";
    }
}