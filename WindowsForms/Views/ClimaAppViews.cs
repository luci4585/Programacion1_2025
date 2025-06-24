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
using WindowsForms.Views;

namespace WindowsForms
{
    public partial class ClimaAppViews : Form
    {
        public ClimaAppViews()
        {
            InitializeComponent();
        }

        private void subMenuSalirDeLaApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonSalirApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonNosotrosClick_Click(object sender, EventArgs e)
        {
            NosotrosView nosotrosView = new NosotrosView();
            nosotrosView.ShowDialog();
        }

        private void subMenuNosotros_Click(object sender, EventArgs e)
        {
            botonNosotrosClick_Click(sender, e);
        }

        private async void BtnObtenerClima_Click(object sender, EventArgs e)
        {
            string url = "https://api.open-meteo.com/v1/forecast?latitude=-30.7891&longitude=-60.5919&current=temperature_2m,relative_humidity_2m,rain";

            var clientHttp = new HttpClient();
            var response = await clientHttp.GetAsync(url);
            if (response != null)
            {
                QuertyTemperature quertyTemperature = await response.Content.ReadFromJsonAsync<QuertyTemperature>();
                MessageBox.Show($"Temperatura actual es:" + quertyTemperature.current.temperature_2m);
                this.LabelTemperatura.Text = $"Temperatura actual es: {quertyTemperature.current.temperature_2m} °C";
            }
        }
    }
}
