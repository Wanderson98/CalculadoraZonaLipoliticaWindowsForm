using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using CalculadoraFrequenciaCardiacaForms.Services;

namespace CalculadoraFrequenciaCardiacaForms
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

 
        }

       

        private void btnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (btnMasculino.Checked)
            {
                char sexo = 'm';
            }
        }

        private void btnFeminino_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            CalculadoraFrequenciaCardiaca calc = new CalculadoraFrequenciaCardiaca();
            char sexo;
            double freqRepouso = double.Parse(txtFrequenciaRepouso.Text);
            double intensidade = double.Parse(txtIntensidade.Text)/100;
            int idade = int.Parse(txtIdade.Text);
            if (btnFeminino.Checked)
            {
                sexo = 'f';
            } else if (btnMasculino.Checked)
            {
                sexo = 'm';
            }
            else
            {
                throw new Exception("Selecione o sexo");
            }

            calc.CalcularFreqCardiaca(freqRepouso, intensidade, idade, sexo);

            txtFrequenciaMaxima.Text = calc.FrequenciaMaxima.ToString("F2");
            txtFrequenciaMinima.Text = calc.FrequenciaMinima.ToString("F2");

            txtFrequenciaRepouso.Clear();
            txtIntensidade.Clear();
            txtIdade.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFrequenciaMaxima.ResetText();
            txtFrequenciaMinima.ResetText();
            txtFrequenciaRepouso.Clear();
            txtIntensidade.Clear();
            txtIdade.Clear();
            btnFeminino.Checked = false;
            btnMasculino.Checked = false;
        }
    }
}
