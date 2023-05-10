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
using System.Globalization;


namespace Tela_de_Login
{
    public partial class Funcionario : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        public Funcionario()
        {
            InitializeComponent();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            cbCargo.Text = "Selecione um cargo";
            this.Controls.Add(cbCargo);

        MySqlConnection con = new MySqlConnection(conexao);
            string sql_select_funcionario = @"SELECT TB_FUNCIONARIO.TB_FUNCIONARIO_ID AS ID, TB_FUNCIONARIO.TB_FUNCIONARIO_NOME AS NOME, TB_FUNCIONARIO.TB_FUNCIONARIO_TEL AS TELEFONE,
                                             TB_FUNCIONARIO.TB_FUNCIONARIO_DT_CONTRATO AS 'DATA DE CONTRATO', TB_CARGO.TB_CARGO_NOME as CARGO
                                             FROM TB_FUNCIONARIO 
                                             INNER JOIN TB_CARGO ON TB_FUNCIONARIO.TB_CARGO_ID = TB_CARGO.TB_CARGO_ID;";

            con.Open();
            MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
            executacmdMySql_select_funcionario.ExecuteNonQuery();

            DataTable tabela_funcionario = new DataTable();

            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
            da_funcionario.Fill(tabela_funcionario);
            con.Close();

            dgvListarFuncionario.DataSource = tabela_funcionario;

            string sqlSelectCbCargo = "select * from tb_cargo order by tb_cargo_id desc;";
            MySqlDataAdapter daCargo = new MySqlDataAdapter(sqlSelectCbCargo, con);
            DataTable dtResultadoCargo = new DataTable();
            daCargo.Fill(dtResultadoCargo);
            cbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCargo.DataSource = dtResultadoCargo;
            cbCargo.ValueMember = "tb_cargo_id";
            cbCargo.DisplayMember = "tb_cargo_nome";
            cbCargo.SelectedItem = null;
        }

        private void dgvListarFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgvListarFuncionario.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgvListarFuncionario.CurrentRow.Cells[1].Value.ToString();
            txttel.Text = dgvListarFuncionario.CurrentRow.Cells[2].Value.ToString();
            mtxtDtContrato.Text = dgvListarFuncionario.CurrentRow.Cells[3].Value.ToString();
            cbCargo.Text = dgvListarFuncionario.CurrentRow.Cells[4].Value.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                string nome;
                string telefone;
                string datacont;
                int cargo;

                nome = txtnome.Text;
                telefone = txttel.Text;
                datacont = mtxtDtContrato.Text.ToString();
                DateTime datCad = DateTime.ParseExact(datacont, "dd/MM/yyyy", null);
                cargo = int.Parse(cbCargo.SelectedValue.ToString());

                string sql_insert = @"insert into tb_funcionario
                                        (
                                            TB_FUNCIONARIO_NOME,
                                            TB_FUNCIONARIO_TEL,
                                            TB_FUNCIONARIO_DT_CONTRATO,
                                            TB_CARGO_ID
                                        )
                                  values
                                        (
                                            @FUNCIONARIO_NOME,
                                            @FUNCIONARIO_TEL,
                                            @FUNCIONARIO_DT_CONTRATO,
                                            @CARGO_ID
                                        );";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@FUNCIONARIO_NOME", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@FUNCIONARIO_TEL", telefone);
                executacmdMySql_insert.Parameters.AddWithValue("@FUNCIONARIO_DT_CONTRATO", datCad);
                executacmdMySql_insert.Parameters.AddWithValue("@CARGO_ID", cargo);

                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cadastrado");

                string sql_select_funcionario = "select * from tb_funcionario;";

                con.Open();
                MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
                executacmdMySql_select_funcionario.ExecuteNonQuery();

                DataTable tabela_funcionario = new DataTable();

                MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
                da_funcionario.Fill(tabela_funcionario);
                con.Close();

                dgvListarFuncionario.DataSource = tabela_funcionario;


            }
            catch
            {
                MessageBox.Show("Preencha todos os campos!!");
            }

            txtcodigo.Clear();
            txtnome.Clear();
            txttel.Clear();
            mtxtDtContrato.Clear();
        }

        private void btnatu_Click(object sender, EventArgs e)
        {
            int codigo, cargo;
            string nome, telefone, datacont;

            codigo = int.Parse(txtcodigo.Text);
            nome = txtnome.Text;
            telefone = txttel.Text;
            datacont = mtxtDtContrato.Text.ToString();
            DateTime datCad = DateTime.ParseExact(datacont, "dd/MM/yyyy", null);
            cargo = int.Parse(cbCargo.SelectedValue.ToString()); ;


            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            string sqlUpdateCliente = @"update tb_funcionario set tb_funcionario_nome = @funcionarioNome,
                                                              tb_funcionario_tel = @funcionarioTel,
                                                              tb_funcionario_dt_contrato = @funcionarioDtCont,
                                                              tb_cargo_id = @cargo_id
                                                                
                                                              where tb_funcionario_id = @id;
                                                              ";
            MySqlCommand executaMySqlUpdateCliente = new MySqlCommand(sqlUpdateCliente, con);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@id", codigo);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@funcionarioNome", nome);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@funcionarioTel", telefone);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@funcionarioDtCont", datCad);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@cargo_id", cargo);

            executaMySqlUpdateCliente.ExecuteNonQuery();


            MessageBox.Show("Atualização realizada com sucesso!!");

            con.Close();

            string sql_select_funcionario = "select * from tb_funcionario;";

            con.Open();
            MySqlCommand executacmdMySql_select_funcionario = new MySqlCommand(sql_select_funcionario, con);
            executacmdMySql_select_funcionario.ExecuteNonQuery();

            DataTable tabela_funcionario = new DataTable();

            MySqlDataAdapter da_funcionario = new MySqlDataAdapter(executacmdMySql_select_funcionario);
            da_funcionario.Fill(tabela_funcionario);
            con.Close();

            dgvListarFuncionario.DataSource = tabela_funcionario;

            DateTime dataca = DateTime.ParseExact(datacont, "dd/MM/yyyy", null);
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);


            string sqlSelectCbCargo = "select * from tb_cargo order by tb_cargo_id desc;";
            MySqlDataAdapter daCargo = new MySqlDataAdapter(sqlSelectCbCargo, con);
            DataTable dtResultadoCargo = new DataTable();
            daCargo.Fill(dtResultadoCargo);

            DataRow dr = dtResultadoCargo.NewRow();
            dr["TB_CARGO_ID"] = 0;
            dr["TB_CARGO_NOME"] = "Novo...";

            dtResultadoCargo.Rows.InsertAt(dr, 0);

            string txtCbCargo = cbCargo.Text;

            if (txtCbCargo == "Novo...")
            {
                cargo cargo = new cargo();
                cargo.ShowDialog();

            }
        }

        private void lblCargo_Click(object sender, EventArgs e)
        {
            lblCargo.Hide();
            cbCargo.Focus();
            cbCargo.DroppedDown = true;
        }

        private void cbCargo_Click(object sender, EventArgs e)
        {
            lblCargo.Hide();
            cbCargo.Focus();
            cbCargo.DroppedDown = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Hide();
            mtxtDtContrato.Focus();
        }
    }
}

