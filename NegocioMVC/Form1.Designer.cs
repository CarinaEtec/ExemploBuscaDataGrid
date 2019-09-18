namespace NegocioMVC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscaLivroNome = new System.Windows.Forms.Button();
            this.txtIdAutorLivro = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtLivroId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpLivro = new System.Windows.Forms.GroupBox();
            this.mskDtPublicacao = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarLivroID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpLivro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 101);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnBuscaLivroNome
            // 
            this.btnBuscaLivroNome.Location = new System.Drawing.Point(235, 26);
            this.btnBuscaLivroNome.Name = "btnBuscaLivroNome";
            this.btnBuscaLivroNome.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaLivroNome.TabIndex = 13;
            this.btnBuscaLivroNome.Text = "Nome";
            this.btnBuscaLivroNome.UseVisualStyleBackColor = true;
            this.btnBuscaLivroNome.Click += new System.EventHandler(this.btnBuscaLivroNome_Click);
            // 
            // txtIdAutorLivro
            // 
            this.txtIdAutorLivro.Location = new System.Drawing.Point(129, 131);
            this.txtIdAutorLivro.Name = "txtIdAutorLivro";
            this.txtIdAutorLivro.Size = new System.Drawing.Size(262, 21);
            this.txtIdAutorLivro.TabIndex = 6;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(129, 65);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(262, 21);
            this.txtTitulo.TabIndex = 4;
            // 
            // txtLivroId
            // 
            this.txtLivroId.Location = new System.Drawing.Point(129, 28);
            this.txtLivroId.Name = "txtLivroId";
            this.txtLivroId.Size = new System.Drawing.Size(94, 21);
            this.txtLivroId.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Autor ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Data Publicação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Título";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Livro ID";
            // 
            // grpLivro
            // 
            this.grpLivro.Controls.Add(this.mskDtPublicacao);
            this.grpLivro.Controls.Add(this.btnBuscarLivroID);
            this.grpLivro.Controls.Add(this.btnBuscaLivroNome);
            this.grpLivro.Controls.Add(this.txtIdAutorLivro);
            this.grpLivro.Controls.Add(this.txtTitulo);
            this.grpLivro.Controls.Add(this.txtLivroId);
            this.grpLivro.Controls.Add(this.label7);
            this.grpLivro.Controls.Add(this.label6);
            this.grpLivro.Controls.Add(this.label5);
            this.grpLivro.Controls.Add(this.label4);
            this.grpLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLivro.Location = new System.Drawing.Point(7, 12);
            this.grpLivro.Name = "grpLivro";
            this.grpLivro.Size = new System.Drawing.Size(450, 170);
            this.grpLivro.TabIndex = 14;
            this.grpLivro.TabStop = false;
            this.grpLivro.Text = "Livro";
            // 
            // mskDtPublicacao
            // 
            this.mskDtPublicacao.Location = new System.Drawing.Point(129, 98);
            this.mskDtPublicacao.Mask = "00/00/0000";
            this.mskDtPublicacao.Name = "mskDtPublicacao";
            this.mskDtPublicacao.Size = new System.Drawing.Size(100, 21);
            this.mskDtPublicacao.TabIndex = 27;
            // 
            // btnBuscarLivroID
            // 
            this.btnBuscarLivroID.Location = new System.Drawing.Point(316, 26);
            this.btnBuscarLivroID.Name = "btnBuscarLivroID";
            this.btnBuscarLivroID.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarLivroID.TabIndex = 26;
            this.btnBuscarLivroID.Text = "ID";
            this.btnBuscarLivroID.UseVisualStyleBackColor = true;
            this.btnBuscarLivroID.Click += new System.EventHandler(this.btnBuscarLivroID_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 328);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpLivro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpLivro.ResumeLayout(false);
            this.grpLivro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscaLivroNome;
        private System.Windows.Forms.TextBox txtIdAutorLivro;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtLivroId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpLivro;
        private System.Windows.Forms.Button btnBuscarLivroID;
        private System.Windows.Forms.MaskedTextBox mskDtPublicacao;
    }
}

