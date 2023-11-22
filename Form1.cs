using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_10_part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] verificador = new int[1000];
        int sorteado, inicial, final, limite, i, x;
        String resultado = "";
        Random r = new Random();

        private void btngerar_Click(object sender, EventArgs e)
        {
            inicial = Convert.ToInt32(textBox1.Text);
            final = Convert.ToInt32(textBox2.Text);
            limite = Convert.ToInt32(textBox3.Text);

            if (limite > final)
            {
                MessageBox.Show("Favor verifique o limite", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox3.Clear();
                textBox3.Focus();
            }
            else
            {
                for (i = 0; i < limite; i++)
                {
                //Fazendo uma referência para voltar a esse ponto
                inicio:
                    sorteado = r.Next(inicial, final + 1);
                    for (x = 0; x <= limite - 1; x++)
                    {
                        if (verificador[x] == sorteado)
                        {
                            goto inicio;
                        }
                    }
                    resultado = resultado + "  " + sorteado;
                    label4.Text = resultado;
                    listBox1.Items.Add(sorteado.ToString());
                    verificador[i] = sorteado;
                }
            }
        }
    }
}
