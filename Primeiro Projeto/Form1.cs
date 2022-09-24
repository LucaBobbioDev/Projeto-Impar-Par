using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primeiro_Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonVerificar_Click(object sender, EventArgs e)
        {
            //Declarando variável
            int num;

            //Convertendo o texto do input de string para tipo integer
            num = int.Parse(InputBox.Text);


            //If-Else que retorna se o número digitado é impar ou par
            if (num % 2 == 0)
            {
                MessageBox.Show("O número '" + num + "' é Par!");
            }
            else
            {
                MessageBox.Show("O número '" + num + "' é Ímpar!");
            }
        }

        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            //Limpa o input dde texto
            InputBox.Clear();
        }
    }
}
