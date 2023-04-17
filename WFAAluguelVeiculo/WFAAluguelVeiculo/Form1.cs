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
            GerarGradelistView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelAno_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {   if (mtbPlaca.Text == string.Empty)
            {
                MessageBox.Show("Você deve preencher o campo Placa!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (tbAno.Text == string.Empty)
            {
                MessageBox.Show("Você deve preencher o campo Ano!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBox3.Text == string.Empty && rbCaminhao.Checked == true)
            {
                MessageBox.Show("Você deve preencher o campo Eixos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (textBox3.Text == string.Empty && rbOnibus.Checked == true)
            {
                MessageBox.Show("Você deve preencher o campo Assentos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (rbCaminhao.Checked == true) {

                Veiculo objveiculo = new caminhao(mtbPlaca.Text, Convert.ToInt32(tbAno.Text), Convert.ToInt32(textBox3));
                MensagemTela(objveiculo);
                InserirCaminhaoListView(objveiculo);


            }

            else if (rbOnibus.Checked == true)
            {

                Veiculo objveiculo = new Onibus(Convert.ToString(mtbPlaca.Text), Convert.ToInt32(tbAno.Text), Convert.ToInt32(textBox3.Text));
                MensagemTela(objveiculo);
                InserirOnibusListView(objveiculo);
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

        private void buttonLimpar_MouseCaptureChanged(object sender, EventArgs e)
        {
            mtbPlaca.Text = string.Empty;
            tbAno.Text = string.Empty;
            textBox3.Text = string.Empty;



        }

        private void InserirCaminhaoListView(Veiculo objveiculo)
        {
            string[] veiculo = new string[5];

            veiculo[0] = Convert.ToString(objveiculo.Placa);
            veiculo[1] = Convert.ToString(objveiculo.Ano);
            veiculo[3] = Convert.ToString(textBox3);
            veiculo[4] = Convert.ToString(objveiculo.alugar());
            listView1.Items.Add(new ListViewItem(veiculo));
        }

        private void InserirOnibusListView(Veiculo objveiculo)
        {
            string[] veiculo = new string[5];

            veiculo[0] = Convert.ToString(objveiculo.Placa);
            veiculo[1] = Convert.ToString(objveiculo.Ano);
            veiculo[2] = Convert.ToString(textBox3.Text);
            veiculo[4] = Convert.ToString(objveiculo.alugar());
            listView1.Items.Add(new ListViewItem(veiculo));
        }

        private void GerarGradelistView()
        {
            listView1.Columns.Add("Placa", 120).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Ano", 60).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Assentos", 70).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Eixos", 60).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Diaria", 60).TextAlign = HorizontalAlignment.Center;
            listView1.View = View.Details;
        }
    }
}
