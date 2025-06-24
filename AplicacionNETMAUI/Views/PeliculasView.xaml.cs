using AppNetMaui.Models;
using System.Collections.ObjectModel;
using System.Net.Http.Json;

namespace AplicacionNETMAUI.Views;

public partial class PeliculasView : ContentPage
{
    HttpClient clientHttp = new HttpClient();
    string url = "https://cinesoftware-8275.restdb.io/rest/peliculas?apikey=510a2b7336a80665cf49419b623d4c4132ab0";
    ObservableCollection<Pelicula> peliculas;

    public PeliculasView()
	{
		InitializeComponent();
		TituloLabel.Text = "Peliculas - NET MAUI";
        ObtenemosPeliculas();
    }
    private async void ObtenemosPeliculas()
    {
        var response = await clientHttp.GetAsync(url);
        if (response != null)
        {
            peliculas = await response.Content.ReadFromJsonAsync<ObservableCollection<Pelicula>>();
            PeliculasListView.ItemsSource = peliculas;
        }
    }
}