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
using Vendas_2022._1.Views;
using static Vendas_2022._1.Utils.Utils;


namespace Vendas_2022._1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente cliente = new FormCliente();
            cliente.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduto p = new FormProduto();
            p.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {

                Models.Cliente c = new Cliente();
                string passWd = cryptographyPass(textBoxPassword.Text);
                Cliente cliente = c.getClientePorLoginSenha(textBoxUser.Text, passWd);

                if (cliente != null)
                {
                    FormMenu login = new FormMenu(cliente);
                    login.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou Senha Errados!!!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uam exceção: " + ex.Message);
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}