using AplicacionNETMAUI.Views;

namespace AplicacionNETMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PeliculasView();
        }
    }
}
