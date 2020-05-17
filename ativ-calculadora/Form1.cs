using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ativ_calculadora
{
    public partial class frm_calculadora : Form
    {
        double valor1, valor2; //declaração de variaveis
        
        Calculadora calc = new Calculadora(); //chamada da classe Calculadora

        public void recebedados() //metodo criado para não ocorrer o excesso de repetições
        {
            if (txt_Valor1.Text == "" || txt_Valor2.Text == "")//verificar se a textbox está vazia
            {
                MessageBox.Show("Insira números para calcular!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Valor1.Focus();
            }else
            {
                valor1 = Convert.ToDouble(txt_Valor1.Text);
                valor2 = Convert.ToDouble(txt_Valor2.Text);
            }

        }

        public frm_calculadora()
        {
            InitializeComponent();
        }

        private void btn_Soma_Click(object sender, EventArgs e)
        {

            recebedados(); //chamada do metodo
           
            txt_Resultado.Text = calc.Somar(valor1, valor2).ToString();

            txt_Valor1.Clear();
            txt_Valor2.Clear();
        }

        private void btn_Subtrair_Click(object sender, EventArgs e)
        {
            recebedados();

            txt_Resultado.Text = calc.Subtrair(valor1, valor2).ToString();

            txt_Valor1.Clear();
            txt_Valor2.Clear();
        }

        private void btn_Multiplicar_Click(object sender, EventArgs e)
        {
            recebedados();

            txt_Resultado.Text = calc.Multiplicar(valor1, valor2).ToString();

            txt_Valor1.Clear();
            txt_Valor2.Clear();
        }

        private void btn_Dividir_Click(object sender, EventArgs e)
        {
            recebedados();

            txt_Resultado.Text = calc.Dividir(valor1, valor2).ToString();

            txt_Valor1.Clear();
            txt_Valor2.Clear();
        }

        private void txt_Valor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08) //não permite que digite texto no lugar de numero
            {
                e.Handled = true;
            }
        }

        private void txt_Valor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar !=08) //não permite que digite texto no lugar de numero
            {
                e.Handled = true;
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
