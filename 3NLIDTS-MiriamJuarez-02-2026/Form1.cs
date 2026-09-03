using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3NLIDTS_MiriamJuarez_02_2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (tbCelcius.Text != "" || tbFahrenheit.Text != "" || tbKelvin.Text != "")
            {
                if (!string.IsNullOrEmpty(tbCelcius.Text))
                {
                    float Cc = float.Parse(tbCelcius.Text);

                    float Fa2 = (Cc * 9f / 5f) + 32;
                    tbFahrenheit.Text = Fa2.ToString();

                    float Kc = Cc + 273;
                    tbKelvin.Text = Kc.ToString();
                }
                else if (!string.IsNullOrEmpty(tbFahrenheit.Text))
                {
                    float Fa = float.Parse(tbFahrenheit.Text);

                    float Cc = (Fa - 32) * 5.0f / 9.0f;
                    tbCelcius.Text = Cc.ToString();

                    float Kc = Cc + 273;
                    tbKelvin.Text = Kc.ToString();
                }
                else if (!string.IsNullOrEmpty(tbKelvin.Text))
                {
                    float Kc = float.Parse(tbKelvin.Text);

                    float Cc = Kc - 273;
                    tbCelcius.Text = Cc.ToString();

                    float Fa2 = (Cc * 9f / 5f) + 32;
                    tbFahrenheit.Text = Fa2.ToString();
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores para el calculo de temperatura");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se Borraron los valores de los TextBox");

            tbCelcius.Clear();
            tbFahrenheit.Clear();
            tbKelvin.Clear();
        }
    }
}