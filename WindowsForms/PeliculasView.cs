using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Models;

namespace WindowsForms
{
    public partial class PeliculasView : Form
    {
        HttpClient clientHttp = new HttpClient();
        public PeliculasView()
        {
            InitializeComponent();
            ObtenemosPeliculas();
        }

        private async void ObtenemosPeliculas()
        {
            string url = "https://cinesoftware-8275.restdb.io/rest/peliculas?apikey=510a2b7336a80665cf49419b623d4c4132ab0";

            var response = await clientHttp.GetAsync(url);
            if (response != null)
            {
                List<Pelicula> peliculas = await response.Content.ReadFromJsonAsync<List<Pelicula>>();
                GridPeliculas.DataSource = peliculas;
            }
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            //chequeamos que haya películas seleccionadas
            if (GridPeliculas.Rows.Count > 0 && GridPeliculas.SelectedRows.Count > 0)
            {
                Pelicula peliculaSeleccionada = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Está seguro de eliminar la película {peliculaSeleccionada.titulo} seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    //obtenemos el id de la película seleccionada
                    string url = $"https://cinesoftware-8275.restdb.io/rest/peliculas/{peliculaSeleccionada._id}?apikey=510a2b7336a80665cf49419b623d4c4132ab0";
                    var response = await clientHttp.DeleteAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Película {peliculaSeleccionada.titulo} eliminada correctamente", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ObtenemosPeliculas();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una película para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridPeliculas_SelectionChanged(object sender, EventArgs e)
        {
            if (GridPeliculas.RowCount > 0 && GridPeliculas.SelectedRows.Count >0)
            {
                Pelicula peliculaSeleccionada = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
                FilmPicture.ImageLocation = peliculaSeleccionada.portada;
            }
        }
    }
}
