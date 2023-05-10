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
    public partial class locacao : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        public locacao()
        {
            InitializeComponent();
        }

        private void locacao_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sqlSelectLocacao = @"select tb_locacao.tb_locacao_id as ID, tb_locacao.tb_locacao_tipo as 'TIPO DE LOCAÇÃO', tb_locacao_valor as 'VALOR',
                                        tb_locacao.tb_locacao_dt_inicio as 'DATA DE INICIO', tb_locacao.tb_locacao_dt_fim as 'DATA FINAL', tb_cliente.tb_cliente_nome as CLIENTE, tb_funcionario.tb_funcionario_nome as FUNCIONARIO, tb_automovel.tb_automovel_nome as VEICULO
                                        from tb_locacao inner join tb_cliente on tb_locacao.tb_cliente_id = tb_cliente.tb_cliente_id
                                        inner join tb_funcionario on tb_locacao.tb_funcionario_id = tb_funcionario.tb_funcionario_id
                                        inner join tb_automovel on tb_locacao.tb_automovel_id = tb_automovel.tb_automovel_id;";
            con.Open();
            MySqlCommand executaSelectLocacao = new MySqlCommand(sqlSelectLocacao, con);
            executaSelectLocacao.ExecuteNonQuery();

            DataTable tabela_locacao = new DataTable();
            MySqlDataAdapter da_locacao = new MySqlDataAdapter(executaSelectLocacao);
            da_locacao.Fill(tabela_locacao);

            con.Close();

            dgvListarlocacao.DataSource = tabela_locacao;

            string sqlSelectCbFuncionario = "select * from tb_funcionario order by tb_funcionario_id desc;";
            MySqlDataAdapter daFuncionario = new MySqlDataAdapter(sqlSelectCbFuncionario, con);
            DataTable dtResultadoFuncionario = new DataTable();
            daFuncionario.Fill(dtResultadoFuncionario);
            cbidFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbidFuncionario.DataSource = dtResultadoFuncionario;
            cbidFuncionario.ValueMember = "tb_funcionario_id";
            cbidFuncionario.DisplayMember = "tb_funcionario_nome";
            cbidFuncionario.SelectedItem = null;

            string sqlSelectCbCliente = "select * from tb_cliente order by tb_cliente_id desc;";
            MySqlDataAdapter daCliente = new MySqlDataAdapter(sqlSelectCbCliente, con);
            DataTable dtResultadoCliente = new DataTable();
            daCliente.Fill(dtResultadoCliente);
            cbidCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbidCliente.DataSource = dtResultadoCliente;
            cbidCliente.ValueMember = "tb_cliente_id";
            cbidCliente.DisplayMember = "tb_cliente_nome";
            cbidCliente.SelectedItem = null;


            string sqlSelectCbAutomovel = "select * from tb_automovel order by tb_automovel_id desc;";
            MySqlDataAdapter daAutomovel = new MySqlDataAdapter(sqlSelectCbAutomovel, con);
            DataTable dtResultadoAutomovel = new DataTable();
            daAutomovel.Fill(dtResultadoAutomovel);
            cbidVeiculo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbidVeiculo.DataSource = dtResultadoAutomovel;
            cbidVeiculo.ValueMember = "tb_automovel_id";
            cbidVeiculo.DisplayMember = "tb_automovel_nome";
            cbidVeiculo.SelectedItem = null;
        }

        private void DgvListarlocacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoLocacao.Text = dgvListarlocacao.CurrentRow.Cells[0].Value.ToString();
            cbTipo.Text = dgvListarlocacao.CurrentRow.Cells[1].Value.ToString();
            txtValorLocacao.Text = dgvListarlocacao.CurrentRow.Cells[2].Value.ToString();
            mtxtDtIníciolocacao.Text = dgvListarlocacao.CurrentRow.Cells[3].Value.ToString();
            mtxtDtFimLocacao.Text = dgvListarlocacao.CurrentRow.Cells[4].Value.ToString();
            cbidCliente.Text = dgvListarlocacao.CurrentRow.Cells[5].Value.ToString();
            cbidFuncionario.Text = dgvListarlocacao.CurrentRow.Cells[6].Value.ToString();
            cbidVeiculo.Text = dgvListarlocacao.CurrentRow.Cells[7].Value.ToString();

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);
                string tipo;
                double valor;
                string dataincio;
                string dafim;
                int idFuncio, idCliente, idVeiculo;

                tipo = cbTipo.Text;
                valor = double.Parse(txtValorLocacao.Text);
                dataincio = mtxtDtIníciolocacao.Text.ToString();
                dafim = mtxtDtFimLocacao.Text.ToString();
                DateTime dataini = DateTime.ParseExact(dataincio, "dd/MM/yyyy", null);
                DateTime datafim = DateTime.ParseExact(dafim, "dd/MM/yyyy", null);
                idFuncio = int.Parse(cbidFuncionario.SelectedValue.ToString());
                idCliente = int.Parse(cbidCliente.SelectedValue.ToString());
                idVeiculo = int.Parse(cbidVeiculo.SelectedValue.ToString());

                con.Open();

                string sqlInsertLocacao = @"insert tb_locacao
                                        (
                                          TB_LOCACAO_TIPO,
                                          TB_LOCACAO_VALOR,
                                          TB_LOCACAO_DT_INICIO,
                                          TB_LOCACAO_DT_FIM,
                                          TB_CLIENTE_ID,
                                          TB_FUNCIONARIO_ID,
                                          TB_AUTOMOVEL_ID
                                        )
                                   values
                                       (
                                            @tipo,
                                            @valor,
                                            @dtinicio,
                                            @dtfim,
                                            @clienteid,
                                            @funcionarioid,
                                            @automovelid
                                        )";

                MySqlCommand executacmdMySql_insertLocacao = new MySqlCommand(sqlInsertLocacao, con);

                executacmdMySql_insertLocacao.Parameters.AddWithValue("@tipo", tipo);
                executacmdMySql_insertLocacao.Parameters.AddWithValue("@valor", valor);
                executacmdMySql_insertLocacao.Parameters.AddWithValue("@dtinicio", dataini);
                executacmdMySql_insertLocacao.Parameters.AddWithValue("@dtfim", datafim);
                executacmdMySql_insertLocacao.Parameters.AddWithValue("@clienteid", idCliente);
                executacmdMySql_insertLocacao.Parameters.AddWithValue("@funcionarioid", idFuncio);
                executacmdMySql_insertLocacao.Parameters.AddWithValue("automovelid", idVeiculo);


                executacmdMySql_insertLocacao.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizada com sucesso!!");

                con.Close();

                string sql_seleciona_locacao = "select * from tb_locacao;";

                con.Open();
                MySqlCommand executacmdMySql_seleciona_locacao = new MySqlCommand(sql_seleciona_locacao, con);
                executacmdMySql_insertLocacao.ExecuteNonQuery();

                DataTable tabela_locacao = new DataTable();

                MySqlDataAdapter da_locacao = new MySqlDataAdapter(executacmdMySql_seleciona_locacao);
                da_locacao.Fill(tabela_locacao);
                con.Close();

                dgvListarlocacao.DataSource = tabela_locacao;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnatu_Click(object sender, EventArgs e)
        { 
                int codigo;
                string tipo;
                string valor;
                string dataincio;
                string dafim;
                int idFuncio, idCliente, idVeiculo;


                codigo = int.Parse(txtCodigoLocacao.Text);
                tipo = cbTipo.Text;
                valor = txtValorLocacao.Text;
                dataincio = mtxtDtIníciolocacao.Text.ToString();
                dafim = mtxtDtFimLocacao.Text.ToString();
                DateTime dataini = DateTime.ParseExact(dataincio, "dd/MM/yyyy", null);
                DateTime datafim = DateTime.ParseExact(dafim, "dd/MM/yyyy", null);
                idFuncio = int.Parse(cbidFuncionario.SelectedValue.ToString());
                idCliente = int.Parse(cbidCliente.SelectedValue.ToString());
                idVeiculo = int.Parse(cbidVeiculo.SelectedValue.ToString());

            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();

                string sqlUpdateLocacao = @"update tb_locacao set 
                                          TB_LOCACAO_TIPO = @tipo,
                                          TB_LOCACAO_VALOR = @valor,
                                          TB_LOCACAO_DT_INICIO = @dtinicio,
                                          TB_LOCACAO_DT_FIM = @dtfim,
                                          TB_CLIENTE_ID = @clienteid,
                                          TB_FUNCIONARIO_ID = @funcionarioid,
                                          TB_AUTOMOVEL_ID = @automovelid
 
                                      where tb_locacao_id = @id;
                                               ";

                MySqlCommand executacmdMySql_updateLocacao = new MySqlCommand(sqlUpdateLocacao, con);

                executacmdMySql_updateLocacao.Parameters.AddWithValue("@id", codigo);
                executacmdMySql_updateLocacao.Parameters.AddWithValue("@tipo", tipo);
                executacmdMySql_updateLocacao.Parameters.AddWithValue("@valor", valor.Replace(".", "").Replace(",", "."));
                executacmdMySql_updateLocacao.Parameters.AddWithValue("@dtinicio", dataini);
                executacmdMySql_updateLocacao.Parameters.AddWithValue("@dtfim", datafim);
                executacmdMySql_updateLocacao.Parameters.AddWithValue("@clienteid", idCliente);
                executacmdMySql_updateLocacao.Parameters.AddWithValue("@funcionarioid", idFuncio);
                executacmdMySql_updateLocacao.Parameters.AddWithValue("automovelid", idVeiculo);


                executacmdMySql_updateLocacao.ExecuteNonQuery();

                MessageBox.Show("Atualização realizada com sucesso!!");

                con.Close();

                string sql_seleciona_locacao = "select * from tb_locacao;";

                con.Open();
                MySqlCommand executacmdMySql_seleciona_locacao = new MySqlCommand(sql_seleciona_locacao, con);
                executacmdMySql_updateLocacao.ExecuteNonQuery();

                DataTable tabela_locacao = new DataTable();

                MySqlDataAdapter da_locacao = new MySqlDataAdapter(executacmdMySql_seleciona_locacao);
                da_locacao.Fill(tabela_locacao);
                con.Close();

                dgvListarlocacao.DataSource = tabela_locacao;
        }

        private void lblValorlocacao_Click(object sender, EventArgs e)
        {
            lblValorlocacao.Hide();
            txtValorLocacao.Focus();
        }

        private void lblTipoLocacao_Click(object sender, EventArgs e)
        {
            lblTipoLocacao.Hide();
            cbTipo.Focus();
            cbTipo.DroppedDown = true;
        }

        private void txtValorLocacao_Click(object sender, EventArgs e)
        {
            lblValorlocacao.Hide();
            txtValorLocacao.Focus();
        }

        private void cbTipo_Click(object sender, EventArgs e)
        {
            lblTipoLocacao.Hide();
            cbTipo.Focus();
            cbTipo.DroppedDown = true;
        }

        private void lblNomeFuncionario_Click(object sender, EventArgs e)
        {
            lblNomeFuncionario.Hide();
            cbidFuncionario.Focus();
            cbidFuncionario.DroppedDown = true;
        }
        private void cbidFuncionario_Click(object sender, EventArgs e)
        {
            lblNomeFuncionario.Hide();
            cbidFuncionario.Focus();
            cbidFuncionario.DroppedDown = true;
        }
        private void lblNomeCliente_Click(object sender, EventArgs e)
        {
            lblNomeCliente.Hide();
            cbidCliente.Focus();
            cbidCliente.DroppedDown = true;
        }

        private void cbidCliente_Click(object sender, EventArgs e)
        {
            lblNomeCliente.Hide();
            cbidCliente.Focus();
            cbidCliente.DroppedDown = true;
        }

        private void lblNomeVeiculo_Click(object sender, EventArgs e)
        {
            lblNomeVeiculo.Hide();
            cbidVeiculo.Focus();
            cbidVeiculo.DroppedDown = true;
        }

        private void cbidVeiculo_Click(object sender, EventArgs e)
        {
            lblNomeVeiculo.Hide();
            cbidVeiculo.Focus();
            cbidVeiculo.DroppedDown = true;
        }

        private void lblInicioLocacao_Click(object sender, EventArgs e)
        {
            lblInicioLocacao.Hide();
            mtxtDtIníciolocacao.Focus();
        }
        private void mtxtDtIníciolocacao_Click(object sender, EventArgs e)
        {
            lblInicioLocacao.Hide();
            mtxtDtIníciolocacao.Focus();
        }
        private void lblFimLocacao_Click(object sender, EventArgs e)
        {
            lblFimLocacao.Hide();
            mtxtDtFimLocacao.Focus();
        }

        private void mtxtDtFimLocacao_Click(object sender, EventArgs e)
        {
            lblFimLocacao.Hide();
            mtxtDtFimLocacao.Focus();
        }
    }
}
    

