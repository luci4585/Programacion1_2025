using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Views
{
    public partial class FuentesView : Form
    {
        public FuentesView()
        {
            InitializeComponent();
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            labelVistaPrevia.Text = TxtTexto.Text;
            labelVistaPrevia.Font = new Font(labelVistaPrevia.Font.FontFamily,
                (float)numericSize.Value, labelVistaPrevia.Font.Style);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIzquierda.Checked)
            {
                labelVistaPrevia.TextAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDerecha.Checked)
            {
                labelVistaPrevia.TextAlign = ContentAlignment.MiddleRight;
            }


        }

        private void radioCentrado_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCentrado.Checked)
            {
                labelVistaPrevia.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void comboFuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFuentes.Text == "Times New Roman")
            {
                labelVistaPrevia.Font = new Font("Times New Roman", labelVistaPrevia.Font.Size, labelVistaPrevia.Font.Style);
            }
            else if (comboFuentes.Text == "Arial")
            {
                labelVistaPrevia.Font = new Font("Arial", labelVistaPrevia.Font.Size, labelVistaPrevia.Font.Style);
            }
            else if (comboFuentes.Text == "Montserrat")
            {
                labelVistaPrevia.Font = new Font("Montserrat", labelVistaPrevia.Font.Size, labelVistaPrevia.Font.Style);
            }
        }
    }
}
