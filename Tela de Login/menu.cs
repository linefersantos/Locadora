using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Tela_de_Login
{
    public partial class menu : Form
    { 
        public menu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new cadastro().Show();
            this.Hide();
        }
        cadastro cadastro = new cadastro();
        cliente cliente = new cliente();
        login login = new login();
        Veiculo veiculo = new Veiculo();
        Funcionario funcionario = new Funcionario();
        locacao locacao = new locacao();

        private void btncliente_Click(object sender, EventArgs e)
        {
            cliente.TopLevel = false;
            cliente.AutoScroll = true;
            panel3.Controls.Clear();
            panel3.Controls.Add(cliente);
            cadastro.Hide();
            login.Hide();
            funcionario.Hide();
            locacao.Hide();
            cliente.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem certeza que gostaria de sair?", "Sair", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.No)
            {
                // A message box fecha
            }
            else
            {
                this.Close();
                new menu().Close();
                new login().Show();
            }
        }

        private void BtnVeiculo_Click(object sender, EventArgs e)
        {
            veiculo.TopLevel = false;
            veiculo.AutoScroll = true;
            panel3.Controls.Clear();
            panel3.Controls.Add(veiculo);
            cadastro.Hide();
            login.Hide();
            funcionario.Hide();
            cliente.Hide();
            locacao.Hide();
            veiculo.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            funcionario.TopLevel = false;
            funcionario.AutoScroll = true;
            panel3.Controls.Clear();
            panel3.Controls.Add(funcionario);
            cadastro.Hide();
            login.Hide();
            cliente.Hide();
            veiculo.Hide();
            locacao.Hide();
            funcionario.Show();
        }

        private void Btnsair_Click_1(object sender, EventArgs e)
        {
            locacao.TopLevel = false;
            locacao.AutoScroll = true;
            panel3.Controls.Clear();
            panel3.Controls.Add(locacao);
            cadastro.Hide();
            login.Hide();
            cliente.Hide();
            veiculo.Hide();
            funcionario.Hide();
            locacao.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem Certeza que gostaria de voltar?", "Voltar", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.No)
            {
                // A message box fecha
            }
            else
            {
                login f = new login();
                this.Hide();
                f.Show();
            }
        }

    }


}
