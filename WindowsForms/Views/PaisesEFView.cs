using System;
using System.Collections.Generic;
using System.Data;
using WindowsForms.Models;
using WindowsForms.Services;

namespace WindowsForms
{
    public partial class PaisesEFView : Form
    {
  
        PaisEFService paisEFService = new PaisEFService();
        Pais paisCurrent;
        List<Pais>? paises;

        public PaisesEFView()
        {
            InitializeComponent();
            ObtenemosPaises();
        }

        private async void ObtenemosPaises()
        {
            paises = await paisEFService.GetAllAsync();
            GridPaises.DataSource = paises;
            GridPaises.Columns["id"].Visible = false;
            GridPaises.Columns["Eliminado"].Visible = false;
        }


        private async void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            //chequeamos que haya películas seleccionadas
            if (GridPaises.Rows.Count > 0 && GridPaises.SelectedRows.Count > 0)
            {
                Pais paisSelected = (Pais)GridPaises.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Está seguro de eliminar la película {paisSelected.Nombre} seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await paisEFService.DeleteAsync(paisSelected.Id))
                    {
                        LabelStatusMessage.Text = $"Pais {paisSelected.Nombre} eliminado correctamente";
                        TimerStatusBar.Start();
                        ObtenemosPaises();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el pais", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un pais para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControlesAgregarEditar();
            TabControl.SelectTab("TabpageAgregarEditar");
        }
        private void LimpiarControlesAgregarEditar()
        {
            TxtNombre.Clear();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageLista");
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Pais paisAGuardar = new Pais
            {
                Id = paisCurrent?.Id ?? 0,
                Nombre = TxtNombre.Text
            };

            bool response;
            if (paisCurrent != null)
            {
                response = await paisEFService.UpdateAsync(paisAGuardar);
            }
            else
            {
                response = await paisEFService.AddAsync(paisAGuardar);
            }
            if (response)
            {
                paisCurrent = null; // Reiniciamos la variable para futuras inserciones
                LabelStatusMessage.Text = "País modificado correctamente";
                TimerStatusBar.Start();
                ObtenemosPaises();
                LimpiarControlesAgregarEditar();
                TabControl.SelectTab("TabPageLista");
            }
            else
            {
                MessageBox.Show("Error al agregar el país", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //chequeamos que haya películas seleccionadas
            if (GridPaises.RowCount > 0 && GridPaises.SelectedRows.Count > 0)
            {
                paisCurrent = (Pais)GridPaises.SelectedRows[0].DataBoundItem;
                TxtNombre.Text = paisCurrent.Nombre;

                TabControl.SelectTab("TabpageAgregarEditar");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridPaises.DataSource = paises.Where(p => p.Nombre.ToUpper().Contains(TxtBuscar.Text.ToUpper())).ToList();
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
