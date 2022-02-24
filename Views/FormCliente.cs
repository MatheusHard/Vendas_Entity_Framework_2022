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
using static Vendas_2022._1.Utils.Utils;


namespace Vendas_2022._1.Views
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
            getClientes();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            try
            {

                if (validarForm())
                {
                    Cliente cliente = new Cliente();

                    cliente.Name = textBoxNome.Text.ToString();
                    cliente.Cpf = textBoxCpf.Text.ToString();
                    cliente.Telefone = textBoxTelefone.Text.ToString();

                    cliente.Password = cryptographyPass(textBoxPasword.Text);
                    cliente.Login = textBoxUser.Text;
                    cliente.Perfil = checkBoxAdminOrUser.Checked;

                    cliente.add();

                    // listViewCliente.Clear();

                    textBoxCpf.Clear();
                    textBoxTelefone.Clear();
                    textBoxNome.Focus();

                    MessageBox.Show("CLiente salvo com sucesso!!!");

                }
                else
                {
                    MessageBox.Show("Preencha todos so Campos Obrigatorios!!!");
                }




                getClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message);

            }

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnRemoverCliente_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show(
                                    "Tem certeza da exclusão??", "DELETE",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) ==
                                    DialogResult.OK
                                    )
                {
                    if (listViewCliente.Items.Count > 0)
                    {
                        var Id = listViewCliente.SelectedItems[0].Text;

                        listViewCliente.Items.Remove(listViewCliente.SelectedItems[0]);
                        Cliente cliente = new Cliente();
                        cliente.remove(int.Parse(Id));

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message);

            }
        }

        private void getClientes()
        {
            Cliente cliente = new Cliente();

            foreach (Cliente row in cliente.getAll())
            {
                //Add Item to ListView.
                ListViewItem item = new ListViewItem(row.Id.ToString());
                item.SubItems.Add(row.Name.ToString());
                item.SubItems.Add(row.Cpf.ToString());
                item.SubItems.Add(row.Telefone.ToString());
                if (row.Perfil)
                    item.SubItems.Add("Admin");
                else
                    item.SubItems.Add("User");

                if (row.Login != null)
                    item.SubItems.Add(row.Login.ToString());

                //item.SubItems.Add(row.Password.ToString());
                listViewCliente.Items.Add(item);
            }
        }

        private bool validarForm()
        {
            bool FormValido;

            if (textBoxCpf.Text == "" || textBoxCpf.Text == null)
                FormValido = false;
            else if (textBoxNome.Text == "" || textBoxNome.Text == null)
                FormValido = false;
            else if (textBoxTelefone.Text == "" || textBoxTelefone.Text == null)
                FormValido = false;
            else if (textBoxUser.Text == "" || textBoxUser.Text == null)
                FormValido = false;
            else if (textBoxPasword.Text == "" || textBoxPasword.Text == null)
                FormValido = false;
            else
                FormValido = true;

            return FormValido;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCliente.Items.Count > 0)
                {

                    listViewCliente.SelectedItems[0].SubItems[1].Text = textBoxNome.Text;
                    listViewCliente.SelectedItems[0].SubItems[2].Text = textBoxCpf.Text;
                    listViewCliente.SelectedItems[0].SubItems[3].Text = textBoxTelefone.Text;
                    //listViewCliente.SelectedItems[0].SubItems[5].Text = textBoxTelefone.Text;


                    var id = int.Parse(listViewCliente.SelectedItems[0].SubItems[0].Text);
                    var name = textBoxNome.Text;
                    var cpf = textBoxCpf.Text;
                    var tel = textBoxTelefone.Text;
                    var pass = textBoxPasword.Text;
                    var login = textBoxUser.Text;
                    var perfil = checkBoxAdminOrUser.Checked;

                    Cliente cliente = new Cliente();


                    cliente.Id = id;
                    cliente.Name = name;
                    cliente.Cpf = cpf;
                    cliente.Telefone = tel;

                    var c = cliente.getCliente(id);

                    if (pass != "" && pass != null)
                        cliente.Password = cryptographyPass(pass);
                    else
                        cliente.Password = c.Password;


                    cliente.Perfil = perfil;
                    cliente.Login = login;


                    cliente.update();

                    MessageBox.Show("Atualizado na base de dados!!!");
                    getClientes();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message);

            }
        }

        private void listViewCliente_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewCliente.SelectedItems.Count > 0)
            {

                textBoxNome.Text = listViewCliente.SelectedItems[0].SubItems[1].Text;
                textBoxCpf.Text = listViewCliente.SelectedItems[0].SubItems[2].Text;
                textBoxTelefone.Text = listViewCliente.SelectedItems[0].SubItems[3].Text;

                if (listViewCliente.SelectedItems[0].SubItems[4].Text == "Admin")
                    checkBoxAdminOrUser.Checked = true;
                else
                    checkBoxAdminOrUser.Checked = false;

                textBoxUser.Text = listViewCliente.SelectedItems[0].SubItems[5].Text;
                //textBoxPasword.Text = listViewCliente.SelectedItems[0].SubItems[6].Text;

            }
            else
            {
                return;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


