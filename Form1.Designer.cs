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
            this.label2 = new System.Windows.Forms.Label();
            this.NOME_TXT = new System.Windows.Forms.TextBox();
            this.CPF_TXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TELEFONE_TXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ENDEREÇO_TXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EMAIL_TXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SALVAR = new System.Windows.Forms.Button();
            this.FECHAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NOME_TXT
            // 
            this.NOME_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NOME_TXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NOME_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOME_TXT.ForeColor = System.Drawing.Color.DimGray;
            this.NOME_TXT.Location = new System.Drawing.Point(225, 80);
            this.NOME_TXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NOME_TXT.Name = "NOME_TXT";
            this.NOME_TXT.Size = new System.Drawing.Size(303, 26);
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
            this.CPF_TXT.Location = new System.Drawing.Point(225, 128);
            this.CPF_TXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CPF_TXT.Name = "CPF_TXT";
            this.CPF_TXT.Size = new System.Drawing.Size(303, 26);
            this.CPF_TXT.TabIndex = 4;
            this.CPF_TXT.Text = "Digite seu CPF apenas com números...";
            this.CPF_TXT.TextChanged += new System.EventHandler(this.CPF_TXT_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TELEFONE_TXT
            // 
            this.TELEFONE_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TELEFONE_TXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TELEFONE_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TELEFONE_TXT.ForeColor = System.Drawing.Color.DimGray;
            this.TELEFONE_TXT.Location = new System.Drawing.Point(225, 179);
            this.TELEFONE_TXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TELEFONE_TXT.Name = "TELEFONE_TXT";
            this.TELEFONE_TXT.Size = new System.Drawing.Size(303, 26);
            this.TELEFONE_TXT.TabIndex = 6;
            this.TELEFONE_TXT.Text = "Digite seu telefone apenas com números...";
            this.TELEFONE_TXT.TextChanged += new System.EventHandler(this.TELEFONE_TXT_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefone:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ENDEREÇO_TXT
            // 
            this.ENDEREÇO_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ENDEREÇO_TXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ENDEREÇO_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENDEREÇO_TXT.ForeColor = System.Drawing.Color.DimGray;
            this.ENDEREÇO_TXT.Location = new System.Drawing.Point(225, 288);
            this.ENDEREÇO_TXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ENDEREÇO_TXT.Name = "ENDEREÇO_TXT";
            this.ENDEREÇO_TXT.Size = new System.Drawing.Size(303, 26);
            this.ENDEREÇO_TXT.TabIndex = 10;
            this.ENDEREÇO_TXT.Text = "Digite seu endereço...";
            this.ENDEREÇO_TXT.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Endereço: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // EMAIL_TXT
            // 
            this.EMAIL_TXT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EMAIL_TXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EMAIL_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMAIL_TXT.ForeColor = System.Drawing.Color.DimGray;
            this.EMAIL_TXT.Location = new System.Drawing.Point(225, 232);
            this.EMAIL_TXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EMAIL_TXT.Name = "EMAIL_TXT";
            this.EMAIL_TXT.Size = new System.Drawing.Size(303, 26);
            this.EMAIL_TXT.TabIndex = 8;
            this.EMAIL_TXT.Text = "Digite seu email com @...";
            this.EMAIL_TXT.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(152, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // SALVAR
            // 
            this.SALVAR.BackColor = System.Drawing.Color.YellowGreen;
            this.SALVAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SALVAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SALVAR.ForeColor = System.Drawing.Color.Ivory;
            this.SALVAR.Location = new System.Drawing.Point(143, 352);
            this.SALVAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SALVAR.Name = "SALVAR";
            this.SALVAR.Size = new System.Drawing.Size(159, 40);
            this.SALVAR.TabIndex = 11;
            this.SALVAR.Text = "&SALVAR";
            this.SALVAR.UseVisualStyleBackColor = false;
            this.SALVAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // FECHAR
            // 
            this.FECHAR.BackColor = System.Drawing.Color.Crimson;
            this.FECHAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FECHAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FECHAR.ForeColor = System.Drawing.Color.MistyRose;
            this.FECHAR.Location = new System.Drawing.Point(357, 352);
            this.FECHAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FECHAR.Name = "FECHAR";
            this.FECHAR.Size = new System.Drawing.Size(159, 40);
            this.FECHAR.TabIndex = 13;
            this.FECHAR.Text = "&FECHAR";
            this.FECHAR.UseVisualStyleBackColor = false;
            this.FECHAR.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(171, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "FORMULÁRIO DE CADASTRO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(665, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FECHAR);
            this.Controls.Add(this.SALVAR);
            this.Controls.Add(this.ENDEREÇO_TXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EMAIL_TXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TELEFONE_TXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CPF_TXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NOME_TXT);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Bloco de notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NOME_TXT;
        private System.Windows.Forms.TextBox CPF_TXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TELEFONE_TXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ENDEREÇO_TXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EMAIL_TXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SALVAR;
        private System.Windows.Forms.Button FECHAR;
        private System.Windows.Forms.Label label1;
    }
}

