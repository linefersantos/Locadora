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
    public partial class marca : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        public marca()
        {
            InitializeComponent();
        }


        private void dgvListarMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmarcaid.Text = dgvListarMarca.CurrentRow.Cells[0].Value.ToString();
            txtnomemarca.Text = dgvListarMarca.CurrentRow.Cells[1].Value.ToString();
            cbMarcaStatus.Text = dgvListarMarca.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnatualizarmarca_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int codigo;
                string nome;
                string status;

                codigo = int.Parse(txtmarcaid.Text);
                nome = txtnomemarca.Text;
                status = cbMarcaStatus.Text;

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sqlUpdateMarca = @"update tb_marca
                                      set TB_MARCA_NOME = @nome,
                                          tb_marca_status = @status  
                                      where tb_marca_id = @id;";

                MySqlCommand executacmdMySql_updateMarca = new MySqlCommand(sqlUpdateMarca, con);

                executacmdMySql_updateMarca.Parameters.AddWithValue("@id", codigo);
                executacmdMySql_updateMarca.Parameters.AddWithValue("@nome", nome);
                executacmdMySql_updateMarca.Parameters.AddWithValue("@status", status);

                executacmdMySql_updateMarca.ExecuteNonQuery();

                MessageBox.Show("Atualização realizada com sucesso!!"); 

                con.Close();

                string sql_seleciona_marca = "select * from tb_marca;";

                con.Open();
                MySqlCommand executacmdMySql_seleciona_marca = new MySqlCommand(sql_seleciona_marca, con);
                executacmdMySql_updateMarca.ExecuteNonQuery();

                DataTable tabela_marca = new DataTable();

                MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_seleciona_marca);
                da_marca.Fill(tabela_marca);
                con.Close();

                dgvListarMarca.DataSource = tabela_marca;
            }
            catch (Exception)
            {

                MessageBox.Show("Todos os campos devem estar preenchidos");
                txtmarcaid.Clear();
                txtnomemarca.Clear();
                cbMarcaStatus.Items.Clear();
            }
        }

        private void marca_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            txtmarcaid.ReadOnly = true;
            string sql_seleciona_marca = @"select tb_marca_id as ID, 
                                          tb_marca_nome as NOME, 
                                          tb_marca_status as STATUS
                                          from tb_marca;";

            con.Open();
            MySqlCommand executacmdMySql_seleciona_marca = new MySqlCommand(sql_seleciona_marca, con);
            executacmdMySql_seleciona_marca.ExecuteNonQuery();

            DataTable tabela_marca = new DataTable();

            MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_seleciona_marca);
            da_marca.Fill(tabela_marca);
            con.Close();

            dgvListarMarca.DataSource = tabela_marca;
        }

        private void btncadastromarca_Click(object sender, EventArgs e)
        {
            try
            {
               MySqlConnection con = new MySqlConnection(conexao);

            string nome = txtnomemarca.Text;
            string status = cbMarcaStatus.Text;

            string sqlInsertMarca = @" insert into tb_marca(tb_marca_nome)
                                    values(@marcaNome)";
            MySqlCommand executaInsertMarca = new MySqlCommand(sqlInsertMarca, con);

            executaInsertMarca.Parameters.AddWithValue("@marcaNome", nome);

                con.Open();

            executaInsertMarca.ExecuteNonQuery();

                string sql_seleciona_marca = "select * from tb_marca;";

                MySqlCommand executacmdMySql_seleciona_marca = new MySqlCommand(sql_seleciona_marca, con);
                executacmdMySql_seleciona_marca.ExecuteNonQuery();

                DataTable tabela_marca = new DataTable();
                MySqlDataAdapter da_marca = new MySqlDataAdapter(executacmdMySql_seleciona_marca);
                da_marca.Fill(tabela_marca);
                con.Close();

                dgvListarMarca.DataSource = tabela_marca;
                MessageBox.Show("Cadastrado!!");

                this.Close();
                new Veiculo().Close();

            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro" + erro);
            }

            txtmarcaid.Clear();
            txtnomemarca.Clear();


        }

        private void sairMarca_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem certeza que gostaria de sair?", "Sair", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.No)
            {
                // A message box fecha
            }
            else
            {
                this.Close();
                new Veiculo().Close();
            }
        }
    }
}
