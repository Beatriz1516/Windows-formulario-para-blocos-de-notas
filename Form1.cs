using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace formulario_de_cadastro
{
    public partial class CADASTRO : Form
    {
        public CADASTRO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxnome_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                Nome = boxnome_txt.Text,
                CPF = boxcpf_txt.Text,
                Email = boxemail_txt.Text,
                Telefone = boxtelefone_txt.Text,
                Endereco = boxendereco_txt.Text,
                CEP = boxcep_txt.Text,
                Estado = boxestado_txt.Text,
                Cidade = boxcidade_txt.Text
            };

            string json = JsonSerializer.Serialize(cliente);

            MessageBox.Show(json);
            
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
