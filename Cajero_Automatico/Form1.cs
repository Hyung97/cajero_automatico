using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero_Automatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double[] demonimaciones = { 100, 50, 20, 10, 5, 1, 0.50, 0.25, 0.10, 0.05, 0.01 };
            double cantidad = double.Parse(txtCantifdad.Text);
            sbyte N = 0;
            string answer = "RESPUESTA:\n ";
            foreach (double denominacion in demonimaciones)
            {
                while (denominacion <= Math.Round(cantidad, 2))
                {
                    N++;
                    cantidad -= denominacion;
                }
                if (N > 0)
                {
                    answer += N + (denominacion > 1 ? " BILLETES DE " : " MONEDAS DE ") + denominacion + "\n";
                }
                N = 0;
            }
            lblAnswer.Text = answer;

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //LA SUCESION FIBONACCI ES LA SIGUIENTE SUCESION INFINITA DE NUMEROS NATURALES
        //LA SUCESION COMIENZA CON LOS NUMEROS 0 Y 1
        //A PARTIR DE ESTOS, CADA TERMINO ES LA SUMA DE LOS DOS ANTERIORES
        //ES LA RELACION DE RECURRENCIA QUE LA DEFINE
        private void btnFibo_Click(object sender, EventArgs e)
        {
            int N = int.Parse(txtFibonacci.Text), A = 0, B = 1, SM, i;
            string Answer1 = "";
            for (i = 0; i < N; i++)
            {
                SM = A;
                A = B;
                B = SM + A;
                Answer1 += "LA SUMATORIA DE  " + A + " ES " + B + "\n";
                lblFibonacci.Visible = true;
                lblFibonacci.Text = "" + Answer1;
                txtFibonacci.Text = "";
            }
        }
        //EL NUMERO PRIMO ES UN NUMERO ENTERO QUE SOLAMENTE ES DIVISIBLE POR EL MISMO 
        //Y POR LA UNIDAD 
        private void btnPrimo_Click(object sender, EventArgs e)
        {
            int A = 0, I, N;
            N = int.Parse(txtPrimo.Text);
            A = 0;
            for (I = 1; I < (N + 1); I++)
                if (N % I == 0)
                    A++;
            lblPrimoResp.Text = ((A != 2) ? N + " NO ES UN NUMERO PRIMO " : N + "  SI ES UN NUMERO PRIMO" + "\n");
        }

        private void btnPago1_Click(object sender, EventArgs e)
        {
            double EfetivoEntregado = double.Parse(txtMoney.Text), Pagar = double.Parse(txtPagar.Text), TotalACancelar;
            double Answrs = 0;
            
          //  double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
          //  sbyte X = 0;
          //  foreach (double denominacion in denominaciones)
            {
           //    while (denominacion <= Math.Round(EfetivoEntregado, 2))
                {
           //     X++;
            //   EfetivoEntregado -= denominacion;
                }
                {
            //    if (X>0)
                    {
                        Answrs = EfetivoEntregado - Pagar;
                        TotalACancelar = Answrs;
                        lblDevolucion.Text = "DINERO A DEVOLVER: " + TotalACancelar;

                    }
                }
            }
        }
    }
}
