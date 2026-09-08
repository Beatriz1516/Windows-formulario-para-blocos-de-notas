namespace formulario_de_cadastro
{
    partial class CADASTRO
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.nome_txt = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.Label();
            this.boxnome_txt = new System.Windows.Forms.TextBox();
            this.boxemail_txt = new System.Windows.Forms.TextBox();
            this.boxcpf_txt = new System.Windows.Forms.TextBox();
            this.boxtelefone_txt = new System.Windows.Forms.TextBox();
            this.cpf_txt = new System.Windows.Forms.Label();
            this.telefone_txt = new System.Windows.Forms.Label();
            this.boxcep_txt = new System.Windows.Forms.TextBox();
            this.boxestado_txt = new System.Windows.Forms.TextBox();
            this.cep_txt = new System.Windows.Forms.Label();
            this.estado_txt = new System.Windows.Forms.Label();
            this.boxendereco_txt = new System.Windows.Forms.TextBox();
            this.endereco_txt = new System.Windows.Forms.Label();
            this.cidade_txt = new System.Windows.Forms.Label();
            this.boxcidade_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(239, 338);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(163, 51);
            this.btnsalvar.TabIndex = 0;
            this.btnsalvar.Text = "&SALVAR";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(619, 338);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(163, 51);
            this.btnfechar.TabIndex = 9;
            this.btnfechar.Text = "&FECHAR";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // nome_txt
            // 
            this.nome_txt.AutoSize = true;
            this.nome_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_txt.Location = new System.Drawing.Point(39, 50);
            this.nome_txt.Name = "nome_txt";
            this.nome_txt.Size = new System.Drawing.Size(98, 29);
            this.nome_txt.TabIndex = 10;
            this.nome_txt.Text = "NOME: ";
            this.nome_txt.Click += new System.EventHandler(this.label1_Click);
            // 
            // email_txt
            // 
            this.email_txt.AutoSize = true;
            this.email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(38, 113);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(95, 29);
            this.email_txt.TabIndex = 12;
            this.email_txt.Text = "EMAIL: ";
            this.email_txt.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // boxnome_txt
            // 
            this.boxnome_txt.Location = new System.Drawing.Point(143, 50);
            this.boxnome_txt.Multiline = true;
            this.boxnome_txt.Name = "boxnome_txt";
            this.boxnome_txt.Size = new System.Drawing.Size(490, 29);
            this.boxnome_txt.TabIndex = 1;
            this.boxnome_txt.TextChanged += new System.EventHandler(this.boxnome_txt_TextChanged);
            // 
            // boxemail_txt
            // 
            this.boxemail_txt.Location = new System.Drawing.Point(143, 113);
            this.boxemail_txt.Multiline = true;
            this.boxemail_txt.Name = "boxemail_txt";
            this.boxemail_txt.Size = new System.Drawing.Size(329, 29);
            this.boxemail_txt.TabIndex = 3;
            // 
            // boxcpf_txt
            // 
            this.boxcpf_txt.Location = new System.Drawing.Point(749, 50);
            this.boxcpf_txt.Multiline = true;
            this.boxcpf_txt.Name = "boxcpf_txt";
            this.boxcpf_txt.Size = new System.Drawing.Size(241, 29);
            this.boxcpf_txt.TabIndex = 2;
            this.boxcpf_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // boxtelefone_txt
            // 
            this.boxtelefone_txt.Location = new System.Drawing.Point(661, 113);
            this.boxtelefone_txt.Multiline = true;
            this.boxtelefone_txt.Name = "boxtelefone_txt";
            this.boxtelefone_txt.Size = new System.Drawing.Size(329, 29);
            this.boxtelefone_txt.TabIndex = 4;
            this.boxtelefone_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cpf_txt
            // 
            this.cpf_txt.AutoSize = true;
            this.cpf_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf_txt.Location = new System.Drawing.Point(660, 50);
            this.cpf_txt.Name = "cpf_txt";
            this.cpf_txt.Size = new System.Drawing.Size(73, 29);
            this.cpf_txt.TabIndex = 11;
            this.cpf_txt.Text = "CPF: ";
            this.cpf_txt.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // telefone_txt
            // 
            this.telefone_txt.AutoSize = true;
            this.telefone_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone_txt.Location = new System.Drawing.Point(510, 113);
            this.telefone_txt.Name = "telefone_txt";
            this.telefone_txt.Size = new System.Drawing.Size(154, 29);
            this.telefone_txt.TabIndex = 13;
            this.telefone_txt.Text = "TELEFONE: ";
            this.telefone_txt.Click += new System.EventHandler(this.label2_Click);
            // 
            // boxcep_txt
            // 
            this.boxcep_txt.Location = new System.Drawing.Point(749, 184);
            this.boxcep_txt.Multiline = true;
            this.boxcep_txt.Name = "boxcep_txt";
            this.boxcep_txt.Size = new System.Drawing.Size(241, 29);
            this.boxcep_txt.TabIndex = 6;
            this.boxcep_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // boxestado_txt
            // 
            this.boxestado_txt.Location = new System.Drawing.Point(205, 258);
            this.boxestado_txt.Multiline = true;
            this.boxestado_txt.Name = "boxestado_txt";
            this.boxestado_txt.Size = new System.Drawing.Size(84, 29);
            this.boxestado_txt.TabIndex = 7;
            this.boxestado_txt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cep_txt
            // 
            this.cep_txt.AutoSize = true;
            this.cep_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cep_txt.Location = new System.Drawing.Point(660, 184);
            this.cep_txt.Name = "cep_txt";
            this.cep_txt.Size = new System.Drawing.Size(74, 29);
            this.cep_txt.TabIndex = 15;
            this.cep_txt.Text = "CEP: ";
            this.cep_txt.Click += new System.EventHandler(this.label3_Click);
            // 
            // estado_txt
            // 
            this.estado_txt.AutoSize = true;
            this.estado_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_txt.Location = new System.Drawing.Point(40, 258);
            this.estado_txt.Name = "estado_txt";
            this.estado_txt.Size = new System.Drawing.Size(124, 29);
            this.estado_txt.TabIndex = 16;
            this.estado_txt.Text = "ESTADO: ";
            this.estado_txt.Click += new System.EventHandler(this.label4_Click);
            // 
            // boxendereco_txt
            // 
            this.boxendereco_txt.Location = new System.Drawing.Point(205, 184);
            this.boxendereco_txt.Multiline = true;
            this.boxendereco_txt.Name = "boxendereco_txt";
            this.boxendereco_txt.Size = new System.Drawing.Size(428, 29);
            this.boxendereco_txt.TabIndex = 5;
            this.boxendereco_txt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // endereco_txt
            // 
            this.endereco_txt.AutoSize = true;
            this.endereco_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco_txt.Location = new System.Drawing.Point(38, 184);
            this.endereco_txt.Name = "endereco_txt";
            this.endereco_txt.Size = new System.Drawing.Size(161, 29);
            this.endereco_txt.TabIndex = 14;
            this.endereco_txt.Text = "ENDEREÇO: ";
            this.endereco_txt.Click += new System.EventHandler(this.label5_Click);
            // 
            // cidade_txt
            // 
            this.cidade_txt.AutoSize = true;
            this.cidade_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidade_txt.Location = new System.Drawing.Point(316, 258);
            this.cidade_txt.Name = "cidade_txt";
            this.cidade_txt.Size = new System.Drawing.Size(113, 29);
            this.cidade_txt.TabIndex = 17;
            this.cidade_txt.Text = "CIDADE: ";
            this.cidade_txt.Click += new System.EventHandler(this.label6_Click);
            // 
            // boxcidade_txt
            // 
            this.boxcidade_txt.Location = new System.Drawing.Point(448, 258);
            this.boxcidade_txt.Multiline = true;
            this.boxcidade_txt.Name = "boxcidade_txt";
            this.boxcidade_txt.Size = new System.Drawing.Size(542, 29);
            this.boxcidade_txt.TabIndex = 8;
            // 
            // CADASTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1021, 452);
            this.Controls.Add(this.boxcidade_txt);
            this.Controls.Add(this.cidade_txt);
            this.Controls.Add(this.boxcep_txt);
            this.Controls.Add(this.boxestado_txt);
            this.Controls.Add(this.cep_txt);
            this.Controls.Add(this.estado_txt);
            this.Controls.Add(this.boxendereco_txt);
            this.Controls.Add(this.endereco_txt);
            this.Controls.Add(this.boxcpf_txt);
            this.Controls.Add(this.boxtelefone_txt);
            this.Controls.Add(this.cpf_txt);
            this.Controls.Add(this.telefone_txt);
            this.Controls.Add(this.boxemail_txt);
            this.Controls.Add(this.boxnome_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.nome_txt);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnsalvar);
            this.Name = "CADASTRO";
            this.Text = "FICHA DE CADASTRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Label nome_txt;
        private System.Windows.Forms.Label email_txt;
        private System.Windows.Forms.TextBox boxnome_txt;
        private System.Windows.Forms.TextBox boxemail_txt;
        private System.Windows.Forms.TextBox boxcpf_txt;
        private System.Windows.Forms.TextBox boxtelefone_txt;
        private System.Windows.Forms.Label cpf_txt;
        private System.Windows.Forms.Label telefone_txt;
        private System.Windows.Forms.TextBox boxcep_txt;
        private System.Windows.Forms.TextBox boxestado_txt;
        private System.Windows.Forms.Label cep_txt;
        private System.Windows.Forms.Label estado_txt;
        private System.Windows.Forms.TextBox boxendereco_txt;
        private System.Windows.Forms.Label endereco_txt;
        private System.Windows.Forms.Label cidade_txt;
        private System.Windows.Forms.TextBox boxcidade_txt;
    }
}

