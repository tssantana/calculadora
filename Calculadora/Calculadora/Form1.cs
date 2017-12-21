using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {

                var num1 = double.Parse(txNum1.Text);
                var num2 = double.Parse(txNum2.Text);

                var op = cbOper.SelectedIndex;

                string result;
                switch (op)
                {
                    case 0:
                        result = (num1 + num2).ToString();
                        break;
                    case 1:
                        result = (num1 - num2).ToString();
                        break;
                    case 2:
                        result = (num1 * num2).ToString();
                        break;
                    case 3:
                        if (num2 <= 0)
                        {
                            result = "Error";
                        }
                        else
                        {
                            result = (num1 / num2).ToString();
                        }
                        break;
                    default:
                        result = "Error";
                        break;
                }

                txResult.Text = result;
            }catch (Exception erro){
                MessageBox.Show("Parâmetros informados inválido","Erro!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
