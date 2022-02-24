namespace Vendas_2022._1.Views
{
    partial class FormVenda
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
            this.btnSalvarVenda = new System.Windows.Forms.Button();
            this.groupBoxNovaVenda = new System.Windows.Forms.GroupBox();
            this.numericUpDownValor = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQtd = new System.Windows.Forms.NumericUpDown();
            this.textBoxCodVenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.groupBoxNovaVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvarVenda
            // 
            this.btnSalvarVenda.Location = new System.Drawing.Point(478, 5);
            this.btnSalvarVenda.Name = "btnSalvarVenda";
            this.btnSalvarVenda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSalvarVenda.Size = new System.Drawing.Size(103, 23);
            this.btnSalvarVenda.TabIndex = 14;
            this.btnSalvarVenda.Text = "Nova Venda";
            this.btnSalvarVenda.UseVisualStyleBackColor = true;
            this.btnSalvarVenda.Click += new System.EventHandler(this.btnSalvarVenda_Click);
            // 
            // groupBoxNovaVenda
            // 
            this.groupBoxNovaVenda.Controls.Add(this.numericUpDownValor);
            this.groupBoxNovaVenda.Controls.Add(this.numericUpDownQtd);
            this.groupBoxNovaVenda.Controls.Add(this.textBoxCodVenda);
            this.groupBoxNovaVenda.Controls.Add(this.label5);
            this.groupBoxNovaVenda.Controls.Add(this.btnAdicionarProduto);
            this.groupBoxNovaVenda.Controls.Add(this.dataGridViewProdutos);
            this.groupBoxNovaVenda.Controls.Add(this.label4);
            this.groupBoxNovaVenda.Controls.Add(this.label3);
            this.groupBoxNovaVenda.Controls.Add(this.label2);
            this.groupBoxNovaVenda.Controls.Add(this.comboBoxProduto);
            this.groupBoxNovaVenda.Location = new System.Drawing.Point(30, 39);
            this.groupBoxNovaVenda.Name = "groupBoxNovaVenda";
            this.groupBoxNovaVenda.Size = new System.Drawing.Size(741, 406);
            this.groupBoxNovaVenda.TabIndex = 13;
            this.groupBoxNovaVenda.TabStop = false;
            this.groupBoxNovaVenda.Text = "Nova Venda";
            this.groupBoxNovaVenda.Visible = false;
            // 
            // numericUpDownValor
            // 
            this.numericUpDownValor.Location = new System.Drawing.Point(131, 136);
            this.numericUpDownValor.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownValor.Name = "numericUpDownValor";
            this.numericUpDownValor.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownValor.TabIndex = 13;
            // 
            // numericUpDownQtd
            // 
            this.numericUpDownQtd.Location = new System.Drawing.Point(131, 99);
            this.numericUpDownQtd.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownQtd.Name = "numericUpDownQtd";
            this.numericUpDownQtd.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQtd.TabIndex = 12;
            // 
            // textBoxCodVenda
            // 
            this.textBoxCodVenda.Location = new System.Drawing.Point(131, 24);
            this.textBoxCodVenda.Name = "textBoxCodVenda";
            this.textBoxCodVenda.ReadOnly = true;
            this.textBoxCodVenda.Size = new System.Drawing.Size(80, 20);
            this.textBoxCodVenda.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Codigo:";
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(257, 133);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(150, 23);
            this.btnAdicionarProduto.TabIndex = 9;
            this.btnAdicionarProduto.Text = "Adicionar";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnProduto,
            this.ColumnQtd,
            this.ColumnValor,
            this.ColumnTotal});
            this.dataGridViewProdutos.Location = new System.Drawing.Point(55, 171);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(642, 204);
            this.dataGridViewProdutos.TabIndex = 8;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            // 
            // ColumnProduto
            // 
            this.ColumnProduto.HeaderText = "Produto";
            this.ColumnProduto.Name = "ColumnProduto";
            this.ColumnProduto.Width = 200;
            // 
            // ColumnQtd
            // 
            this.ColumnQtd.HeaderText = "Quantidade";
            this.ColumnQtd.Name = "ColumnQtd";
            // 
            // ColumnValor
            // 
            this.ColumnValor.HeaderText = "Valor";
            this.ColumnValor.Name = "ColumnValor";
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "Total";
            this.ColumnTotal.Name = "ColumnTotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor R$:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produto:";
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(131, 59);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(276, 21);
            this.comboBoxProduto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cliente:";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(196, 7);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(276, 21);
            this.comboBoxCliente.TabIndex = 11;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvarVenda);
            this.Controls.Add(this.groupBoxNovaVenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCliente);
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            this.Load += new System.EventHandler(this.Venda_Load);
            this.groupBoxNovaVenda.ResumeLayout(false);
            this.groupBoxNovaVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarVenda;
        private System.Windows.Forms.GroupBox groupBoxNovaVenda;
        private System.Windows.Forms.NumericUpDown numericUpDownValor;
        private System.Windows.Forms.NumericUpDown numericUpDownQtd;
        private System.Windows.Forms.TextBox textBoxCodVenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCliente;
    }
}