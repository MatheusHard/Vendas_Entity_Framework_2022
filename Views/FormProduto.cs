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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
            getProdutos();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            try
            {

                if (validarForm())
                {
                    Produto p = new Produto();

                    p.Name = textBoxNome.Text.ToString();
                    p.Descricao = richTextBoxDescricao.Text.ToString();
                    p.Valor = int.Parse(numericUpDownValor.Text.ToString());

                    p.add();


                    textBoxNome.Clear();
                    richTextBoxDescricao.Clear();
                    textBoxNome.Focus();


                    //listViewProduto.Clear();

                    getProdutos();

                    MessageBox.Show("Produto salvo com sucesso!!!");

                }
                else
                {
                    MessageBox.Show("Preencha todos so Campos Obrigatorios!!!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message);

            }
        }

        private bool validarForm()
        {
            bool FormValido;

            if (textBoxNome.Text == "" || textBoxNome.Text == null)
                FormValido = false;
            else if (richTextBoxDescricao.Text == "" || richTextBoxDescricao.Text == null)
                FormValido = false;
            else if (numericUpDownValor.Text == "" || numericUpDownValor.Text == null || int.Parse(numericUpDownValor.Text) <= 0)
                FormValido = false;
            else
                FormValido = true;

            return FormValido;
        }
        /*FormAddGuest formAddGuest = new FormAddGuest();
  //formAddGuest.MdiParent = this.MdiParent;
  formAddGuest.ShowDialog();
  listViewGuests.Items.Clear();
  PopulateListBox();  */
        private ListView getProdutos()
        {
            listViewProduto.Items.Clear();


            Produto p = new Produto();

            foreach (Produto row in p.getAll())
            {
                //Add Item to ListView.
                ListViewItem item = new ListViewItem(row.Id.ToString());
                item.SubItems.Add(row.Name.ToString());
                item.SubItems.Add(row.Valor.ToString());
                item.SubItems.Add(row.Descricao.ToString());

                listViewProduto.Items.Add(item);
            }
            return listViewProduto;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show(
                                    "Tem certeza da exclusão??", "DELETE",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) ==
                                    DialogResult.OK
                                    )
                {
                    if (listViewProduto.Items.Count > 0)
                    {
                        var Id = listViewProduto.SelectedItems[0].Text;

                        listViewProduto.Items.Remove(listViewProduto.SelectedItems[0]);
                        Produto p = new Produto();
                        p.remove(int.Parse(Id));

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message);

            }
        }

        private void btnUpdateProduto_Click(object sender, EventArgs e)
        {

            try
            {
                if (listViewProduto.Items.Count > 0)
                {

                    listViewProduto.SelectedItems[0].SubItems[1].Text = textBoxNome.Text;
                    listViewProduto.SelectedItems[0].SubItems[2].Text = numericUpDownValor.Text;
                    listViewProduto.SelectedItems[0].SubItems[3].Text = richTextBoxDescricao.Text;

                    var id = int.Parse(listViewProduto.SelectedItems[0].SubItems[0].Text);

                    var name = textBoxNome.Text;
                    var descricao = richTextBoxDescricao.Text;
                    var valor = numericUpDownValor.Text;

                    Produto p = new Produto();
                    p.Id = id;
                    p.Name = name;
                    p.Descricao = descricao;
                    p.Valor = int.Parse(valor);

                    p.update();

                    MessageBox.Show("Atualizado na base de dados!!!");
                    // getProdutos();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message);

            }
        }

        private void listViewProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewProduto_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewProduto.SelectedItems.Count > 0)
            {

                textBoxNome.Text = listViewProduto.SelectedItems[0].SubItems[1].Text;
                numericUpDownValor.Text = listViewProduto.SelectedItems[0].SubItems[2].Text;
                richTextBoxDescricao.Text = listViewProduto.SelectedItems[0].SubItems[3].Text;

            }
            else
            {
                return;
            }
        }

        private void numericUpDownValor_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}