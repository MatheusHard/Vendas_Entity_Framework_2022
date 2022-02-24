using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendas_2022._1.Models;

namespace Vendas_2022._1.Views
{
    public partial class FormVenda : Form
    {
        private Cliente cliente;

        public FormVenda(Cliente c)
        {
            InitializeComponent();
            this.cliente = c;


        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Venda_Load(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            this.comboBoxCliente.Items.Clear();
            this.comboBoxCliente.DataSource = c.getAll();
            this.comboBoxCliente.DisplayMember = "Name";
            this.comboBoxCliente.ValueMember = "Id";

            Produto p = new Produto();
            this.comboBoxProduto.Items.Clear();

            this.comboBoxProduto.DataSource = p.getAll();
            this.comboBoxProduto.DisplayMember = "Descricao";
            this.comboBoxProduto.ValueMember = "Id";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarVenda_Click(object sender, EventArgs e)
        {

            try
            {

                var cliente_id = Convert.ToInt32(this.comboBoxCliente.SelectedValue);

                Pedido p = new Pedido();
                p.ClienteId = cliente_id;
                var pedido = p.add();
                //MessageBox.Show(pedido.Id.ToString());

                groupBoxNovaVenda.Visible = true;
                btnSalvarVenda.Enabled = false;

                textBoxCodVenda.Text = pedido.Id.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message);
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {


            Item pItem = new Item();
            pItem.PedidoId = int.Parse(textBoxCodVenda.Text);
            pItem.ProdutoId = Convert.ToInt32(this.comboBoxProduto.SelectedValue);
            pItem.Valor = int.Parse(numericUpDownValor.Text);
            pItem.Quantidade = int.Parse(numericUpDownQtd.Text);

            //Add Itens do Pedido:
            pItem.add();

            getItensByIdPedido(pItem.PedidoId);


        }

        private void groupBoxNovaVenda_Enter(object sender, EventArgs e)
        {

        }

        /*dataGridView1.ReadOnly = false; //Before modifying, it is required.
dataGridView1.Rows.Add(); //Inserting first row if yet there is no row, first row number is '0'
dataGridView1.Rows[0].Cells[0].Value = "Razib, this is 0,0!"; //Setting the leftmost and topmost cell's value (Not the column header row!)
dataGridView1[1, 0].Value = "This is 0,1!"; ; */

        private void getItensByIdPedido(int id_pedido)
        {

            dataGridViewProdutos.Rows.Clear();


            Item item = new Item();

            foreach (Item row in item.getItens(id_pedido))
            {

                //Codigo:
                dataGridViewProdutos.Rows[0].Cells[0].Value = row.Id.ToString();
                //Produto
                dataGridViewProdutos.Rows[0].Cells[1].Value = row.ProdutoId.ToString();
                //Qtd
                dataGridViewProdutos.Rows[0].Cells[2].Value = row.Quantidade.ToString();
                //Valor
                dataGridViewProdutos.Rows[0].Cells[3].Value = row.Valor.ToString();
                //Total
                //dataGridViewProdutos.Rows[0].Cells[4].Value = row.;

            }

        }
    }
}

