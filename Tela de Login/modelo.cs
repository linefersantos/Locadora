using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Tela_de_Login
{
    public partial class modelo : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        public modelo()
        {
            InitializeComponent();
        }
        private void dgvListarModelo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmodeloid.Text = dgvListarModelo.CurrentRow.Cells[0].Value.ToString();
            txtdescmodelo.Text = dgvListarModelo.CurrentRow.Cells[1].Value.ToString();
            cbModeloStatus.Text = dgvListarModelo.CurrentRow.Cells[2].Value.ToString();
        }
        private void btnatualizarmodelo_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int codigo;
                string desc;
                string status;

                codigo = int.Parse(txtmodeloid.Text);
                desc = txtdescmodelo.Text;
                status = cbModeloStatus.Text;

                MySqlConnection con = new MySqlConnection(conexao);
                con.Open();

                string sqlUpdateModelo = @"update tb_modelo
                                      set TB_MODELO_DESC = @modelo_desc,
                                      tb_modelo_status = @modeloStatus
                                      where TB_MODELO_ID = @id;";

                MySqlCommand executacmdMySql_updateModelo = new MySqlCommand(sqlUpdateModelo, con);

                executacmdMySql_updateModelo.Parameters.AddWithValue("@id", codigo);
                executacmdMySql_updateModelo.Parameters.AddWithValue("@modelo_desc", desc);
                executacmdMySql_updateModelo.Parameters.AddWithValue("modeloStatus", status);

                executacmdMySql_updateModelo.ExecuteNonQuery();

                MessageBox.Show("Atualização realizada com sucesso!!");

                con.Close();

                string sql_seleciona_modelo = "select * from tb_modelo;";

                con.Open();
                MySqlCommand executacmdMySql_seleciona_modelo = new MySqlCommand(sql_seleciona_modelo, con);
                executacmdMySql_updateModelo.ExecuteNonQuery();

                DataTable tabela_modelo = new DataTable();

                MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_seleciona_modelo);
                da_modelo.Fill(tabela_modelo);
                con.Close();

                dgvListarModelo.DataSource = tabela_modelo;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Todos os campos devem estar preenchidos" + erro);
                txtdescmodelo.Clear();
                txtmodeloid.Clear();
                cbModeloStatus.Items.Clear();
            }
        }


        private void btncadastromodelo_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                string nome = txtdescmodelo.Text;
                string status = cbModeloStatus.Text;

                string sqlInsertModelo = @"
                                        insert into tb_modelo (TB_MODELO_DESC)
                                        values(@modelo_desc);";

                MySqlCommand executaInsertModelo = new MySqlCommand(sqlInsertModelo, con);

                executaInsertModelo.Parameters.AddWithValue("@modelo_desc", nome);

                con.Open();
                executaInsertModelo.ExecuteNonQuery();

                string sql_select_modelo = "select * from tb_modelo;";

                MySqlCommand executacmdMySql_select_modelo = new MySqlCommand(sql_select_modelo, con);
                executacmdMySql_select_modelo.ExecuteNonQuery();

                DataTable tabela_modelo = new DataTable();

                MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_select_modelo);
                da_modelo.Fill(tabela_modelo);
                con.Close();

                dgvListarModelo.DataSource = tabela_modelo;
                MessageBox.Show("Cadastrado!!");

                this.Close();
                new Veiculo().Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro" + erro);
            }

            txtmodeloid.Clear();
            txtdescmodelo.Clear();
            cbModeloStatus.Items.Clear();

        }

        private void modelo_Load_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            string sql_seleciona_modelo = @"select tb_modelo_id as ID,
                                          tb_modelo_desc as NOME,
                                          tb_modelo_status as STATUS
                                          from tb_modelo;";

            con.Open();
            MySqlCommand executacmdMySql_seleciona_modelo = new MySqlCommand(sql_seleciona_modelo, con);
            executacmdMySql_seleciona_modelo.ExecuteNonQuery();

            DataTable tabela_modelo = new DataTable();

            MySqlDataAdapter da_modelo = new MySqlDataAdapter(executacmdMySql_seleciona_modelo);
            da_modelo.Fill(tabela_modelo);
            con.Close();

            dgvListarModelo.DataSource = tabela_modelo;
        }

        private void sairModelo_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem Certeza que gostaria de voltar?", "Voltar", MessageBoxButtons.YesNo);
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
