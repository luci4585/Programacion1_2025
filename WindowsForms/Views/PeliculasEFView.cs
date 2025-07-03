using System;
using System.Collections.Generic;
using System.Data;
using WindowsForms.Models;
using WindowsForms.Services;

namespace WindowsForms
{
    public partial class PeliculasEFView : Form
    {
        PeliculaEFService peliculaService = new PeliculaEFService();
        PaisEFService paisEFService = new PaisEFService();
        Pelicula peliculaModificada;
        List<Pelicula>? peliculas;

        public PeliculasEFView()
        {
            InitializeComponent();
            ObtenemosPeliculas();
            CargarComboPaises();
        }

        private async void CargarComboPaises()
        {
            ComboPaises.DataSource = await paisEFService.GetAllAsync();
            ComboPaises.ValueMember = "Id";
            ComboPaises.DisplayMember = "Nombre";
        }

        private async void ObtenemosPeliculas()
        {
            peliculas = await peliculaService.GetAllAsync();
            GridPeliculas.DataSource = peliculas;
            GridPeliculas.Columns["id"].Visible = false;
            GridPeliculas.Columns["Pais"].Visible = false;
            GridPeliculas.Columns["PaisId"].Visible = false;
            GridPeliculas.Columns["Eliminado"].Visible = false;
            GridPeliculas.Columns["Portada"].Visible = false;
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
                    if (await peliculaService.DeleteAsync(peliculaSeleccionada.id))
                    {
                        LabelStatusMessage.Text = $"Pelicula {peliculaSeleccionada.titulo} eliminada correctamente";
                        TimerStatusBar.Start();
                        ObtenemosPeliculas();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                id = peliculaModificada?.id ?? null,
                titulo = TxtTitulo.Text,
                duracion = (int)NumericDuracion.Value,
                portada = TxtPortada.Text,
                calificacion = (double)NumericCalificacion.Value,
                PaisId = (int?)ComboPaises.SelectedValue
            };

            bool response;
            if (peliculaModificada != null)
            {
                response = await peliculaService.UpdateAsync(peliculaAGuardar);
            }
            else
            {
                response = await peliculaService.AddAsync(peliculaAGuardar);
            }
            if (response)
            {
                peliculaModificada = null; // Reiniciamos la variable para futuras inserciones
                LabelStatusMessage.Text = "Película modificada correctamente";
                TimerStatusBar.Start();
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
                //asignar el país seleccionado en el combo
                if (peliculaModificada.PaisId != null)
                {
                    ComboPaises.SelectedValue = peliculaModificada.PaisId;
                }
                else
                {
                    ComboPaises.SelectedIndex = -1;
                }
                TabControl.SelectTab("TabpageAgregarEditar");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridPeliculas.DataSource = peliculas.Where(p => p.titulo.ToUpper().Contains(TxtBuscar.Text.ToUpper())).ToList();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BtnBuscar.PerformClick();
        }

        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            LabelStatusMessage.Text = string.Empty;
            TimerStatusBar.Stop();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 
