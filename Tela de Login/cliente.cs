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
using System.Data.SqlClient;


namespace Tela_de_Login
{

    public partial class cliente : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        public cliente()
        {
            InitializeComponent();
        }


        private void cliente_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            string sql_select_cliente = @"SELECT TB_CLIENTE.TB_CLIENTE_ID AS ID, TB_CLIENTE.TB_CLIENTE_NOME as NOME, TB_CLIENTE.TB_CLIENTE_TEL as TELEFONE,
                                             TB_CLIENTE.TB_CLIENTE_SEXO as SEXO, TB_CLIENTE.TB_CLIENTE_EMAIL as EMAIL,
                                             TB_CLIENTE.TB_CLIENTE_SENHA as SENHA, TB_CLIENTE.TB_CLIENTE_ENDERECO as ENDEREÇO,
                                             TB_CLIENTE.TB_CLIENTE_COMPLEMENTO as COMPLEMENTO, TB_CLIENTE.TB_CLIENTE_BAIRRO as BAIRRO,
                                             TB_CLIENTE.TB_CLIENTE_CIDADE as CIDADE, TB_CLIENTE.TB_CLIENTE_UF as ESTADO, 
                                             TB_CLIENTE.TB_CLIENTE_DT_NASC as 'DATA DE NASCIMENTO', TB_CLIENTE.TB_CLIENTE_DT_CAD as 'DATA DE CADASTRO',
                                             TB_CLIENTE.TB_CLIENTE_STATUS as STATUS
                                             FROM TB_CLIENTE;";

            con.Open();
            MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
            executacmdMySql_select_cliente.ExecuteNonQuery();

            DataTable tabela_cliente = new DataTable();

            MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
            da_cliente.Fill(tabela_cliente);
            con.Close();

            dgvlistarCliente.DataSource = tabela_cliente;
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection con = new MySqlConnection(conexao);

                string nome;
                string sexo;
                string telefone;
                string datanasc;
                string datacad;
                string email;
                string senha;
                string endereco;
                string complemento;
                string bairro;
                string cidade;
                string estado;
                string status;


                nome = txtnome.Text;
                sexo = cbSexo.Text;
                telefone = txttel.Text;
                datanasc = mtxtDtNasc.Text.ToString();
                datacad = mtxtDtCad.Text.ToString();
                DateTime datNasc = DateTime.ParseExact(datanasc, "dd/MM/yyyy", null);
                DateTime datCad = DateTime.ParseExact(datacad, "dd/MM/yyyy", null);
                email = txtemail.Text;
                senha = txtsenha.Text;
                endereco = txtendereco.Text;
                complemento = txtComp.Text;
                bairro = txtbairro.Text;
                cidade = txtcidade.Text;
                estado = cbestado.Text;
                status = cbStatus.Text;

                string sql_insert = @"insert into tb_cliente
                                        (
                                            TB_CLIENTE_NOME,
                                            TB_CLIENTE_TEL,
                                            TB_CLIENTE_SEXO,
                                            TB_CLIENTE_EMAIL,
                                            TB_CLIENTE_SENHA,
                                            TB_CLIENTE_ENDERECO,
                                            TB_CLIENTE_COMPLEMENTO,
                                            TB_CLIENTE_BAIRRO,
                                            TB_CLIENTE_CIDADE,
                                            TB_CLIENTE_UF,
                                            TB_CLIENTE_DT_NASC,
                                            TB_CLIENTE_DT_CAD
                                        )
                                  values
                                        (
                                            @CLIENTE_NOME,
                                            @CLIENTE_TEL,
                                            @CLIENTE_SEXO,
                                            @CLIENTE_EMAIL,
                                            @CLIENTE_SENHA,
                                            @CLIENTE_ENDERECO,
                                            @CLIENTE_COMPLEMENTO,
                                            @CLIENTE_BAIRRO,
                                            @CLIENTE_CIDADE,
                                            @CLIENTE_UF,
                                            @CLIENTE_DT_NASC,
                                            @CLIENTE_DT_CAD
                                        );";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_NOME", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_TEL", telefone);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_SEXO", sexo);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_EMAIL", email);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_SENHA", senha);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_ENDERECO", endereco);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_COMPLEMENTO", complemento);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_BAIRRO", bairro);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_CIDADE", cidade);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_UF", estado);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_DT_NASC", datNasc);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_DT_CAD", datCad);

                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cadastrado");

                string sql_select_cliente = "select * from tb_cliente;";

                con.Open();
                MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
                executacmdMySql_select_cliente.ExecuteNonQuery();

                DataTable tabela_cliente = new DataTable();

                MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
                da_cliente.Fill(tabela_cliente);
                con.Close();

                dgvlistarCliente.DataSource = tabela_cliente;


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
            }


            txtnome.Clear();
            txttel.Clear();
            mtxtDtCad.Clear();
            txtemail.Clear();
            txtsenha.Clear();
            txtendereco.Clear();
            txtComp.Clear();
            txtcidade.Clear();
            txtbairro.Clear();
            mtxtDtNasc.Clear();

        }

        private void btnatu_Click(object sender, EventArgs e)
        {
            int codigo;
            string nome, sexo, telefone, datanasc, datacad, email, senha, endereco, complemento, bairro, cidade, estado, status;

            codigo = int.Parse(txtcodigo.Text);
            nome = txtnome.Text;
            sexo = cbSexo.Text;
            telefone = txttel.Text;
            datanasc = mtxtDtNasc.Text.ToString();
            datacad = mtxtDtCad.Text.ToString();
            DateTime datNasc = DateTime.ParseExact(datanasc, "dd/MM/yyyy", null);
            DateTime datCad = DateTime.ParseExact(datacad, "dd/MM/yyyy", null);
            email = txtemail.Text;
            senha = txtsenha.Text;
            endereco = txtendereco.Text;
            complemento = txtComp.Text;
            bairro = txtbairro.Text;
            cidade = txtcidade.Text;
            estado = cbestado.Text;
            status = cbStatus.Text;


            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            string sqlUpdateCliente = @"update tb_cliente set tb_cliente_nome = @clienteNome,
                                                              tb_cliente_tel = @clienteTel,
                                                              tb_cliente_sexo = @clienteSexo,
                                                              tb_cliente_email = @clienteEmail,
                                                              tb_cliente_senha = @clienteSenha,
                                                              tb_cliente_endereco = @clienteEnd,
                                                              tb_cliente_complemento = @clienteComp,
                                                              tb_cliente_bairro = @clienteBairro,
                                                              tb_cliente_cidade = @clienteCidade,
                                                              tb_cliente_uf = @clienteUf,
                                                              tb_cliente_dt_nasc = @clienteDtNasc,
                                                              tb_cliente_dt_cad = @clienteDtCad,
                                                              tb_cliente_status = @clienteStatus
                                                                
                                                              where tb_cliente_id = @id;
                                                              ";
            MySqlCommand executaMySqlUpdateCliente = new MySqlCommand(sqlUpdateCliente, con);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@id", codigo);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@clienteNome", nome);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@clienteTel", telefone);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@clienteSexo", sexo);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@clienteEmail", email);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@clienteSenha", senha);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@clienteEnd", endereco);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@clienteComp", complemento);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@clienteBairro", bairro);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@clienteCidade", cidade);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@clienteUf", estado);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@clienteDtNasc", datNasc);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@clienteDtCad", datCad);
            executaMySqlUpdateCliente.Parameters.AddWithValue("@clienteStatus", status);

            executaMySqlUpdateCliente.ExecuteNonQuery();


            MessageBox.Show("Atualização realizada com sucesso!!");

            con.Close();

            string sql_select_cliente = "select * from tb_cliente;";

            con.Open();
            MySqlCommand executacmdMySql_select_cliente = new MySqlCommand(sql_select_cliente, con);
            executacmdMySql_select_cliente.ExecuteNonQuery();

            DataTable tabela_cliente = new DataTable();

            MySqlDataAdapter da_cliente = new MySqlDataAdapter(executacmdMySql_select_cliente);
            da_cliente.Fill(tabela_cliente);
            con.Close();

            dgvlistarCliente.DataSource = tabela_cliente;

            DateTime datanas = DateTime.ParseExact(datanasc, "dd/MM/yyyy", null);
            DateTime dataca = DateTime.ParseExact(datacad, "dd/MM/yyyy", null);

    }

        private void dgvlistarCliente_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgvlistarCliente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgvlistarCliente.CurrentRow.Cells[1].Value.ToString();
            txttel.Text = dgvlistarCliente.CurrentRow.Cells[2].Value.ToString();
            cbSexo.Text = dgvlistarCliente.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dgvlistarCliente.CurrentRow.Cells[4].Value.ToString();
            txtsenha.Text = dgvlistarCliente.CurrentRow.Cells[5].Value.ToString();
            txtendereco.Text = dgvlistarCliente.CurrentRow.Cells[6].Value.ToString();
            txtComp.Text = dgvlistarCliente.CurrentRow.Cells[7].Value.ToString();
            txtbairro.Text = dgvlistarCliente.CurrentRow.Cells[8].Value.ToString();
            txtcidade.Text = dgvlistarCliente.CurrentRow.Cells[9].Value.ToString();
            cbestado.Text = dgvlistarCliente.CurrentRow.Cells[10].Value.ToString();
            mtxtDtNasc.Text = dgvlistarCliente.CurrentRow.Cells[11].Value.ToString();
            mtxtDtCad.Text = dgvlistarCliente.CurrentRow.Cells[12].Value.ToString();
            cbStatus.Text = dgvlistarCliente.CurrentRow.Cells[13].Value.ToString();
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {
            lblEstado.Hide();
            cbestado.Focus();
            cbestado.DroppedDown = true;
            cbestado.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void cbestado_Click(object sender, EventArgs e)
        {
            lblEstado.Hide();
            cbestado.Focus();
            cbestado.DroppedDown = true;
            cbestado.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            lblStatus.Hide();
            cbStatus.Focus();
            cbStatus.DroppedDown = true;
            cbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void cbStatus_Click(object sender, EventArgs e)
        {
            lblStatus.Hide();
            cbStatus.Focus();
            cbStatus.DroppedDown = true;
            cbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void lblSexo_Click(object sender, EventArgs e)
        {
            lblSexo.Hide();
            cbSexo.Focus();
            cbSexo.DroppedDown = true;
            cbSexo.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void cbSexo_Click(object sender, EventArgs e)
        {
            lblSexo.Hide();
            cbSexo.Focus();
            cbSexo.DroppedDown = true;
            cbSexo.Cursor = System.Windows.Forms.Cursors.Hand;
        }


        private void lblDtNasc_Click(object sender, EventArgs e)
        {
            lblDtNasc.Hide();
            mtxtDtNasc.Focus();
            mtxtDtNasc.Cursor = System.Windows.Forms.Cursors.IBeam;
        }

        private void lblDtCadastro_Click_1(object sender, EventArgs e)
        {
            lblDtNasc.Hide();
            mtxtDtCad.Focus();
            mtxtDtCad.Cursor = System.Windows.Forms.Cursors.IBeam;
        }
    }
}

