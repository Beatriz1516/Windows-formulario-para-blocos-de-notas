using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace formulario_de_cadastro
{
    public partial class CADASTRO : Form
    {

        private readonly string caminhoArquivo = 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "cliente.json");
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

            JsonSerializerOptions opcoes = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(cliente, opcoes);

            MessageBox.Show(json);

            File.WriteAllText(caminhoArquivo, json);

            MessageBox.Show(
                $"cliente salvo com sucesso\narquivo:\n{caminhoArquivo}",
                $"salvar cliente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );


        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CADASTRO_Load(object sender, EventArgs e)
        {
            if (!File.Exists(caminhoArquivo))
            {
                return;
            }
            string json = File.ReadAllText(caminhoArquivo);

            Cliente cliente = JsonSerializer.Deserialize<Cliente>(json);

            if (cliente == null)
            {
                MessageBox.Show("Não foi possível ler os dados do cliente.");
                return;
            }

            boxnome_txt.Text = cliente.Nome;
            boxcpf_txt.Text = cliente.CPF;
            boxemail_txt.Text = cliente.Email;
            boxtelefone_txt.Text = cliente.Telefone;
            boxendereco_txt.Text = cliente.Endereco;
            boxcep_txt.Text = cliente.CEP;
            boxestado_txt.Text = cliente.Estado;
            boxcidade_txt.Text = cliente.Cidade;

        }
    }
}
