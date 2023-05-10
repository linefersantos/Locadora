using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Tela_de_Login
{
    public partial class login : Form
    {
        DataTable dt = new DataTable();
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        public login()
        {
            InitializeComponent();
            txtsenha.UseSystemPasswordChar = true;
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
                
                if (exibir.Checked)
                {
                    txtsenha.UseSystemPasswordChar = false;
                }
                else
                {
                    txtsenha.UseSystemPasswordChar = true;
                }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string senha = txtsenha.Text;

            string sql = "SELECT * FROM tb_cliente WHERE TB_CLIENTE_EMAIL='" + email + "'AND TB_CLIENTE_SENHA='" + senha+"'";

            MySqlDataAdapter dp = new MySqlDataAdapter(sql, conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                menu menu = new menu();
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario e ou senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Guna2ImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem certeza que gostaria de sair?", "Sair", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.No)
            {
                // A message box fecha
            }
            else
            {
                this.Close();
                new cadastro().Close();
            }
        }

        private void lblcriar_Click(object sender, EventArgs e)
        {
            var form = new cadastro();
            form.Show();
        }

        private void login_Shown(object sender, EventArgs e)
        {
            FrmSplash frm = new FrmSplash();
            frm.ShowDialog();
        }



    }
}
