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
using System.IO;

namespace Tela_de_Login
{
    public partial class cargo : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        public cargo()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem Certeza que gostaria de voltar?", "Voltar", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.No)
            {
                // A message box fecha
            }
            else
            {
                this.Close();
                new menu().Show();
            }
        }

        private void btncadastroc_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string cargo;
                string status;

                cargo = txtcargonome.Text;
                status = cbStatus.Text;

                string sql_insert = @"insert into tb_cargo
                    (
                     TB_CARGO_NOME
                     )
                     values
                    (
                    @CARGO_NOME
                    );";

            MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@CARGO_NOME", cargo);

                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();

                string sql_select_cargo = "select * from tb_cargo;";

                MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
                executacmdMySql_select_cargo.ExecuteNonQuery();

                DataTable tabela_cargo = new DataTable();

                MySqlDataAdapter da_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
                da_cargo.Fill(tabela_cargo);
                con.Close();

                dgvListarCargo.DataSource = tabela_cargo;
                MessageBox.Show("Cadastrado!!");

                this.Close();
                new Funcionario().Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
            }

            txtcargoid.Clear();
            txtcargonome.Clear();
        }

        private void cargo_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            string sql_select_cargo = @"select tb_cargo_id as ID, 
                                      tb_cargo_nome as NOME, 
                                      tb_cargo_status as STATUS
                                      from tb_cargo;";

            con.Open();
            MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
            executacmdMySql_select_cargo.ExecuteNonQuery();

            DataTable tabela_cargo = new DataTable();

            MySqlDataAdapter da_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
            da_cargo.Fill(tabela_cargo);
            con.Close();

            dgvListarCargo.DataSource = tabela_cargo;
        }

        private void dgvListarCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcargoid.Text = dgvListarCargo.CurrentRow.Cells[0].Value.ToString();
            txtcargonome.Text = dgvListarCargo.CurrentRow.Cells[1].Value.ToString();
            cbStatus.Text = dgvListarCargo.CurrentRow.Cells[2].Value.ToString();

        }


        private void btnatualizarc_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo;
                string nome;
                string status;

                codigo = int.Parse(txtcargoid.Text);
                nome = txtcargonome.Text;
                status = cbStatus.Text;

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sql_update_cargo = @"update tb_cargo
                                        set TB_CARGO_NOME = @nome,
                                        TB_CARGO_STATUS = @status
                                        where tb_cargo_id = @id;";

                MySqlCommand executacmdMySql_update_cargo = new MySqlCommand(sql_update_cargo, con);

                executacmdMySql_update_cargo.Parameters.AddWithValue("@id", codigo);
                executacmdMySql_update_cargo.Parameters.AddWithValue("@nome", nome);
                executacmdMySql_update_cargo.Parameters.AddWithValue("@status", status);

                executacmdMySql_update_cargo.ExecuteNonQuery();

                MessageBox.Show("Atualização realizada com sucesso!!");
                con.Close();


                string sql_select_cargo = "select * from tb_cargo;";

                con.Open();
                MySqlCommand executacmdMySql_select_cargo = new MySqlCommand(sql_select_cargo, con);
                executacmdMySql_select_cargo.ExecuteNonQuery();

                DataTable tabela_cargo = new DataTable();

                MySqlDataAdapter da_cargo = new MySqlDataAdapter(executacmdMySql_select_cargo);
                da_cargo.Fill(tabela_cargo);
                con.Close();

                dgvListarCargo.DataSource = tabela_cargo;

            }
            catch (Exception)
            {

                MessageBox.Show("Todos os campos devem estar preenchidos");

            }

            txtcargoid.Clear();
            txtcargonome.Clear();
        }



        private void sairCargo_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem certeza que gostaria de sair?", "Sair", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.No)
            {
                // A message box fecha
            }
            else
            {
                this.Close();
                new Funcionario().Close();
            }
        }
    }
}