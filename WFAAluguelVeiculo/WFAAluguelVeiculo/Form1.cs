using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAAluguelVeiculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelAno_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (rbCaminhao.Checked == true) {

                Veiculo objveiculo = new caminhao(tbPlaca.Text, Convert.ToInt32(tbAno.Text), Convert.ToInt32(textBox3));
            
            
            }

            if (rbOnibus.Checked == true)
            {

                Veiculo objveiculo = new Onibus(tbPlaca.Text, Convert.ToInt32(tbAno.Text), Convert.ToInt32(textBox3));


            }



        }

        private void mtbPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
