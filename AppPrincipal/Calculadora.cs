using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace AppPrincipal
{
    public partial class Calculadora : Form
    {
        public string num, operador;
        public bool EstadoTxtResul;

        public Calculadora()
        {
            InitializeComponent();
            num = "";
            T_resultado.ReadOnly = true;
            T_resultado.RightToLeft = RightToLeft.Yes;
        }

        private void Calculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            App A = new App();
            A.Show();
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            if (EstadoTxtResul == true)
            {
                T_resultado.Text += Bt1.Text;
                LbAux.Text += Bt1.Text;
            }
            else
            {
                T_resultado.Text = Bt1.Text;
                EstadoTxtResul = true;
                LbAux.Text += Bt1.Text;
            }
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            if (EstadoTxtResul == true)
            {
                T_resultado.Text += Bt2.Text;
                LbAux.Text += Bt2.Text;
            }
            else
            {
                T_resultado.Text = Bt2.Text;
                EstadoTxtResul = true;
                LbAux.Text += Bt2.Text;
            }
        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            if (EstadoTxtResul == true)
            {
                T_resultado.Text += Bt3.Text;
                LbAux.Text += Bt3.Text;
            }
            else
            {
                T_resultado.Text = Bt3.Text;
                EstadoTxtResul = true;
                LbAux.Text += Bt3.Text;
            }
        }

        private void Bt4_Click(object sender, EventArgs e)
        {
            if (EstadoTxtResul == true)
            {
                T_resultado.Text += Bt4.Text;
                LbAux.Text += Bt4.Text;
            }
            else
            {
                T_resultado.Text = Bt4.Text;
                EstadoTxtResul = true;
                LbAux.Text += Bt4.Text;
            }
        }

        private void Bt5_Click(object sender, EventArgs e)
        {
            if (EstadoTxtResul == true)
            {
                T_resultado.Text += Bt5.Text;
                LbAux.Text += Bt5.Text;
            }
            else
            {
                T_resultado.Text = Bt5.Text;
                EstadoTxtResul = true;
                LbAux.Text += Bt5.Text;
            }
        }

        private void Bt6_Click(object sender, EventArgs e)
        {
            if (EstadoTxtResul == true)
            {
                T_resultado.Text += Bt6.Text;
                LbAux.Text += Bt6.Text;
            }
            else
            {
                T_resultado.Text = Bt6.Text;
                EstadoTxtResul = true;
                LbAux.Text += Bt6.Text;
            }
        }

        private void Bt7_Click(object sender, EventArgs e)
        {
            if (EstadoTxtResul == true)
            {
                T_resultado.Text += Bt7.Text;
                LbAux.Text += Bt7.Text;
            }
            else
            {
                T_resultado.Text = Bt7.Text;
                EstadoTxtResul = true;
                LbAux.Text += Bt7.Text;
            }
        }

        private void Bt8_Click(object sender, EventArgs e)
        {
            if (EstadoTxtResul == true)
            {
                T_resultado.Text += Bt8.Text;
                LbAux.Text += Bt8.Text;
            }
            else
            {
                T_resultado.Text = Bt8.Text;
                EstadoTxtResul = true;
                LbAux.Text += Bt8.Text;
            }
        }

        private void Bt9_Click(object sender, EventArgs e)
        {
            if (EstadoTxtResul == true)
            {
                T_resultado.Text += Bt9.Text;
                LbAux.Text += Bt9.Text;
            }
            else
            {
                T_resultado.Text = Bt9.Text;
                EstadoTxtResul = true;
                LbAux.Text += Bt9.Text;
            }
        }


        private void BtVirgula_Click(object sender, EventArgs e)
        {
            if (EstadoTxtResul == true)
            {
                T_resultado.Text += BtVirgula.Text;
                LbAux.Text += BtVirgula.Text;
            }
            else
            {
                T_resultado.Text = BtVirgula.Text;
                EstadoTxtResul = true;
                LbAux.Text += BtVirgula.Text;
            }
        }
        private void Bt0_Click(object sender, EventArgs e)
        {
            if (EstadoTxtResul == true)
            {
                T_resultado.Text += Bt0.Text;
                LbAux.Text += Bt0.Text;
            }
            else
            {
                T_resultado.Text = Bt0.Text;
                EstadoTxtResul = true;
                LbAux.Text += Bt0.Text;
            }
        }
        private void BtFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_soma_Click(object sender, EventArgs e)
        {
            num = T_resultado.Text;
            T_resultado.Text = "";
            operador = "+";
            LbAux.Text += btn_soma.Text;
        }
        private void btn_sub_Click(object sender, EventArgs e)
        {
            num = T_resultado.Text;
            T_resultado.Text = "";
            operador = "-";
            LbAux.Text += btn_sub.Text;
        }
        private void btn_mul_Click(object sender, EventArgs e)
        {
            num = T_resultado.Text;
            T_resultado.Text = "";
            operador = "x";
            LbAux.Text += btn_mul.Text;
        }
        private void btn_div_Click(object sender, EventArgs e)
        {
            num = T_resultado.Text;
            T_resultado.Text = "";
            operador = "/";
            LbAux.Text += btn_div.Text;
        }
        private void BtRestoDaDivisao_Click(object sender, EventArgs e)
        {
            num = T_resultado.Text;
            T_resultado.Text = "";
            operador = "%";
            LbAux.Text += BtRestoDaDivisao.Text;
        }
        private void btnPot_Click(object sender, EventArgs e)
        {
            num = T_resultado.Text;
            T_resultado.Text = "";
            operador = "^";
            LbAux.Text += btnPot.Text;
        }

        private void calculos()
        {
            switch (operador)
            {
                case "+":
                    T_resultado.Text = Convert.ToString(Convert.ToDouble(num) + Convert.ToDouble(T_resultado.Text));
                    break;
                case "-":
                    T_resultado.Text = Convert.ToString(Convert.ToDouble(num) - Convert.ToDouble(T_resultado.Text));
                    break;
                case "x":
                    T_resultado.Text = Convert.ToString(Convert.ToDouble(num) * Convert.ToDouble(T_resultado.Text));
                    break;
                case "/":
                    if (T_resultado.Text == "0")
                        T_resultado.Text = "infinito";
                    else
                        T_resultado.Text = Convert.ToString(Convert.ToDouble(num) / Convert.ToDouble(T_resultado.Text));
                    break;
                case "^":
                    T_resultado.Text = Convert.ToString(Math.Pow(Convert.ToDouble(num), Convert.ToDouble(T_resultado.Text)));
                    break;
                case "%":
                    T_resultado.Text = Convert.ToString((Convert.ToDouble(num) % Convert.ToDouble(T_resultado.Text)));
                    break;
                default: MessageBox.Show("Operador Inválido!"); break;
            }
        }
        private void btn_igual_Click(object sender, EventArgs e)
        {
            calculos();
            EstadoTxtResul = false;
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            T_resultado.Text = String.Empty;
            EstadoTxtResul = true;
        }
        private void Bt5Raiz_Click(object sender, EventArgs e)
        {
            T_resultado.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(T_resultado.Text)));
            LbAux.Text = Bt5Raiz.Text;
            EstadoTxtResul = false;
        }
        private void btnPI_Click(object sender, EventArgs e)
        {
            T_resultado.Text = "3.141592654";
        }
        private void btnsen_Click(object sender, EventArgs e)
        {
            T_resultado.Text = Convert.ToString(Math.Sin((Convert.ToDouble(Math.PI) / 180) * (Convert.ToDouble(T_resultado.Text))));
            EstadoTxtResul = false;
        }
        private void Btncose_Click(object sender, EventArgs e)
        {
            T_resultado.Text = Convert.ToString(Math.Cos((Convert.ToDouble(Math.PI) / 180) * (Convert.ToDouble(T_resultado.Text))));
            EstadoTxtResul = false;
        }
        private void Btntan_Click(object sender, EventArgs e)
        {
            T_resultado.Text = Convert.ToString(Math.Tan((Convert.ToDouble(Math.PI) / 180) * (Convert.ToDouble(T_resultado.Text))));
            EstadoTxtResul = false;
        }
        private void btn1P2_Click(object sender, EventArgs e)
        {
            T_resultado.Text = Convert.ToString(Convert.ToDouble(1.0 / Convert.ToDouble(T_resultado.Text)));
            EstadoTxtResul = false;
        }
        private void btnlog_Click(object sender, EventArgs e)
        {
            T_resultado.Text = Convert.ToString(Math.Log(Convert.ToDouble(T_resultado.Text)));
            EstadoTxtResul = false;
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            num = T_resultado.Text;
            int n = num.Length;
            T_resultado.Text = String.Empty;
            LbAux.Text = String.Empty;
        }
        private void btnmaisoumenos_Click(object sender, EventArgs e)
        {
            T_resultado.Text = Convert.ToString(Convert.ToInt32(T_resultado.Text));
            EstadoTxtResul = false;
        }
        private void btnVabs_Click(object sender, EventArgs e)
        {
            T_resultado.Text = Convert.ToString(Math.Abs(Convert.ToDouble(T_resultado.Text)));
            EstadoTxtResul = false;
        }
        private void btnExp_Click(object sender, EventArgs e)
        {
            T_resultado.Text = Convert.ToString(Math.Exp(Convert.ToDouble(T_resultado.Text)));
            EstadoTxtResul = false;
        }
        private void btnRound_Click(object sender, EventArgs e)
        {
            T_resultado.Text = Convert.ToString(Math.Round(Convert.ToDouble(T_resultado.Text)));
            EstadoTxtResul = false;
        }
        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
