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
    public partial class Veiculo : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;
        public Veiculo()
        {
            InitializeComponent();
        }



        private void Veiculo_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            string sql_select_veiculo = @"select tb_automovel_id as ID, tb_automovel_nome as NOME, tb_automovel_ano_fab as 'ANO DE FABRICAÇÃO', tb_automovel_cor as COR,
                                            tb_automovel_km as QUILOMETRAGEM, tb_automovel_valor_d as 'VALOR DA DIÁRIA', tb_automovel_status as STATUS,
                                            tb_marca_nome as MARCA, tb_modelo_desc as MODELO from tb_automovel
                                            inner join tb_marca on tb_automovel.tb_marca_id = tb_marca.tb_marca_id
                                            inner join tb_modelo on tb_automovel.tb_modelo_id = tb_modelo.tb_modelo_id;";

            con.Open();
            MySqlCommand executacmdMySql_select_veiculo = new MySqlCommand(sql_select_veiculo, con);
            executacmdMySql_select_veiculo.ExecuteNonQuery();

            DataTable tabela_veiculo = new DataTable();

            MySqlDataAdapter da_veiculo = new MySqlDataAdapter(executacmdMySql_select_veiculo);
            da_veiculo.Fill(tabela_veiculo);
            con.Close();

            dgvListarVeiculo.DataSource = tabela_veiculo;

            string sqlSelectCmbMarca = @"select * from tb_marca order by tb_marca_id desc;";
            MySqlDataAdapter daMarca = new MySqlDataAdapter(sqlSelectCmbMarca, con);
            DataTable dtResultadoMarca = new DataTable();
            daMarca.Fill(dtResultadoMarca);
            cbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMarca.DataSource = dtResultadoMarca;
            cbMarca.ValueMember = "tb_marca_id";
            cbMarca.DisplayMember = "tb_marca_nome";
            cbMarca.SelectedItem = null;

            string sqlSelectCbModelo = "select * from tb_modelo order by tb_modelo_id desc;";
            MySqlDataAdapter daModelo = new MySqlDataAdapter(sqlSelectCbModelo, con);
            DataTable dtResultadoModelo = new DataTable();
            daModelo.Fill(dtResultadoModelo);
            cbModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModelo.DataSource = dtResultadoModelo;
            cbModelo.ValueMember = "tb_modelo_id";
            cbModelo.DisplayMember = "tb_modelo_desc";
            cbModelo.SelectedItem = null;

        }

        private void dgvListarVeiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtVeiculoId.Text = dgvListarVeiculo.CurrentRow.Cells[0].Value.ToString();
            txtNomeVeiculo.Text = dgvListarVeiculo.CurrentRow.Cells[1].Value.ToString();
            txtAnoFab.Text = dgvListarVeiculo.CurrentRow.Cells[2].Value.ToString();
            txtCorVeiculo.Text = dgvListarVeiculo.CurrentRow.Cells[3].Value.ToString();
            txtKmVeiculo.Text = dgvListarVeiculo.CurrentRow.Cells[4].Value.ToString();
            txtValorVeiculo.Text = dgvListarVeiculo.CurrentRow.Cells[5].Value.ToString();
            cbStatus.Text = dgvListarVeiculo.CurrentRow.Cells[6].Value.ToString();
            cbMarca.Text = dgvListarVeiculo.CurrentRow.Cells[7].Value.ToString();
            cbModelo.Text = dgvListarVeiculo.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnCadVeiculo_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection con = new MySqlConnection(conexao);
                int ano;
                string nome, cor, status, valor;
                int marca, modelo;
                Double KM;

                nome = txtNomeVeiculo.Text;
                ano = int.Parse(txtAnoFab.Text);
                cor = txtCorVeiculo.Text;
                KM = double.Parse(txtKmVeiculo.Text);
                valor = txtValorVeiculo.Text;
                status = cbStatus.Text;
                marca = int.Parse(cbMarca.SelectedValue.ToString());
                modelo = int.Parse(cbModelo.SelectedValue.ToString());


                string sql_insertAutomovel = @"insert into tb_automovel
                                        (
                                            tb_automovel_nome,
                                            tb_automovel_ano_fab,
                                            tb_automovel_cor,
                                            tb_automovel_km,
                                            tb_automovel_valor_d,
                                            tb_automovel_status,
                                            tb_marca_id,
                                            tb_modelo_id 

                                        )
                                  values
                                        (
                                            @Automovel_nome,
                                            @Automovel_ano,
                                            @Automovel_cor,
                                            @Automovel_km,
                                            @Automovel_valor,
                                            @Automovel_status,
                                            @Automovel_marca,
                                            @Automovel_modelo
                                        );";

                MySqlCommand executaMySqlInsertAutomovel = new MySqlCommand(sql_insertAutomovel, con);
                executaMySqlInsertAutomovel.Parameters.AddWithValue("@Automovel_nome", nome);
                executaMySqlInsertAutomovel.Parameters.AddWithValue("@Automovel_ano", ano);
                executaMySqlInsertAutomovel.Parameters.AddWithValue("@Automovel_cor", cor);
                executaMySqlInsertAutomovel.Parameters.AddWithValue("@Automovel_km", KM);
                executaMySqlInsertAutomovel.Parameters.AddWithValue("@Automovel_valor", valor.Replace(".", "").Replace(",", "."));
                executaMySqlInsertAutomovel.Parameters.AddWithValue("@Automovel_status", status);
                executaMySqlInsertAutomovel.Parameters.AddWithValue("@Automovel_marca", marca);
                executaMySqlInsertAutomovel.Parameters.AddWithValue("@Automovel_modelo", modelo);


                con.Open();
                executaMySqlInsertAutomovel.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cadastrado");

                string sql_select_automovel = "select * from tb_automovel;";

                con.Open();
                MySqlCommand executacmdMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);
                executacmdMySql_select_automovel.ExecuteNonQuery();

                DataTable tabela_automovel = new DataTable();

                MySqlDataAdapter da_automovel = new MySqlDataAdapter(executacmdMySql_select_automovel);
                da_automovel.Fill(tabela_automovel);
                con.Close();

                dgvListarVeiculo.DataSource = tabela_automovel;


            }
            catch (Exception erro)
            {

                txtVeiculoId.Clear();
                txtNomeVeiculo.Clear();
                txtCorVeiculo.Clear();
                txtAnoFab.Clear();
                txtKmVeiculo.Clear();
                cbStatus.Items.Clear();
                cbModelo.Items.Clear();
                cbMarca.Items.Clear();
                MessageBox.Show("Erro" + erro);
            }

          
        }

        private void BtnAtuVeiculo_Click(object sender, EventArgs e)
        {
            int ano, codigo;
            string valor;
            string nome, cor, status;
            int marca, modelo;
            double km;

            codigo = int.Parse(txtVeiculoId.Text);
            nome = txtNomeVeiculo.Text;
            ano = int.Parse(txtAnoFab.Text);
            cor = txtCorVeiculo.Text;
            km = double.Parse(txtKmVeiculo.Text);
            valor = txtValorVeiculo.Text;
            status = cbStatus.Text;
            marca = int.Parse(cbMarca.SelectedValue.ToString());
            modelo = int.Parse(cbModelo.SelectedValue.ToString());


            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            string sqlUpdateAutomovel = @"update tb_automovel set tb_automovel_nome = @automovelNome,
                                                              tb_automovel_ano_fab = @automovelAnoFab,
                                                              tb_automovel_cor = @automovelCor,
                                                              tb_automovel_km = @automovelKm,
                                                              tb_automovel_valor_d = @automovelValor,
                                                              tb_automovel_status = @automovelStatus,
                                                              tb_marca_id = @marcaid,
                                                              tb_modelo_id = @modeloid

                                                              where tb_automovel_id = @id;
                                                              ";
            MySqlCommand executaMySqlUpdateAutomovel = new MySqlCommand(sqlUpdateAutomovel, con);
            executaMySqlUpdateAutomovel.Parameters.AddWithValue("@id", codigo);
            executaMySqlUpdateAutomovel.Parameters.AddWithValue("@automovelNome", nome);
            executaMySqlUpdateAutomovel.Parameters.AddWithValue("@automovelAnoFab", ano);
            executaMySqlUpdateAutomovel.Parameters.AddWithValue("@automovelCor", cor);
            executaMySqlUpdateAutomovel.Parameters.AddWithValue("@automovelKm", km);
            executaMySqlUpdateAutomovel.Parameters.AddWithValue("@automovelValor", valor.Replace(".", "").Replace(",", "."));
            executaMySqlUpdateAutomovel.Parameters.AddWithValue("@automovelStatus", status);
            executaMySqlUpdateAutomovel.Parameters.AddWithValue("@marcaid", marca);
            executaMySqlUpdateAutomovel.Parameters.AddWithValue("@modeloid", modelo);

            executaMySqlUpdateAutomovel.ExecuteNonQuery();


            MessageBox.Show("Atualização realizada com sucesso!!");

            con.Close();

            string sql_select_automovel = "select * from tb_automovel;";

            con.Open();
            MySqlCommand executacmdMySql_select_automovel = new MySqlCommand(sql_select_automovel, con);
            executacmdMySql_select_automovel.ExecuteNonQuery();

            DataTable tabela_automovel = new DataTable();

            MySqlDataAdapter da_automovel = new MySqlDataAdapter(executacmdMySql_select_automovel);
            da_automovel.Fill(tabela_automovel);
            con.Close();

            dgvListarVeiculo.DataSource = tabela_automovel;
        }


        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);


            string sqlSelectCbModelo = "select * from tb_modelo order by tb_modelo_id desc;";
            MySqlDataAdapter daModelo = new MySqlDataAdapter(sqlSelectCbModelo, con);
            DataTable dtResultadoModelo = new DataTable();
            daModelo.Fill(dtResultadoModelo);

            DataRow dr = dtResultadoModelo.NewRow();
            dr["TB_MODELO_ID"] = 0;
            dr["TB_MODELO_DESC"] = "Novo...";

            dtResultadoModelo.Rows.InsertAt(dr, 0);

            string txtCbModelo = cbModelo.Text;

            if (txtCbModelo == "Novo...")
            {
                modelo modelo = new modelo();
                modelo.ShowDialog();

            }

        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            string sqlSelectCmbMarca = @"select * from tb_marca order by tb_marca_id desc;";
            MySqlDataAdapter daMarca = new MySqlDataAdapter(sqlSelectCmbMarca, con);
            DataTable dtResultadoMarca = new DataTable();
            daMarca.Fill(dtResultadoMarca);

            DataRow dr = dtResultadoMarca.NewRow();
            dr["TB_MARCA_ID"] = 0;
            dr["TB_MARCA_NOME"] = "Novo...";

            dtResultadoMarca.Rows.InsertAt(dr, 0);

            string txtCbMarca = cbMarca.Text;

            if (txtCbMarca == "Novo...")
            {
                marca marca = new marca();
                marca.ShowDialog();

            }

        }

        private void LblValorVeiculo_Click(object sender, EventArgs e)
        {
            lblValorVeiculo.Hide();
            txtValorVeiculo.Focus();

        }

        private void CbMarca_Click(object sender, EventArgs e)
        {
            lblMarca.Hide();
            cbMarca.Focus();
            cbMarca.DroppedDown = true;
        }

        private void LblMarca_Click(object sender, EventArgs e)
        {
            lblMarca.Hide();
            cbMarca.Focus();
            cbMarca.DroppedDown = true;
        }

        private void CbStatus_Click(object sender, EventArgs e)
        {
            lblStatus.Hide();
            cbStatus.Focus();
            cbStatus.DroppedDown = true;
        }

        private void LblStatus_Click(object sender, EventArgs e)
        {
            lblStatus.Hide();
            cbStatus.Focus();
            cbStatus.DroppedDown = true;
        }

        private void LblModelo_Click(object sender, EventArgs e)
        {
            lblModelo.Hide();
            cbModelo.Focus();
            cbModelo.DroppedDown = true;
        }

        private void CbModelo_Click(object sender, EventArgs e)
        {
            lblModelo.Hide();
            cbModelo.Focus();
            cbModelo.DroppedDown = true;
        }
    }
}

