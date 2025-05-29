using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
