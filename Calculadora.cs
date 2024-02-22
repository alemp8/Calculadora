using System.Drawing;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        double num1;
        double num2;
        string operacion;

        private void btn1_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "1";
        }

        private void tbResultado_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyValue.ToString());
            //MessageBox.Show(e.KeyCode.ToString());
            if (e.KeyValue == 49)
            {
                btn1.BackColor = Color.Indigo;
                btn1.ForeColor = Color.White;
            }
            else if (e.KeyCode == Keys.D2)
            {
                btn2.BackColor = Color.Indigo;
                btn2.ForeColor = Color.White;
            }
            else if (e.KeyCode == Keys.D3)
            {
                btn3.BackColor = Color.Indigo;
                btn3.ForeColor = Color.White;
            }
            else if (e.KeyCode == Keys.D4)
            {
                btn4.BackColor = Color.Indigo;
                btn4.ForeColor = Color.White;
            }
            else if (e.KeyCode == Keys.D5)
            {
                btn5.BackColor = Color.Indigo;
                btn5.ForeColor = Color.White;
            }
            else if (e.KeyCode == Keys.D6)
            {
                btn6.BackColor = Color.Indigo;
                btn6.ForeColor = Color.White;
            }
            else if (e.KeyCode == Keys.D7)
            {
                btn7.BackColor = Color.Indigo;
                btn7.ForeColor = Color.White;
            }
            else if (e.KeyCode == Keys.D8)
            {
                btn8.BackColor = Color.Indigo;
                btn8.ForeColor = Color.White;
            }
            else if (e.KeyCode == Keys.D9)
            {
                btn9.BackColor = Color.Indigo;
                btn9.ForeColor = Color.White;
            }
            else if (e.KeyCode == Keys.D0)
            {
                btn0.BackColor = Color.Indigo;
                btn0.ForeColor = Color.White;
            }
        }

        private void tbResultado_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 49)
            {
                btn1.BackColor = Color.MediumSlateBlue;
                btn1.ForeColor = Color.Navy;
            }
            else if (e.KeyCode == Keys.D2)
            {
                btn2.BackColor = Color.MediumSlateBlue;
                btn2.ForeColor = Color.Navy;
            }
            else if (e.KeyCode == Keys.D3)
            {
                btn3.BackColor = Color.MediumSlateBlue;
                btn3.ForeColor = Color.Navy;
            }
            else if (e.KeyCode == Keys.D4)
            {
                btn4.BackColor = Color.MediumSlateBlue;
                btn4.ForeColor = Color.Navy;
            }
            else if (e.KeyCode == Keys.D5)
            {
                btn5.BackColor = Color.MediumSlateBlue;
                btn5.ForeColor = Color.Navy;
            }
            else if (e.KeyCode == Keys.D6)
            {
                btn6.BackColor = Color.MediumSlateBlue;
                btn6.ForeColor = Color.Navy;
            }
            else if (e.KeyCode == Keys.D7)
            {
                btn7.BackColor = Color.MediumSlateBlue;
                btn7.ForeColor = Color.Navy;
            }
            else if (e.KeyCode == Keys.D8)
            {
                btn8.BackColor = Color.MediumSlateBlue;
                btn8.ForeColor = Color.Navy;
            }
            else if (e.KeyCode == Keys.D9)
            {
                btn9.BackColor = Color.MediumSlateBlue;
                btn9.ForeColor = Color.Navy;
            }
            else if (e.KeyCode == Keys.D0)
            {
                btn0.BackColor = Color.MediumSlateBlue;
                btn0.ForeColor = Color.Navy;
            }
        }

        private void btn1_MouseDown(object sender, MouseEventArgs e)
        {
            btn1.BackColor = Color.Indigo;
            btn1.ForeColor = Color.White;
        }

        private void btn1_MouseUp(object sender, MouseEventArgs e)
        {
            btn1.BackColor = Color.MediumSlateBlue;
            btn1.ForeColor = Color.Navy;
        }

        private void btn2_MouseDown(object sender, MouseEventArgs e)
        {
            btn2.BackColor = Color.Indigo;
            btn2.ForeColor = Color.White;
        }

        private void btn2_MouseUp(object sender, MouseEventArgs e)
        {
            btn2.BackColor = Color.MediumSlateBlue;
            btn2.ForeColor = Color.Navy;
        }

        private void btn3_MouseDown(object sender, MouseEventArgs e)
        {
            btn3.BackColor = Color.Indigo;
            btn3.ForeColor = Color.White;
        }

        private void btn3_MouseUp(object sender, MouseEventArgs e)
        {
            btn3.BackColor = Color.MediumSlateBlue;
            btn3.ForeColor = Color.Navy;
        }

        private void btn4_MouseDown(object sender, MouseEventArgs e)
        {
            btn4.BackColor = Color.Indigo;
            btn4.ForeColor = Color.White;
        }

        private void btn4_MouseUp(object sender, MouseEventArgs e)
        {
            btn4.BackColor = Color.MediumSlateBlue;
            btn4.ForeColor = Color.Navy;
        }

        private void btn5_MouseDown(object sender, MouseEventArgs e)
        {
            btn5.BackColor = Color.Indigo;
            btn5.ForeColor = Color.White;
        }

        private void btn5_MouseUp(object sender, MouseEventArgs e)
        {
            btn5.BackColor = Color.MediumSlateBlue;
            btn5.ForeColor = Color.Navy;
        }

        private void btn6_MouseDown(object sender, MouseEventArgs e)
        {
            btn6.BackColor = Color.Indigo;
            btn6.ForeColor = Color.White;
        }

        private void btn6_MouseUp(object sender, MouseEventArgs e)
        {
            btn6.BackColor = Color.MediumSlateBlue;
            btn6.ForeColor = Color.Navy;
        }

        private void btn7_MouseDown(object sender, MouseEventArgs e)
        {
            btn7.BackColor = Color.Indigo;
            btn7.ForeColor = Color.White;
        }

        private void btn7_MouseUp(object sender, MouseEventArgs e)
        {
            btn7.BackColor = Color.MediumSlateBlue;
            btn7.ForeColor = Color.Navy;
        }

        private void btn8_MouseDown(object sender, MouseEventArgs e)
        {
            btn8.BackColor = Color.Indigo;
            btn8.ForeColor = Color.White;
        }

        private void btn8_MouseUp(object sender, MouseEventArgs e)
        {
            btn8.BackColor = Color.MediumSlateBlue;
            btn8.ForeColor = Color.Navy;
        }

        private void btn9_MouseDown(object sender, MouseEventArgs e)
        {
            btn9.BackColor = Color.Indigo;
            btn9.ForeColor = Color.White;
        }

        private void btn9_MouseUp(object sender, MouseEventArgs e)
        {
            btn9.BackColor = Color.MediumSlateBlue;
            btn9.ForeColor = Color.Navy;
        }

        private void btn0_MouseDown(object sender, MouseEventArgs e)
        {
            btn0.BackColor = Color.Indigo;
            btn0.ForeColor = Color.White;
        }

        private void btn0_MouseUp(object sender, MouseEventArgs e)
        {
            btn0.BackColor = Color.MediumSlateBlue;
            btn0.ForeColor = Color.Navy;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbResultado.Text += "0";
        }

        private void tbResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // MessageBox.Show(e.KeyChar.ToString());
            /* if (e.KeyChar < 48 || e.KeyChar > 57)
             {
                 MessageBox.Show("Ingrese solamente dígitos");
                 e.Handled = true;
                 return;
             }*/
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbResultado.Text = "0";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(this.tbResultado.Text);
            operacion = "+";
            this.tbResultado.Clear();
            this.tbResultado.Focus();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(this.tbResultado.Text);
            switch (operacion)
            {
                case "+": this.tbResultado.Text = Convert.ToString(num1 + num2); break;
                case "-": this.tbResultado.Text = Convert.ToString(num1 - num2); break;
                case "x": this.tbResultado.Text = Convert.ToString(num1 * num2); break;
                case "/": this.tbResultado.Text = Convert.ToString(num1 / num2); break;
               // case "%": this.tbResultado.Text = Convert.ToString(num2 / 100); break;
            }

        }


        private void btnResta_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(this.tbResultado.Text);
            operacion = "-";
            this.tbResultado.Clear();
            this.tbResultado.Focus();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(this.tbResultado.Text);
            operacion = "x";
            this.tbResultado.Clear();
            this.tbResultado.Focus();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(this.tbResultado.Text);
            operacion = "/";
            this.tbResultado.Clear();
            this.tbResultado.Focus();
        }

       

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (this.tbResultado.Text.Contains(',') == false)
            {
                this.tbResultado.Text = this.tbResultado.Text += ",";
            }
        }
    }
} 
 