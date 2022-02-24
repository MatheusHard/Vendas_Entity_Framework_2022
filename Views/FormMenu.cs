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
    public partial class FormMenu : Form
    {
        private Cliente cliente;
        public FormMenu(Cliente c)
        {

            InitializeComponent();
            this.cliente = c;
            menuStripPrincipal.Visible = c.Perfil;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void vendaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            FormVenda venda = new FormVenda(this.cliente);
            venda.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormCliente cliente = new FormCliente();
            cliente.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormProduto p = new FormProduto();
            p.ShowDialog();
        }
    }
}
