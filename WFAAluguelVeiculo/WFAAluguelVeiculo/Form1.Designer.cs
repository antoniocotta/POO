namespace WFAAluguelVeiculo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbOnibus = new System.Windows.Forms.RadioButton();
            this.rbCaminhao = new System.Windows.Forms.RadioButton();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.LabelAssentos_Eixos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.tbPlaca = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbOnibus
            // 
            this.rbOnibus.AutoSize = true;
            this.rbOnibus.Location = new System.Drawing.Point(37, 23);
            this.rbOnibus.Name = "rbOnibus";
            this.rbOnibus.Size = new System.Drawing.Size(58, 17);
            this.rbOnibus.TabIndex = 0;
            this.rbOnibus.TabStop = true;
            this.rbOnibus.Text = "Onibus";
            this.rbOnibus.UseVisualStyleBackColor = true;
            // 
            // rbCaminhao
            // 
            this.rbCaminhao.AutoSize = true;
            this.rbCaminhao.Location = new System.Drawing.Point(128, 23);
            this.rbCaminhao.Name = "rbCaminhao";
            this.rbCaminhao.Size = new System.Drawing.Size(72, 17);
            this.rbCaminhao.TabIndex = 1;
            this.rbCaminhao.TabStop = true;
            this.rbCaminhao.Text = "Caminhao";
            this.rbCaminhao.UseVisualStyleBackColor = true;
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(45, 76);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(34, 13);
            this.labelPlaca.TabIndex = 2;
            this.labelPlaca.Text = "Placa";
            this.labelPlaca.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(53, 111);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(26, 13);
            this.labelAno.TabIndex = 3;
            this.labelAno.Text = "Ano";
            this.labelAno.Click += new System.EventHandler(this.labelAno_Click);
            // 
            // LabelAssentos_Eixos
            // 
            this.LabelAssentos_Eixos.AutoSize = true;
            this.LabelAssentos_Eixos.Location = new System.Drawing.Point(9, 145);
            this.LabelAssentos_Eixos.Name = "LabelAssentos_Eixos";
            this.LabelAssentos_Eixos.Size = new System.Drawing.Size(70, 13);
            this.LabelAssentos_Eixos.TabIndex = 4;
            this.LabelAssentos_Eixos.Text = "Qtd Assentos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(255, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 151);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(93, 104);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(100, 20);
            this.tbAno.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(93, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(66, 191);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(97, 37);
            this.buttonCadastrar.TabIndex = 9;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 256);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(502, 182);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(202, 191);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(97, 37);
            this.buttonLimpar.TabIndex = 12;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(93, 69);
            this.tbPlaca.Mask = "___-____";
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(100, 20);
            this.tbPlaca.TabIndex = 13;
            this.tbPlaca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbPlaca_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPlaca);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelAssentos_Eixos);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.labelPlaca);
            this.Controls.Add(this.rbCaminhao);
            this.Controls.Add(this.rbOnibus);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbOnibus;
        private System.Windows.Forms.RadioButton rbCaminhao;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label LabelAssentos_Eixos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.MaskedTextBox tbPlaca;
    }
}

