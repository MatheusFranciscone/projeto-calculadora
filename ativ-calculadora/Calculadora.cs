using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ativ_calculadora
{
    class Calculadora
    {        
        // método do tipo com parâmetro e com retorno
        public double Somar(double valor1, double valor2)
        {

            return valor1 + valor2;
          
        }

        public double Subtrair(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        public double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public double Dividir(double valor1, double valor2)
        {           
            if (valor1 == 0 || valor2 == 0) //Mensagem caso o valor seja dividido por 0
            {
                MessageBox.Show("Não pode dividir por 0!", "Atenção!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; 
            }
            else{

                return valor1 / valor2; 
            }


        }

    }
}
