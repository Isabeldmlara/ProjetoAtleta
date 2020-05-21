using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Atleta Isabel = new Atleta();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            try
            {
                Isabel.Altura = double.Parse(txtaltura.Text);
                Isabel.Peso = double.Parse(txtpeso.Text);
                lblresultado.Text = Isabel.CalcularIMC().ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erro. \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
