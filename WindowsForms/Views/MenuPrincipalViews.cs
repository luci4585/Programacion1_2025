using WindowsForms.Views;

namespace WindowsForms
{
    public partial class MenuPrincipalViews : Form
    {
        public MenuPrincipalViews()
        {
            InitializeComponent();
        }

        private void SubMenuSalirDelSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubMenuAppClima_Click(object sender, EventArgs e)
        {
            var appClima = new ClimaAppViews();
            appClima.ShowDialog();
        }

        private void SubMenuFormularioFuentes_Click(object sender, EventArgs e)
        {
            var fuentesForm = new FuentesView();
            fuentesForm.ShowDialog();
        }

        private void SubMenuFormPeliculasApi_Click(object sender, EventArgs e)
        {
            var peliculasApi = new PeliculasView();
            peliculasApi.ShowDialog();
        }

        private void SubMenuFormPeliculasADO_Click(object sender, EventArgs e)
        {
            var peliculasADO = new PeliculasADOView();
            peliculasADO.ShowDialog();
        }

        private void SubMenuPeliculasEF_Click(object sender, EventArgs e)
        {
            var peliculasEF = new PeliculasEFView();
            peliculasEF.ShowDialog();
        }
    }
}
