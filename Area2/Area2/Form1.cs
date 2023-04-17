using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbImagens.Image =  Area2.Properties.Resources.branco;
            ocultaPainel();
            GerarGradelistViewArea();
        }

        private void btArea_Click(object sender, EventArgs e)
        {
            if (rbQuadrado.Checked == true) 
            {
                Formas objformas = new Quadrado("Quadrado", Convert.ToDouble(tbLadoQuadrado.Text));
                InserirAreaQuadradoListView(objformas);
                MensagemTelaArea(objformas);
            
            }else if (rbRetangulo.Checked == true)
            {
                Formas objformas = new Retangulo("Retangulo", Convert.ToDouble(tbBaseRetangulo.Text), Convert.ToDouble(tbAlturaRetangulo.Text));
               
                MensagemTelaArea(objformas);

            }else if(rbTriangulo.Checked == true)
            {
                Formas objformas = new Triangulo("Triangulo", Convert.ToDouble(tbBaseTriangulo.Text), Convert.ToDouble(tbAlturaTriangulo.Text));
                MensagemTelaArea(objformas);
            }
            else if(rbCirculo.Checked == true)
            {
                Formas objformas = new Circulo("Circulo", Convert.ToDouble(tbRaio.Text));
                MensagemTelaArea(objformas);
            }
            else
            {
                MensagemTelaEscolhaForma();
            }

        
        }


        // Metodos de Inserção no ListView
        private void InserirAreaQuadradoListView(Formas objformas)
        {
            string[] formasGeos = new string[6];

            formasGeos[0] = objformas.Nome;
            formasGeos[1] = tbLadoQuadrado.Text;
            formasGeos[5] = Convert.ToString(objformas.area());
            listViewArea.Items.Add(new ListViewItem(formasGeos));
        }
        private void InserirAreaRetanguloListView(Formas retangulo)
        {
            string[] formasGeos = new string[6];

            formasGeos[0] = retangulo.Nome;
            formasGeos[2] = tbBaseRetangulo.Text;
            formasGeos[3] = tbAlturaRetangulo.Text;
            formasGeos[5] = Convert.ToString(retangulo.area());
            listViewArea.Items.Add(new ListViewItem(formasGeos));
        }
        private void InserirAreaTrianguloListView(Formas triangulo)
        {
            string[] formasGeos = new string[6];

            formasGeos[0] = triangulo.Nome;
            formasGeos[2] = tbBaseTriangulo.Text;
            formasGeos[3] = tbAlturaTriangulo.Text;
            formasGeos[5] = Convert.ToString(triangulo.area());
            listViewArea.Items.Add(new ListViewItem(formasGeos));
        }

        private void InserirAreaCirculoListView(Formas circulo)
        {
            string[] formasGeos = new string[6];

            //formasGeos[0] = circulo.Nome;
            //formasGeos[4] = circulo.Text;
     
            //formasGeos[5] = Convert.ToString(circulo.area());
            //listViewArea.Items.Add(new ListViewItem(formasGeos));
        }
        // RadioButtons
        private void rbQuadrado_CheckedChanged(object sender, EventArgs e)
        {
            pbImagens.Image = Area2.Properties.Resources.quadrado;
            ocultaPainel();
            Limpar();
            pnlQuadrado.Visible = true;

        }

        private void rbRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            pbImagens.Image = Area2.Properties.Resources.retangulo;
            ocultaPainel();
            Limpar();
            pnlRetangulo.Visible = true;
        }

        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            pbImagens.Image = Area2.Properties.Resources.triangulo;
            ocultaPainel();
            Limpar();
            pnlTriangulo.Visible = true;
        }

        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            pbImagens.Image = Area2.Properties.Resources.circulo;
            ocultaPainel();
            Limpar();
            pnlCirculo.Visible = true;
        }

        //------------ Mensagem Tela Perimetro -----------------------
        private void MensagemTelaArea(Formas forma)
        {
            MessageBox.Show("Área: " + forma.area(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensagemTelaPerimetro(Formas forma)
        {
            MessageBox.Show("Perimetro: " + forma.perimetro(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensagemTelaEscolhaForma()
        {
            MessageBox.Show("Você deve escolher uma Forma Geométrica", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpar()
        {
            tbLadoQuadrado.Text = string.Empty;
            tbBaseRetangulo.Text = string.Empty;
            tbAlturaRetangulo.Text = string.Empty;
            tbBaseTriangulo.Text = string.Empty;
            tbAlturaTriangulo.Text = string.Empty;
            tbRaio.Text = string.Empty;

        }

        private void ocultaPainel()
        {
            pnlQuadrado.Visible = false;
            pnlRetangulo.Visible = false;
            pnlTriangulo.Visible = false;
            pnlCirculo.Visible = false;
        }

        private void GerarGradelistViewArea()
        {
            listViewArea.Columns.Add("Nome", 120).TextAlign = HorizontalAlignment.Center;
            listViewArea.Columns.Add("Lado", 60).TextAlign = HorizontalAlignment.Center;
            listViewArea.Columns.Add("Altura", 70).TextAlign = HorizontalAlignment.Center;
            listViewArea.Columns.Add("Base", 60).TextAlign = HorizontalAlignment.Center;
            listViewArea.Columns.Add("Raio", 60).TextAlign = HorizontalAlignment.Center;
            listViewArea.Columns.Add("Area", 100).TextAlign = HorizontalAlignment.Center;
            listViewArea.View = View.Details;
        }

        private void pnlCirculo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
