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
        {   if (mtbPlaca.Text == null)
            {
                MessageBox.Show("Você deve preencher o campo Placa!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (tbAno.Text == null)
            {
                MessageBox.Show("Você deve preencher o campo Ano!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBox3.Text == null && rbCaminhao.Checked == true)
            {
                MessageBox.Show("Você deve preencher o campo Eixos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBox3.Text == null && rbOnibus.Checked == true)
            {
                MessageBox.Show("Você deve preencher o campo Assentos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (rbCaminhao.Checked == true) {

                Veiculo objveiculo = new caminhao(mtbPlaca.Text, Convert.ToInt32(tbAno.Text), Convert.ToInt32(textBox3));
                MensagemTela(objveiculo);
            
            
            }

            else if (rbOnibus.Checked == true)
            {

                Veiculo objveiculo = new Onibus(mtbPlaca.Text, Convert.ToInt32(tbAno.Text), Convert.ToInt32(textBox3));
                MensagemTela(objveiculo);

            }



        }

        private void mtbPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void rbOnibus_Click(object sender, EventArgs e)
        {

        }

        private void rbOnibus_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = WFAAluguelVeiculo.Properties.Resources.onibus;
            LabelAssentos_Eixos.Text= "Assentos" ;
        }

        private void rbCaminhao_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = WFAAluguelVeiculo.Properties.Resources.caminhao;
            LabelAssentos_Eixos.Text = "Eixos";
        }

        private void MensagemTela(Veiculo veiculo)
        {
            MessageBox.Show("Diária: R$ " + veiculo.alugar(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
