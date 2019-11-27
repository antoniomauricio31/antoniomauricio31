using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Moto {
    public partial class ligar : Form {
        public ligar() {
            InitializeComponent();
        }

        Moto Motoo = new Moto();

        private void button1_Click_1(object sender, EventArgs e) {
            int menor = int.Parse(menorMarcha.Text);
            int maior = int.Parse(maiorMarcha.Text);

            if (menor > maior) {
                MessageBox.Show("A menor marcha é maior que a maior marcha");
            }


            else {

                Moto Motoo = new Moto(marcaMoto.Text, modeloMoto.Text, corMoto.Text, menor, maior);
                Motoo.MarchaAtual = menor;
                InfoMaiorMarcha.Text = Convert.ToString(maior);
                marchaAtual.Text = Convert.ToString(Motoo.MarchaAtual);
                InfoMenorMarcha.Text = menorMarcha.Text;

                infoMarca.Text = Motoo.Marca;
                modeloMarca.Text = Motoo.Modelo;
                corMarca.Text = Motoo.Cor;
                menorMarcha.Text = Convert.ToString(menor);
               
               

                

                LigarMoto.Enabled = true;
                desligar.Enabled = true;
            }
           
        }

        private void button3_Click(object sender, EventArgs e) {
            if (LigarMoto.Checked == true) {
                if (maiorMarcha.Text == Convert.ToString(Motoo.MarchaAtual)) {
                    MessageBox.Show("Maior marcha Possivel");
                }
                else {
                    Motoo.marchaAcima();
                    marchaAtual.Text = Convert.ToString(Motoo.MarchaAtual);
                }
            }
            
            
        }

        private void button4_Click(object sender, EventArgs e) {
            if (LigarMoto.Checked == true ) {
                if (menorMarcha.Text == Convert.ToString(Motoo.MarchaAtual)) {
                    MessageBox.Show("Menor marcha Possivel");
                }
                else {
                    Motoo.marchaAbaixo();
                    marchaAtual.Text = Convert.ToString(Motoo.MarchaAtual);
                }
            }
            
           
        }

        private void button2_Click(object sender, EventArgs e) {
            infoMarca.Text = " ";
            modeloMarca.Text = " ";
            corMarca.Text = " ";
            InfoMenorMarcha.Text = " ";
            InfoMaiorMarcha.Text = " ";
            marchaAtual.Text = " ";
            Motoo.MarchaAtual = 0;
        }

        private void LigarMoto_CheckedChanged(object sender, EventArgs e) {
            subir.Enabled = true;
            descer.Enabled = true;
        }

        private void desligar_CheckedChanged(object sender, EventArgs e) {
            subir.Enabled = false;
            descer.Enabled = false;
            marchaAtual.Text = Convert.ToString(Motoo.MarchaAtual);
            Motoo.MarchaAtual = 0;
            
        }

        

    }
}
