namespace Vendas_2022._1.Views
{
    partial class FormProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownValor = new System.Windows.Forms.NumericUpDown();
            this.richTextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.btnUpdateProduto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewProduto = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValor)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Produtos";
            // 
            // numericUpDownValor
            // 
            this.numericUpDownValor.Location = new System.Drawing.Point(267, 185);
            this.numericUpDownValor.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownValor.Name = "numericUpDownValor";
            this.numericUpDownValor.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownValor.TabIndex = 37;
            // 
            // richTextBoxDescricao
            // 
            this.richTextBoxDescricao.Location = new System.Drawing.Point(267, 83);
            this.richTextBoxDescricao.Name = "richTextBoxDescricao";
            this.richTextBoxDescricao.Size = new System.Drawing.Size(188, 96);
            this.richTextBoxDescricao.TabIndex = 36;
            this.richTextBoxDescricao.Text = "";
            // 
            // btnUpdateProduto
            // 
            this.btnUpdateProduto.Location = new System.Drawing.Point(320, 231);
            this.btnUpdateProduto.Name = "btnUpdateProduto";
            this.btnUpdateProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdateProduto.Size = new System.Drawing.Size(123, 23);
            this.btnUpdateProduto.TabIndex = 35;
            this.btnUpdateProduto.Text = "Atualizar";
            this.btnUpdateProduto.UseVisualStyleBackColor = true;
            this.btnUpdateProduto.Click += new System.EventHandler(this.btnUpdateProduto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Valor:";
            // 
            // listViewProduto
            // 
            this.listViewProduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderNome,
            this.columnHeaderValor,
            this.columnHeaderDescricao});
            this.listViewProduto.HideSelection = false;
            this.listViewProduto.Location = new System.Drawing.Point(12, 272);
            this.listViewProduto.Name = "listViewProduto";
            this.listViewProduto.Size = new System.Drawing.Size(776, 154);
            this.listViewProduto.TabIndex = 33;
            this.listViewProduto.UseCompatibleStateImageBehavior = false;
            this.listViewProduto.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Codigo";
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome do Produto";
            this.columnHeaderNome.Width = 179;
            // 
            // columnHeaderValor
            // 
            this.columnHeaderValor.Text = "Valor R$";
            this.columnHeaderValor.Width = 88;
            // 
            // columnHeaderDescricao
            // 
            this.columnHeaderDescricao.Text = "Descricao do Produto";
            this.columnHeaderDescricao.Width = 445;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Descricao:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(267, 54);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(188, 20);
            this.textBoxNome.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome:";
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(454, 231);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(106, 23);
            this.btnRemoverProduto.TabIndex = 29;
            this.btnRemoverProduto.Text = "Remover";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Location = new System.Drawing.Point(206, 231);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(108, 23);
            this.btnSalvarProduto.TabIndex = 28;
            this.btnSalvarProduto.Text = "Salvar";
            this.btnSalvarProduto.UseVisualStyleBackColor = true;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownValor);
            this.Controls.Add(this.richTextBoxDescricao);
            this.Controls.Add(this.btnUpdateProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoverProduto);
            this.Controls.Add(this.btnSalvarProduto);
            this.Name = "FormProduto";
            this.Text = "FormProduto";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownValor;
        private System.Windows.Forms.RichTextBox richTextBoxDescricao;
        private System.Windows.Forms.Button btnUpdateProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewProduto;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.ColumnHeader columnHeaderValor;
        private System.Windows.Forms.ColumnHeader columnHeaderDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnSalvarProduto;
    }
}