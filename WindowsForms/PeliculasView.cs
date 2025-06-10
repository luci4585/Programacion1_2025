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
        string url = "https://cinesoftware-8275.restdb.io/rest/peliculas?apikey=510a2b7336a80665cf49419b623d4c4132ab0";
        Pelicula peliculaModificada;
        List<Pelicula> peliculas;

        public PeliculasView()
        {
            InitializeComponent();
            ObtenemosPeliculas();
        }

        private async void ObtenemosPeliculas()
        {
            var response = await clientHttp.GetAsync(url);
            if (response != null)
            {
                peliculas = await response.Content.ReadFromJsonAsync<List<Pelicula>>();
                GridPeliculas.DataSource = peliculas;
            }
        }


        private void GridPeliculas_SelectionChanged_1(object sender, EventArgs e)
        {
            if (GridPeliculas.RowCount > 0 && GridPeliculas.SelectedRows.Count > 0)
            {
                Pelicula peliculaSeleccionada = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
                FilmPicture.ImageLocation = peliculaSeleccionada.portada;
            }
        }

        private async void BtnEliminar_Click_1(object sender, EventArgs e)
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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControlesAgregarEditar();
            TabControl.SelectTab("TabpageAgregarEditar");
        }
        private void LimpiarControlesAgregarEditar()
        {
            TxtTitulo.Clear();
            NumericDuracion.Value = 0;
            TxtPortada.Clear();
            NumericCalificacion.Value = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageLista");
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Pelicula peliculaAGuardar = new Pelicula
            {
                titulo = TxtTitulo.Text,
                duracion = (int)NumericDuracion.Value,
                portada = TxtPortada.Text,
                calificacion = (double)NumericCalificacion.Value
            };

            HttpResponseMessage response;
            if (peliculaModificada != null)
            {
                var url = $"https://cinesoftware-8275.restdb.io/rest/peliculas/{peliculaModificada._id}?apikey=510a2b7336a80665cf49419b623d4c4132ab0";
                response = await clientHttp.PutAsJsonAsync(url, peliculaAGuardar);
            }
            else
            {
                response = await clientHttp.PostAsJsonAsync(url, peliculaAGuardar);
            }
            if (response.IsSuccessStatusCode)
            {
                peliculaModificada = null; // Reiniciamos la variable para futuras inserciones
                MessageBox.Show("Pelicula se guardó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObtenemosPeliculas();
                LimpiarControlesAgregarEditar();
                TabControl.SelectTab("TabPageLista");
            }
            else
            {
                MessageBox.Show("Error al agregar la pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //chequeamos que haya películas seleccionadas
            if (GridPeliculas.RowCount > 0 && GridPeliculas.SelectedRows.Count > 0)
            {
                peliculaModificada = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
                TxtTitulo.Text = peliculaModificada.titulo;
                NumericDuracion.Value = peliculaModificada.duracion;
                TxtPortada.Text = peliculaModificada.portada;
                NumericCalificacion.Value = (decimal)peliculaModificada.calificacion;
                TabControl.SelectTab("TabpageAgregarEditar");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridPeliculas.DataSource = peliculas.Where(p => p.titulo.ToUpper().Contains(TxtBuscar.Text.ToUpper())).ToList();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TxtBuscar.Text))
            {
                BtnBuscar.PerformClick();
            }
        }
    }
} 
