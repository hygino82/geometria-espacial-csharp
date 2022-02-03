using GeometriaEspacial.Entidades;
using GeometriaEspacial.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometriaEspacial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBase.Items.Add("Circulo");
            comboBase.Items.Add("Triangulo Equilatero");
            comboBase.Items.Add("Quadrado");
            comboBase.Items.Add("Hexagono Regular");
            comboBase.SelectedIndex = 2;

            comboPoliedro.Items.Add("Prisma");
            comboPoliedro.Items.Add("Piramide");
            comboPoliedro.Items.Add("Tronco Piramide");
            comboPoliedro.SelectedIndex = 2;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtMaiorAresta.Text = "";
            txtMenorAresta.Text = "";
            comboPoliedro.SelectedIndex = 2;
            comboBase.SelectedIndex = 2;

        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            try
            {
                Poliedro poliedro;
                BasePoligono basePoligono;
                double arestaMaior = double.Parse(txtMaiorAresta.Text);
                double altura = double.Parse(txtAltura.Text);
                switch (comboBase.Text)
                {
                    case "Circulo":
                        basePoligono = BasePoligono.Circulo;
                        break;
                    case "Quadrado":
                        basePoligono = BasePoligono.Quadrado;
                        break;
                    case "Triangulo Equilatero":
                        basePoligono = BasePoligono.TrianguloEquilatero;
                        break;
                    default:
                        basePoligono = BasePoligono.HexagonoRegular;
                        break;
                }

                if (comboPoliedro.Text == "Prisma")
                {
                    poliedro = new Prisma(basePoligono, arestaMaior, altura);
                }
                else if (comboPoliedro.Text == "Piramide")
                {
                    poliedro = new Piramide(basePoligono, arestaMaior, altura);
                }
                else
                {
                    double arestaMenor = double.Parse(txtMenorAresta.Text);
                    poliedro = new TroncoPiramide(basePoligono, arestaMaior, altura, arestaMenor);
                }

                lista.Text = poliedro.ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void comboPoliedro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPoliedro.SelectedIndex == 2)
            {
                lbMenorAresta.Enabled = true;
                txtMenorAresta.Enabled = true;
                lbMenorAresta.Visible = true;
                txtMenorAresta.Visible = true;
            }
            else
            {
                lbMenorAresta.Enabled = false;
                txtMenorAresta.Enabled = false;
                lbMenorAresta.Visible = false;
                txtMenorAresta.Visible = false;
            }
        }
    }
}
