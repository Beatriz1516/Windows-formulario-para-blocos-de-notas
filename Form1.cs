using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace Projeto_de_formulário_para_um_bloco_de_notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Cliente = new Cliente
            {
                Nome = NOME_TXT.Text,
                CPF = CPF_TXT.Text,
                Telefone = TELEFONE_TXT.Text,
                Email = EMAIL_TXT.Text,
                Endereco = ENDEREÇO_TXT.Text,
                CEP = CEP_TXT.Text,
                Estado = ESTADO_TXT.Text
            };  

            try
            {

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TELEFONE_TXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void CPF_TXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
