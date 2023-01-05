namespace JSON_Allan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView_dados = new System.Windows.Forms.DataGridView();
            this.pictureBox_adicionarEntidade = new System.Windows.Forms.PictureBox();
            this.pictureBox_atualizarEntidade = new System.Windows.Forms.PictureBox();
            this.pictureBox_deleteEntidade = new System.Windows.Forms.PictureBox();
            this.pictureBox_lerArquivo = new System.Windows.Forms.PictureBox();
            this.ColunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaIdentidadeSecreta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaPoderes = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_adicionarEntidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_atualizarEntidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_deleteEntidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lerArquivo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_dados
            // 
            this.dataGridView_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaID,
            this.ColunaNome,
            this.ColunaIdade,
            this.ColunaIdentidadeSecreta,
            this.ColunaPoderes});
            this.dataGridView_dados.Location = new System.Drawing.Point(12, 2);
            this.dataGridView_dados.Name = "dataGridView_dados";
            this.dataGridView_dados.RowTemplate.Height = 25;
            this.dataGridView_dados.Size = new System.Drawing.Size(607, 396);
            this.dataGridView_dados.TabIndex = 1;
            this.dataGridView_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_dados_CellContentClick);
            // 
            // pictureBox_adicionarEntidade
            // 
            this.pictureBox_adicionarEntidade.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_adicionarEntidade.Image")));
            this.pictureBox_adicionarEntidade.Location = new System.Drawing.Point(661, 61);
            this.pictureBox_adicionarEntidade.Name = "pictureBox_adicionarEntidade";
            this.pictureBox_adicionarEntidade.Size = new System.Drawing.Size(70, 70);
            this.pictureBox_adicionarEntidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_adicionarEntidade.TabIndex = 2;
            this.pictureBox_adicionarEntidade.TabStop = false;
            this.pictureBox_adicionarEntidade.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox_atualizarEntidade
            // 
            this.pictureBox_atualizarEntidade.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_atualizarEntidade.Image")));
            this.pictureBox_atualizarEntidade.Location = new System.Drawing.Point(661, 150);
            this.pictureBox_atualizarEntidade.Name = "pictureBox_atualizarEntidade";
            this.pictureBox_atualizarEntidade.Size = new System.Drawing.Size(70, 70);
            this.pictureBox_atualizarEntidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_atualizarEntidade.TabIndex = 3;
            this.pictureBox_atualizarEntidade.TabStop = false;
            this.pictureBox_atualizarEntidade.Click += new System.EventHandler(this.pictureBox_atualizarEntidade_Click);
            // 
            // pictureBox_deleteEntidade
            // 
            this.pictureBox_deleteEntidade.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_deleteEntidade.Image")));
            this.pictureBox_deleteEntidade.Location = new System.Drawing.Point(661, 239);
            this.pictureBox_deleteEntidade.Name = "pictureBox_deleteEntidade";
            this.pictureBox_deleteEntidade.Size = new System.Drawing.Size(70, 70);
            this.pictureBox_deleteEntidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_deleteEntidade.TabIndex = 4;
            this.pictureBox_deleteEntidade.TabStop = false;
            this.pictureBox_deleteEntidade.Click += new System.EventHandler(this.pictureBox_deleteEntidade_Click);
            // 
            // pictureBox_lerArquivo
            // 
            this.pictureBox_lerArquivo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_lerArquivo.Image")));
            this.pictureBox_lerArquivo.Location = new System.Drawing.Point(661, 328);
            this.pictureBox_lerArquivo.Name = "pictureBox_lerArquivo";
            this.pictureBox_lerArquivo.Size = new System.Drawing.Size(70, 70);
            this.pictureBox_lerArquivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_lerArquivo.TabIndex = 5;
            this.pictureBox_lerArquivo.TabStop = false;
            this.pictureBox_lerArquivo.Click += new System.EventHandler(this.pictureBox_lerArquivo_Click);
            // 
            // ColunaID
            // 
            this.ColunaID.HeaderText = "ID";
            this.ColunaID.Name = "ColunaID";
            // 
            // ColunaNome
            // 
            this.ColunaNome.HeaderText = "Nome";
            this.ColunaNome.Name = "ColunaNome";
            // 
            // ColunaIdade
            // 
            this.ColunaIdade.HeaderText = "Idade";
            this.ColunaIdade.Name = "ColunaIdade";
            // 
            // ColunaIdentidadeSecreta
            // 
            this.ColunaIdentidadeSecreta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColunaIdentidadeSecreta.HeaderText = "Identidade Secreta";
            this.ColunaIdentidadeSecreta.Name = "ColunaIdentidadeSecreta";
            // 
            // ColunaPoderes
            // 
            this.ColunaPoderes.HeaderText = "Poderes";
            this.ColunaPoderes.Name = "ColunaPoderes";
            this.ColunaPoderes.Text = "Ver Poderes";
            this.ColunaPoderes.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox_lerArquivo);
            this.Controls.Add(this.pictureBox_deleteEntidade);
            this.Controls.Add(this.pictureBox_atualizarEntidade);
            this.Controls.Add(this.pictureBox_adicionarEntidade);
            this.Controls.Add(this.dataGridView_dados);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_adicionarEntidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_atualizarEntidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_deleteEntidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lerArquivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_dados;
        private PictureBox pictureBox_adicionarEntidade;
        private PictureBox pictureBox_atualizarEntidade;
        private PictureBox pictureBox_deleteEntidade;
        private PictureBox pictureBox_lerArquivo;
        private DataGridViewTextBoxColumn ColunaID;
        private DataGridViewTextBoxColumn ColunaNome;
        private DataGridViewTextBoxColumn ColunaIdade;
        private DataGridViewTextBoxColumn ColunaIdentidadeSecreta;
        private DataGridViewButtonColumn ColunaPoderes;
    }
}