using System.Diagnostics.CodeAnalysis;

namespace CalculadoraWinApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e) {
            tbox.AppendText("0");
        }

        private void btn1_Click(object sender, EventArgs e) {
            tbox.AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e) {
            tbox.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e) {
            tbox.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e) {
            tbox.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e) {
            tbox.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e) {
            tbox.AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e) {
            tbox.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e) {
            tbox.AppendText("8");
        }

        private void btn9_Click(object sender, EventArgs e) {
            tbox.AppendText("9");
        }

        private void btnDiv_Click(object sender, EventArgs e) {
            tbox.AppendText(" / ");
        }

        private void btnVezes_Click(object sender, EventArgs e) {
            tbox.AppendText(" * ");
        }

        private void btnMenos_Click(object sender, EventArgs e) {
            tbox.AppendText(" - ");
        }

        private void btnMais_Click(object sender, EventArgs e) {
            tbox.AppendText(" + ");
        }

        private void btnC_Click(object sender, EventArgs e) {
            tbox.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e) {
            tbox.AppendText(" = ");
            double resultado = FazerOperacao();
            string resultadoTela = Convert.ToString(resultado);
            tbox.AppendText(resultadoTela);
        }

        private double FazerOperacao() {
            double resultado =0;

            string[] numeros = tbox.Text.Split(' ');
            double num1 = Convert.ToDouble(numeros[0]);
            double num2 = Convert.ToDouble(numeros[2]);

            if (numeros[1]=="+") {
                resultado = num1 + num2;
            }
            else if (numeros[1] == "-") {
                resultado = num1 - num2;
            }
            else if (numeros[1] == "*") {
                resultado = num1 * num2;
            } 
            else if (numeros[1] == "/") {
                resultado = num1 / num2;
            }
            return resultado;
        }

        //private void RemoverSinal() {
        //    char[] caracteres = tbox.Text.ToCharArray();
        //    tbox.Text.Remove(caracteres[caracteres.Length]);
        //    tbox.Undo();
        //}

        //private void VerificarSinal() {
        //    if(tbox.Text.Contains("+") || tbox.Text.Contains("-") || tbox.Text.Contains("/") || tbox.Text.Contains("*")) {
                
        //    }
        //}


    }
}