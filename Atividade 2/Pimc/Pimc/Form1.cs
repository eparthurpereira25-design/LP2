using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pimc
{
    public partial class Form1 : Form
    {
        double peso, altura, IMC;



        public Form1()
        {
            InitializeComponent();
            peso = 0;
            altura = 0;
            IMC = 0;
        }

        private void maskPeso_Validated(object sender, EventArgs e)
        {
            if (this.ActiveControl == btSair)
            {
                return;
            }
            if (!double.TryParse(maskPeso.Text, out peso) || (peso <=0))
            {
                MessageBox.Show("Peso Invalido!!!");
                maskPeso.Focus();
            }
        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            IMC = peso / (altura * altura);
            IMC = Math.Round(IMC,1);
            maskIMC.Text = IMC.ToString();
            if (IMC < 18.5)
            {
                txtClassificacao.Text = "Magreza";
                txtObeso.Text = "O";
                MessageBox.Show("Classificação: " + txtClassificacao.Text + ". \nGrau de Obesidade: " +  txtObeso.Text);
            }
            else
            {
                if (IMC  >= 18.5 && IMC < 24.9)
                {
                    txtClassificacao.Text = "Normal";
                    txtObeso.Text = "O";
                    MessageBox.Show("Classificação: " + txtClassificacao.Text + ". \nGrau de Obesidade: " + txtObeso.Text);
                }
                else
                {
                    if (IMC >= 25 && IMC < 29.9)
                    {
                        txtClassificacao.Text = "Sobrepeso";
                        txtObeso.Text = "I";
                        MessageBox.Show("Classificação: " + txtClassificacao.Text + ". \nGrau de Obesidade: " + txtObeso.Text);
                    }
                    else
                    {
                        if (IMC >= 30 && IMC < 39.9)
                        {
                            txtClassificacao.Text = "Obesidade";
                            txtObeso.Text = "II";
                            MessageBox.Show("Classificação: " + txtClassificacao.Text + ". \nGrau de Obesidade: " + txtObeso.Text);
                        }
                        else
                        {
                            txtClassificacao.Text = "Obesidade Grave";
                            txtObeso.Text= "III";
                            MessageBox.Show("Classificação: " + txtClassificacao.Text + ". \nGrau de Obesidade: " + txtObeso.Text);
                        }
                    }
                }
            }
        }

        private void maskAltura_Validated(object sender, EventArgs e)
        {
            if (this.ActiveControl == btSair)
            {
                return;
            }
            if (!double.TryParse(maskAltura.Text, out altura) || (altura <= 0))
            {
                MessageBox.Show("Altura Invalido!!!");
                maskAltura.Focus();
            }
        }

        private void btLimp_Click(object sender, EventArgs e)
        {
            peso = 0;
            altura = 0;
            IMC = 0;
            maskAltura.Clear();
            maskIMC.Clear();
            maskPeso.Clear();
            txtClassificacao.Clear();
            txtObeso.Clear();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

       


    }
}
