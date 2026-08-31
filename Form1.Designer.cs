namespace Projeto_de_formulário_para_um_bloco_de_notas
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.NOME = new System.Windows.Forms.Label();
            this.NOME_TXT = new System.Windows.Forms.TextBox();
            this.CPF_TXT = new System.Windows.Forms.TextBox();
            this.CPF = new System.Windows.Forms.Label();
            this.TELEFONE_TXT = new System.Windows.Forms.TextBox();
            this.TELEFONE = new System.Windows.Forms.Label();
            this.ENDEREÇO_TXT = new System.Windows.Forms.TextBox();
            this.ENDERECO = new System.Windows.Forms.Label();
            this.EMAIL_TXT = new System.Windows.Forms.TextBox();
            this.EMAIL = new System.Windows.Forms.Label();
            this.BTN_SALVAR = new System.Windows.Forms.Button();
            this.BTN_FECHAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ESTADO_TXT = new System.Windows.Forms.TextBox();
            this.ESTADO = new System.Windows.Forms.Label();
            this.CEP_TXT = new System.Windows.Forms.TextBox();
            this.CEP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NOME
            // 
            this.NOME.AutoSize = true;
            this.NOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOME.Location = new System.Drawing.Point(200, 102);
            this.NOME.Name = "NOME";
            this.NOME.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NOME.Size = new System.Drawing.Size(81, 25);
            this.NOME.TabIndex = 1;
            this.NOME.Text = "Nome: ";
            this.NOME.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.NOME.Click += new System.EventHandler(this.label2_Click);
            // 
            // NOME_TXT
            // 
            this.NOME_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NOME_TXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NOME_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOME_TXT.ForeColor = System.Drawing.Color.DimGray;
            this.NOME_TXT.Location = new System.Drawing.Point(300, 98);
            this.NOME_TXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NOME_TXT.Name = "NOME_TXT";
            this.NOME_TXT.Size = new System.Drawing.Size(403, 30);
            this.NOME_TXT.TabIndex = 2;
            this.NOME_TXT.Text = "Digite seu nome...";
            this.NOME_TXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CPF_TXT
            // 
            this.CPF_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPF_TXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CPF_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF_TXT.ForeColor = System.Drawing.Color.DimGray;
            this.CPF_TXT.Location = new System.Drawing.Point(300, 158);
            this.CPF_TXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CPF_TXT.Name = "CPF_TXT";
            this.CPF_TXT.Size = new System.Drawing.Size(403, 30);
            this.CPF_TXT.TabIndex = 4;
            this.CPF_TXT.Text = "Digite seu CPF apenas com números...";
            this.CPF_TXT.TextChanged += new System.EventHandler(this.CPF_TXT_TextChanged);
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.Location = new System.Drawing.Point(213, 158);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(68, 25);
            this.CPF.TabIndex = 3;
            this.CPF.Text = "CPF: ";
            this.CPF.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CPF.Click += new System.EventHandler(this.label3_Click);
            // 
            // TELEFONE_TXT
            // 
            this.TELEFONE_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TELEFONE_TXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TELEFONE_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TELEFONE_TXT.ForeColor = System.Drawing.Color.DimGray;
            this.TELEFONE_TXT.Location = new System.Drawing.Point(300, 220);
            this.TELEFONE_TXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TELEFONE_TXT.Name = "TELEFONE_TXT";
            this.TELEFONE_TXT.Size = new System.Drawing.Size(403, 30);
            this.TELEFONE_TXT.TabIndex = 6;
            this.TELEFONE_TXT.Text = "Digite seu telefone apenas com números...";
            this.TELEFONE_TXT.TextChanged += new System.EventHandler(this.TELEFONE_TXT_TextChanged);
            // 
            // TELEFONE
            // 
            this.TELEFONE.AutoSize = true;
            this.TELEFONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TELEFONE.Location = new System.Drawing.Point(177, 220);
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.Size = new System.Drawing.Size(104, 25);
            this.TELEFONE.TabIndex = 5;
            this.TELEFONE.Text = "Telefone:";
            this.TELEFONE.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.TELEFONE.Click += new System.EventHandler(this.label4_Click);
            // 
            // ENDEREÇO_TXT
            // 
            this.ENDEREÇO_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ENDEREÇO_TXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ENDEREÇO_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENDEREÇO_TXT.ForeColor = System.Drawing.Color.DimGray;
            this.ENDEREÇO_TXT.Location = new System.Drawing.Point(300, 351);
            this.ENDEREÇO_TXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ENDEREÇO_TXT.Name = "ENDEREÇO_TXT";
            this.ENDEREÇO_TXT.Size = new System.Drawing.Size(403, 30);
            this.ENDEREÇO_TXT.TabIndex = 10;
            this.ENDEREÇO_TXT.Text = "Digite seu endereço...";
            this.ENDEREÇO_TXT.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ENDERECO
            // 
            this.ENDERECO.AutoSize = true;
            this.ENDERECO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENDERECO.Location = new System.Drawing.Point(164, 354);
            this.ENDERECO.Name = "ENDERECO";
            this.ENDERECO.Size = new System.Drawing.Size(117, 25);
            this.ENDERECO.TabIndex = 9;
            this.ENDERECO.Text = "Endereço: ";
            this.ENDERECO.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ENDERECO.Click += new System.EventHandler(this.label5_Click);
            // 
            // EMAIL_TXT
            // 
            this.EMAIL_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EMAIL_TXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EMAIL_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMAIL_TXT.ForeColor = System.Drawing.Color.DimGray;
            this.EMAIL_TXT.Location = new System.Drawing.Point(300, 286);
            this.EMAIL_TXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EMAIL_TXT.Name = "EMAIL_TXT";
            this.EMAIL_TXT.Size = new System.Drawing.Size(403, 30);
            this.EMAIL_TXT.TabIndex = 8;
            this.EMAIL_TXT.Text = "Digite seu email com @...";
            this.EMAIL_TXT.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSize = true;
            this.EMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMAIL.Location = new System.Drawing.Point(203, 286);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(78, 25);
            this.EMAIL.TabIndex = 7;
            this.EMAIL.Text = "Email: ";
            this.EMAIL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.EMAIL.Click += new System.EventHandler(this.label6_Click);
            // 
            // BTN_SALVAR
            // 
            this.BTN_SALVAR.BackColor = System.Drawing.Color.YellowGreen;
            this.BTN_SALVAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SALVAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SALVAR.ForeColor = System.Drawing.Color.Ivory;
            this.BTN_SALVAR.Location = new System.Drawing.Point(188, 547);
            this.BTN_SALVAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_SALVAR.Name = "BTN_SALVAR";
            this.BTN_SALVAR.Size = new System.Drawing.Size(212, 49);
            this.BTN_SALVAR.TabIndex = 11;
            this.BTN_SALVAR.Text = "&SALVAR";
            this.BTN_SALVAR.UseVisualStyleBackColor = false;
            this.BTN_SALVAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_FECHAR
            // 
            this.BTN_FECHAR.BackColor = System.Drawing.Color.Crimson;
            this.BTN_FECHAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_FECHAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FECHAR.ForeColor = System.Drawing.Color.MistyRose;
            this.BTN_FECHAR.Location = new System.Drawing.Point(473, 547);
            this.BTN_FECHAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_FECHAR.Name = "BTN_FECHAR";
            this.BTN_FECHAR.Size = new System.Drawing.Size(212, 49);
            this.BTN_FECHAR.TabIndex = 13;
            this.BTN_FECHAR.Text = "&FECHAR";
            this.BTN_FECHAR.UseVisualStyleBackColor = false;
            this.BTN_FECHAR.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(228, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "FORMULÁRIO DE CADASTRO";
            // 
            // ESTADO_TXT
            // 
            this.ESTADO_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ESTADO_TXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ESTADO_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESTADO_TXT.ForeColor = System.Drawing.Color.DimGray;
            this.ESTADO_TXT.Location = new System.Drawing.Point(300, 494);
            this.ESTADO_TXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ESTADO_TXT.Name = "ESTADO_TXT";
            this.ESTADO_TXT.Size = new System.Drawing.Size(403, 30);
            this.ESTADO_TXT.TabIndex = 18;
            this.ESTADO_TXT.Text = "Digite seu endereço...";
            // 
            // ESTADO
            // 
            this.ESTADO.AutoSize = true;
            this.ESTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESTADO.Location = new System.Drawing.Point(189, 494);
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.Size = new System.Drawing.Size(92, 25);
            this.ESTADO.TabIndex = 17;
            this.ESTADO.Text = "Estado: ";
            this.ESTADO.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CEP_TXT
            // 
            this.CEP_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CEP_TXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CEP_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEP_TXT.ForeColor = System.Drawing.Color.DimGray;
            this.CEP_TXT.Location = new System.Drawing.Point(300, 426);
            this.CEP_TXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CEP_TXT.Name = "CEP_TXT";
            this.CEP_TXT.Size = new System.Drawing.Size(403, 30);
            this.CEP_TXT.TabIndex = 16;
            this.CEP_TXT.Text = "Digite seu email com @...";
            // 
            // CEP
            // 
            this.CEP.AutoSize = true;
            this.CEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEP.Location = new System.Drawing.Point(212, 426);
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(69, 25);
            this.CEP.TabIndex = 15;
            this.CEP.Text = "CEP: ";
            this.CEP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CEP.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(887, 617);
            this.Controls.Add(this.ESTADO_TXT);
            this.Controls.Add(this.ESTADO);
            this.Controls.Add(this.CEP_TXT);
            this.Controls.Add(this.CEP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_FECHAR);
            this.Controls.Add(this.BTN_SALVAR);
            this.Controls.Add(this.ENDEREÇO_TXT);
            this.Controls.Add(this.ENDERECO);
            this.Controls.Add(this.EMAIL_TXT);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.TELEFONE_TXT);
            this.Controls.Add(this.TELEFONE);
            this.Controls.Add(this.CPF_TXT);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.NOME_TXT);
            this.Controls.Add(this.NOME);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Bloco de notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label NOME;
        private System.Windows.Forms.TextBox NOME_TXT;
        private System.Windows.Forms.TextBox CPF_TXT;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.TextBox TELEFONE_TXT;
        private System.Windows.Forms.Label TELEFONE;
        private System.Windows.Forms.TextBox ENDEREÇO_TXT;
        private System.Windows.Forms.Label ENDERECO;
        private System.Windows.Forms.TextBox EMAIL_TXT;
        private System.Windows.Forms.Label EMAIL;
        private System.Windows.Forms.Button BTN_SALVAR;
        private System.Windows.Forms.Button BTN_FECHAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ESTADO_TXT;
        private System.Windows.Forms.Label ESTADO;
        private System.Windows.Forms.TextBox CEP_TXT;
        private System.Windows.Forms.Label CEP;
    }
}

