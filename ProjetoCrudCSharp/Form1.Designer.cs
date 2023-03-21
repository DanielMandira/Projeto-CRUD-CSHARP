namespace ProjetoCrudCSharp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Nome = new System.Windows.Forms.TextBox();
            this.TXT_Endereco = new System.Windows.Forms.TextBox();
            this.BTN_Inserir = new System.Windows.Forms.Button();
            this.BTN_Atualizar = new System.Windows.Forms.Button();
            this.BTN_Pesquisa = new System.Windows.Forms.Button();
            this.TXT_Celular = new System.Windows.Forms.TextBox();
            this.BTN_Fechar = new System.Windows.Forms.Button();
            this.BTN_Limpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_Dados = new System.Windows.Forms.DataGridView();
            this.BTN_Apagar = new System.Windows.Forms.Button();
            this.LBL_Idx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Dados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // TXT_Nome
            // 
            this.TXT_Nome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_Nome.Location = new System.Drawing.Point(119, 74);
            this.TXT_Nome.Name = "TXT_Nome";
            this.TXT_Nome.Size = new System.Drawing.Size(201, 26);
            this.TXT_Nome.TabIndex = 0;
            // 
            // TXT_Endereco
            // 
            this.TXT_Endereco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_Endereco.Location = new System.Drawing.Point(119, 106);
            this.TXT_Endereco.Name = "TXT_Endereco";
            this.TXT_Endereco.Size = new System.Drawing.Size(201, 26);
            this.TXT_Endereco.TabIndex = 1;
            // 
            // BTN_Inserir
            // 
            this.BTN_Inserir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Inserir.ForeColor = System.Drawing.Color.Black;
            this.BTN_Inserir.Location = new System.Drawing.Point(342, 73);
            this.BTN_Inserir.Name = "BTN_Inserir";
            this.BTN_Inserir.Size = new System.Drawing.Size(75, 27);
            this.BTN_Inserir.TabIndex = 3;
            this.BTN_Inserir.Text = "Inserir";
            this.BTN_Inserir.UseVisualStyleBackColor = true;
            this.BTN_Inserir.Click += new System.EventHandler(this.BTN_Inserir_Click);
            // 
            // BTN_Atualizar
            // 
            this.BTN_Atualizar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Atualizar.ForeColor = System.Drawing.Color.Black;
            this.BTN_Atualizar.Location = new System.Drawing.Point(342, 137);
            this.BTN_Atualizar.Name = "BTN_Atualizar";
            this.BTN_Atualizar.Size = new System.Drawing.Size(75, 27);
            this.BTN_Atualizar.TabIndex = 5;
            this.BTN_Atualizar.Text = "Atualizar";
            this.BTN_Atualizar.UseVisualStyleBackColor = true;
            this.BTN_Atualizar.Click += new System.EventHandler(this.BTN_Atualizar_Click);
            // 
            // BTN_Pesquisa
            // 
            this.BTN_Pesquisa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Pesquisa.ForeColor = System.Drawing.Color.Black;
            this.BTN_Pesquisa.Location = new System.Drawing.Point(342, 106);
            this.BTN_Pesquisa.Name = "BTN_Pesquisa";
            this.BTN_Pesquisa.Size = new System.Drawing.Size(75, 26);
            this.BTN_Pesquisa.TabIndex = 4;
            this.BTN_Pesquisa.Text = "Pesquisar";
            this.BTN_Pesquisa.UseVisualStyleBackColor = true;
            this.BTN_Pesquisa.Click += new System.EventHandler(this.BTN_Pesquisa_Click);
            // 
            // TXT_Celular
            // 
            this.TXT_Celular.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_Celular.Location = new System.Drawing.Point(119, 138);
            this.TXT_Celular.Name = "TXT_Celular";
            this.TXT_Celular.Size = new System.Drawing.Size(201, 26);
            this.TXT_Celular.TabIndex = 2;
            // 
            // BTN_Fechar
            // 
            this.BTN_Fechar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Fechar.ForeColor = System.Drawing.Color.Black;
            this.BTN_Fechar.Location = new System.Drawing.Point(446, 137);
            this.BTN_Fechar.Name = "BTN_Fechar";
            this.BTN_Fechar.Size = new System.Drawing.Size(75, 27);
            this.BTN_Fechar.TabIndex = 8;
            this.BTN_Fechar.Text = "Fechar";
            this.BTN_Fechar.UseVisualStyleBackColor = true;
            this.BTN_Fechar.Click += new System.EventHandler(this.BTN_Fechar_Click);
            // 
            // BTN_Limpar
            // 
            this.BTN_Limpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Limpar.ForeColor = System.Drawing.Color.Black;
            this.BTN_Limpar.Location = new System.Drawing.Point(446, 106);
            this.BTN_Limpar.Name = "BTN_Limpar";
            this.BTN_Limpar.Size = new System.Drawing.Size(75, 27);
            this.BTN_Limpar.TabIndex = 7;
            this.BTN_Limpar.Text = "Limpar";
            this.BTN_Limpar.UseVisualStyleBackColor = true;
            this.BTN_Limpar.Click += new System.EventHandler(this.BTN_Limpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(141, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Meu Primeiro CRUD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone";
            // 
            // DGV_Dados
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Dados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Dados.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Dados.Location = new System.Drawing.Point(28, 270);
            this.DGV_Dados.Name = "DGV_Dados";
            this.DGV_Dados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Dados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Dados.RowTemplate.Height = 25;
            this.DGV_Dados.Size = new System.Drawing.Size(493, 211);
            this.DGV_Dados.TabIndex = 9;
            this.DGV_Dados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Dados_CellClick);
            // 
            // BTN_Apagar
            // 
            this.BTN_Apagar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Apagar.ForeColor = System.Drawing.Color.Black;
            this.BTN_Apagar.Location = new System.Drawing.Point(342, 170);
            this.BTN_Apagar.Name = "BTN_Apagar";
            this.BTN_Apagar.Size = new System.Drawing.Size(75, 27);
            this.BTN_Apagar.TabIndex = 5;
            this.BTN_Apagar.Text = "Apagar";
            this.BTN_Apagar.UseVisualStyleBackColor = true;
            this.BTN_Apagar.Click += new System.EventHandler(this.BTN_Apagar_Click);
            // 
            // LBL_Idx
            // 
            this.LBL_Idx.AutoSize = true;
            this.LBL_Idx.Location = new System.Drawing.Point(425, 31);
            this.LBL_Idx.Name = "LBL_Idx";
            this.LBL_Idx.Size = new System.Drawing.Size(23, 15);
            this.LBL_Idx.TabIndex = 10;
            this.LBL_Idx.Text = "idx";
            this.LBL_Idx.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(557, 497);
            this.Controls.Add(this.LBL_Idx);
            this.Controls.Add(this.DGV_Dados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_Pesquisa);
            this.Controls.Add(this.BTN_Limpar);
            this.Controls.Add(this.BTN_Fechar);
            this.Controls.Add(this.BTN_Apagar);
            this.Controls.Add(this.BTN_Atualizar);
            this.Controls.Add(this.BTN_Inserir);
            this.Controls.Add(this.TXT_Endereco);
            this.Controls.Add(this.TXT_Celular);
            this.Controls.Add(this.TXT_Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meu Primeiro Crud";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TXT_Nome;
        private TextBox TXT_Endereco;
        private Button BTN_Inserir;
        private Button BTN_Atualizar;
        private Button BTN_Pesquisa;
        private TextBox TXT_Celular;
        private Button BTN_Fechar;
        private Button BTN_Limpar;
        private Label label3;
        private Label label4;
        private DataGridView DGV_Dados;
        private Button BTN_Apagar;
        private Label LBL_Idx;
    }
}