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
    public partial class cadastro : Form
    {
        string conexao = ConfigurationManager.ConnectionStrings["locadora_2dsiem_2021"].ConnectionString;

        public cadastro()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string nome;
                string telefone;
                string email;
                string senha;
                string endereco;
                string bairro;
                string cidade;
                string uf;
                string datanasc;
                string datacad;


                nome = txtnome.Text;
                telefone = txttel.Text;
                email = txtemail.Text;
                senha = txtsenha.Text;
                endereco = txtendereco.Text;
                bairro = txtbairro.Text;
                cidade = txtcidade.Text;
                uf = cbestado.Text;
                datanasc = mtxtDtNasc.Text.ToString();
                datacad = mtxtDtCad.Text.ToString();
                DateTime datNasc = DateTime.ParseExact(datanasc, "dd/MM/yyyy", null);
                DateTime datCad = DateTime.ParseExact(datacad, "dd/MM/yyyy", null);

                string sql_insert = @"insert into tb_cliente
                                        (
                                            TB_CLIENTE_NOME,
                                            TB_CLIENTE_TEL,
                                            TB_CLIENTE_EMAIL,
                                            TB_CLIENTE_SENHA,
                                            TB_CLIENTE_ENDERECO,
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
                                            @CLIENTE_EMAIL,
                                            @CLIENTE_SENHA,
                                            @CLIENTE_ENDERECO,
                                            @CLIENTE_BAIRRO,
                                            @CLIENTE_CIDADE,
                                            @CLIENTE_UF,
                                            @CLIENTE_DT_NASC,
                                            @CLIENTE_DT_CAD                             
                                        )";

                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);

                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_NOME", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_TEL", telefone);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_EMAIL", email);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_SENHA", senha);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_ENDERECO", endereco);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_BAIRRO", bairro);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_CIDADE", cidade);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_UF", uf);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_DT_NASC", datNasc);
                executacmdMySql_insert.Parameters.AddWithValue("@CLIENTE_DT_CAD", datCad);

                con.Open();
                executacmdMySql_insert.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cadastrado");


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
            txtcidade.Clear();
            txtbairro.Clear();
            cbestado.Items.Clear();
            mtxtDtNasc.Clear();
        }



        private void Guna2ImageButton1_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem Certeza que gostaria de voltar?", "Voltar", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.No)
            {
                // A message box fecha
            }
            else
            {
                this.Close();
                new cadastro().Close();
                new login().Show();
            }
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

        private void lblDtCadastro_Click(object sender, EventArgs e)
        {
            lblDtCadastro.Hide();
            mtxtDtCad.Focus();
            mtxtDtCad.Cursor = System.Windows.Forms.Cursors.IBeam;
        }

        private void mtxtDtCad_Click(object sender, EventArgs e)
        {
            lblDtCadastro.Hide();
            mtxtDtCad.Focus();
            mtxtDtCad.Cursor = System.Windows.Forms.Cursors.IBeam;
        }

        private void lblDtNasc_Click(object sender, EventArgs e)
        {
            lblDtNasc.Hide();
            mtxtDtNasc.Focus();
            mtxtDtNasc.Cursor = System.Windows.Forms.Cursors.IBeam;
        }

        private void mtxtDtNasc_Click(object sender, EventArgs e)
        {
            lblDtNasc.Hide();
            mtxtDtNasc.Focus();
            mtxtDtNasc.Cursor = System.Windows.Forms.Cursors.IBeam;
        }
    }
}
