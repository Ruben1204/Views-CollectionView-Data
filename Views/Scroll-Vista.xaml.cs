using ControlesTipoVista.Data;
namespace ControlesTipoVista.Views;

public partial class Scroll_Vista : ContentPage
{
	public List<Pais> Paises { get; set; }
	public Scroll_Vista()
	{
		InitializeComponent();

        Paises= new List<Pais>
        {
            new Pais { Name = "Colombia", Capital = "Bogotá" },
            new Pais { Name = "Argentina", Capital = "Buenos Aires" },
            new Pais { Name = "Brasil", Capital = "Brasilia" },
            new Pais { Name = "Chile", Capital = "Santiago" },
            new Pais { Name = "Costa Rica", Capital = "San José" },
            new Pais { Name = "Cuba", Capital = "La Habana" },
            new Pais { Name = "Ecuador", Capital = "Quito" },
            new Pais { Name = "España", Capital = "Madrid" },
            new Pais { Name = "Estados Unidos", Capital = "Washington D.C." },
            new Pais { Name = "Francia", Capital = "París" },
            new Pais { Name = "Italia", Capital = "Roma" },
            new Pais { Name = "México", Capital = "Ciudad de México" },
            new Pais { Name = "Panamá", Capital = "Ciudad de Panamá" },
            new Pais { Name = "Perú", Capital = "Lima" },
            new Pais { Name = "Portugal", Capital = "Lisboa" },
            new Pais { Name = "Reino Unido", Capital = "Londres" },
            new Pais { Name = "República Dominicana", Capital = "Santo Domingo" },
            new Pais { Name = "Uruguay", Capital = "Montevideo" },
            new Pais { Name = "Venezuela", Capital = "Caracas" },
            new Pais { Name = "Alemania", Capital = "Berlín.............................................................................................................................................................................................." }
        };

        this.BindingContext = this;
    }


    private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
    {

    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}