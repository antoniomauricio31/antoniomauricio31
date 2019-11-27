namespace Moto {
    partial class ligar {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.modeloMoto = new System.Windows.Forms.TextBox();
            this.corMoto = new System.Windows.Forms.TextBox();
            this.maiorMarcha = new System.Windows.Forms.TextBox();
            this.menorMarcha = new System.Windows.Forms.TextBox();
            this.marcaMoto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.desligar = new System.Windows.Forms.RadioButton();
            this.LigarMoto = new System.Windows.Forms.RadioButton();
            this.marchaAtual = new System.Windows.Forms.Label();
            this.marcha = new System.Windows.Forms.Label();
            this.descer = new System.Windows.Forms.Button();
            this.InfoMaiorMarcha = new System.Windows.Forms.Label();
            this.InfoMenorMarcha = new System.Windows.Forms.Label();
            this.subir = new System.Windows.Forms.Button();
            this.corMarca = new System.Windows.Forms.Label();
            this.modeloMarca = new System.Windows.Forms.Label();
            this.infoMarca = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.modeloMoto);
            this.groupBox1.Controls.Add(this.corMoto);
            this.groupBox1.Controls.Add(this.maiorMarcha);
            this.groupBox1.Controls.Add(this.menorMarcha);
            this.groupBox1.Controls.Add(this.marcaMoto);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 348);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Maior Marcha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Menor Marcha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Marca";
            // 
            // modeloMoto
            // 
            this.modeloMoto.Location = new System.Drawing.Point(124, 99);
            this.modeloMoto.Name = "modeloMoto";
            this.modeloMoto.Size = new System.Drawing.Size(100, 20);
            this.modeloMoto.TabIndex = 4;
            // 
            // corMoto
            // 
            this.corMoto.Location = new System.Drawing.Point(124, 154);
            this.corMoto.Name = "corMoto";
            this.corMoto.Size = new System.Drawing.Size(100, 20);
            this.corMoto.TabIndex = 3;
            // 
            // maiorMarcha
            // 
            this.maiorMarcha.Location = new System.Drawing.Point(126, 268);
            this.maiorMarcha.Name = "maiorMarcha";
            this.maiorMarcha.Size = new System.Drawing.Size(100, 20);
            this.maiorMarcha.TabIndex = 2;
            // 
            // menorMarcha
            // 
            this.menorMarcha.Location = new System.Drawing.Point(126, 212);
            this.menorMarcha.Name = "menorMarcha";
            this.menorMarcha.Size = new System.Drawing.Size(100, 20);
            this.menorMarcha.TabIndex = 1;
            // 
            // marcaMoto
            // 
            this.marcaMoto.Location = new System.Drawing.Point(124, 48);
            this.marcaMoto.Name = "marcaMoto";
            this.marcaMoto.Size = new System.Drawing.Size(100, 20);
            this.marcaMoto.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.desligar);
            this.groupBox2.Controls.Add(this.LigarMoto);
            this.groupBox2.Controls.Add(this.marchaAtual);
            this.groupBox2.Controls.Add(this.marcha);
            this.groupBox2.Controls.Add(this.descer);
            this.groupBox2.Controls.Add(this.InfoMaiorMarcha);
            this.groupBox2.Controls.Add(this.InfoMenorMarcha);
            this.groupBox2.Controls.Add(this.subir);
            this.groupBox2.Controls.Add(this.corMarca);
            this.groupBox2.Controls.Add(this.modeloMarca);
            this.groupBox2.Controls.Add(this.infoMarca);
            this.groupBox2.Location = new System.Drawing.Point(392, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 339);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // desligar
            // 
            this.desligar.AutoSize = true;
            this.desligar.Enabled = false;
            this.desligar.Location = new System.Drawing.Point(291, 234);
            this.desligar.Name = "desligar";
            this.desligar.Size = new System.Drawing.Size(63, 17);
            this.desligar.TabIndex = 16;
            this.desligar.TabStop = true;
            this.desligar.Text = "Desligar";
            this.desligar.UseVisualStyleBackColor = true;
            this.desligar.CheckedChanged += new System.EventHandler(this.desligar_CheckedChanged);
            // 
            // LigarMoto
            // 
            this.LigarMoto.AutoSize = true;
            this.LigarMoto.Enabled = false;
            this.LigarMoto.Location = new System.Drawing.Point(220, 234);
            this.LigarMoto.Name = "LigarMoto";
            this.LigarMoto.Size = new System.Drawing.Size(48, 17);
            this.LigarMoto.TabIndex = 15;
            this.LigarMoto.TabStop = true;
            this.LigarMoto.Text = "Ligar";
            this.LigarMoto.UseVisualStyleBackColor = true;
            this.LigarMoto.CheckedChanged += new System.EventHandler(this.LigarMoto_CheckedChanged);
            // 
            // marchaAtual
            // 
            this.marchaAtual.AutoSize = true;
            this.marchaAtual.Location = new System.Drawing.Point(282, 61);
            this.marchaAtual.Name = "marchaAtual";
            this.marchaAtual.Size = new System.Drawing.Size(13, 13);
            this.marchaAtual.TabIndex = 14;
            this.marchaAtual.Text = "0";
            // 
            // marcha
            // 
            this.marcha.AutoSize = true;
            this.marcha.Location = new System.Drawing.Point(268, 29);
            this.marcha.Name = "marcha";
            this.marcha.Size = new System.Drawing.Size(43, 13);
            this.marcha.TabIndex = 13;
            this.marcha.Text = "Marcha";
            // 
            // descer
            // 
            this.descer.Enabled = false;
            this.descer.Location = new System.Drawing.Point(301, 125);
            this.descer.Name = "descer";
            this.descer.Size = new System.Drawing.Size(75, 23);
            this.descer.TabIndex = 12;
            this.descer.Text = "Descer";
            this.descer.UseVisualStyleBackColor = true;
            this.descer.Click += new System.EventHandler(this.button4_Click);
            // 
            // InfoMaiorMarcha
            // 
            this.InfoMaiorMarcha.AutoSize = true;
            this.InfoMaiorMarcha.Location = new System.Drawing.Point(30, 268);
            this.InfoMaiorMarcha.Name = "InfoMaiorMarcha";
            this.InfoMaiorMarcha.Size = new System.Drawing.Size(87, 13);
            this.InfoMaiorMarcha.TabIndex = 4;
            this.InfoMaiorMarcha.Text = "InfoMaiorMarcha";
            // 
            // InfoMenorMarcha
            // 
            this.InfoMenorMarcha.AutoSize = true;
            this.InfoMenorMarcha.Location = new System.Drawing.Point(30, 216);
            this.InfoMenorMarcha.Name = "InfoMenorMarcha";
            this.InfoMenorMarcha.Size = new System.Drawing.Size(91, 13);
            this.InfoMenorMarcha.TabIndex = 3;
            this.InfoMenorMarcha.Text = "InfoMenorMarcha";
            // 
            // subir
            // 
            this.subir.Enabled = false;
            this.subir.Location = new System.Drawing.Point(220, 125);
            this.subir.Name = "subir";
            this.subir.Size = new System.Drawing.Size(75, 23);
            this.subir.TabIndex = 11;
            this.subir.Text = "Subir";
            this.subir.UseVisualStyleBackColor = true;
            this.subir.Click += new System.EventHandler(this.button3_Click);
            // 
            // corMarca
            // 
            this.corMarca.AutoSize = true;
            this.corMarca.Location = new System.Drawing.Point(30, 151);
            this.corMarca.Name = "corMarca";
            this.corMarca.Size = new System.Drawing.Size(52, 13);
            this.corMarca.TabIndex = 2;
            this.corMarca.Text = "corMarca";
            // 
            // modeloMarca
            // 
            this.modeloMarca.AutoSize = true;
            this.modeloMarca.Location = new System.Drawing.Point(30, 96);
            this.modeloMarca.Name = "modeloMarca";
            this.modeloMarca.Size = new System.Drawing.Size(71, 13);
            this.modeloMarca.TabIndex = 1;
            this.modeloMarca.Text = "modeloMarca";
            // 
            // infoMarca
            // 
            this.infoMarca.AutoSize = true;
            this.infoMarca.Location = new System.Drawing.Point(30, 45);
            this.infoMarca.Name = "infoMarca";
            this.infoMarca.Size = new System.Drawing.Size(54, 13);
            this.infoMarca.TabIndex = 0;
            this.infoMarca.Text = "infoMarca";
            // 
            // ligar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ligar";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modeloMoto;
        private System.Windows.Forms.TextBox corMoto;
        private System.Windows.Forms.TextBox maiorMarcha;
        private System.Windows.Forms.TextBox menorMarcha;
        private System.Windows.Forms.TextBox marcaMoto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label InfoMaiorMarcha;
        private System.Windows.Forms.Label InfoMenorMarcha;
        private System.Windows.Forms.Label corMarca;
        private System.Windows.Forms.Label modeloMarca;
        private System.Windows.Forms.Label infoMarca;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button subir;
        private System.Windows.Forms.Button descer;
        private System.Windows.Forms.Label marcha;
        private System.Windows.Forms.Label marchaAtual;
        private System.Windows.Forms.RadioButton desligar;
        private System.Windows.Forms.RadioButton LigarMoto;
    }
}

