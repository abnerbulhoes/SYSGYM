using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace SYSGYM
{
    public partial class Perfil : Form
    {
        string oradb = "Data Source=(DESCRIPTION="
+ "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
+ "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));"
+ "User Id=adm;Password=123456;";


        int matricula_instrutor, matricula_aluno;

        public Perfil(int mat_instrut, int mat_alun)
        {
            InitializeComponent();
            matricula_instrutor = mat_instrut;
            matricula_aluno = mat_alun;
        }

        private void dataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Aluno Aluno = new Aluno(matricula_instrutor);
            Aluno.Show();
            Hide();
        }

        private void btn_excluirMensalidade_Click(object sender, EventArgs e)
        {

        }

        private void l_peso_Click(object sender, EventArgs e)
        {

        }

        private void l_gluteo_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluirAvaliacao_Click(object sender, EventArgs e)
        {
                        
        }

        private void btn_alterarAvaliacao_Click(object sender, EventArgs e)
        {           
            btn_atualizarAvaliacao.Visible = true;
        }

        private void btn_atualizarAvaliacao_Click(object sender, EventArgs e)
        {
            
        }

        private void dataNascimento_ValueChanged_1(object sender, EventArgs e)
        {

        }

        string nome, email, bairro, rua, uf;
        int cep; decimal cpf, telefone;

        private void Perfil_Load(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();

                OracleCommand oda = new OracleCommand("SELECT p.nome, p.sexo, p.cpf, p.datanascimento, p.numtelefone, p.email, e.cep, e.bairro, e.rua, e.uf FROM pessoa p JOIN endereco e ON e.cep = p.cep WHERE p.matricula =" + matricula_aluno, conn);
                OracleDataReader reader = oda.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    nome = reader.GetString(0);
                    txb_nome.Text = nome;
                    string sexo = reader.GetString(1);
                    if (sexo == "M")
                    {
                        ckb_masculino.Checked = true;
                    }
                    else ckb_feminino.Checked = true;
                    cpf = reader.GetDecimal(2);
                    txb_cpf.Text = Convert.ToString(cpf);
                    DateTime nascimento = reader.GetDateTime(3);
                    dataNascimento.Value = nascimento;
                    telefone = reader.GetDecimal(4);
                    txb_telefone.Text = Convert.ToString(telefone);
                    email = reader.GetString(5);
                    txb_email.Text = email;
                    cep = reader.GetInt32(6);
                    txb_cep.Text = Convert.ToString(cep);
                    bairro = reader.GetString(7);
                    txb_bairro.Text = bairro;
                    rua = reader.GetString(8);
                    txb_rua.Text = rua;
                    uf = reader.GetString(9);
                    txb_estado.Text = uf;

                }

                conn.Close();
            }
            catch (Exception ex) // detecta todos os erros
            {
                MessageBox.Show(ex.Message.ToString());
            }

            try
            {
                OracleConnection conn2 = new OracleConnection(oradb);
                conn2.Open();

                OracleCommand oda2 = new OracleCommand("SELECT valor, statusmensalidade, vencimento, mesreferencia FROM mensalidade WHERE matricula_aluno=" + matricula_aluno, conn2);
                OracleDataReader reader2 = oda2.ExecuteReader();
                if (reader2.HasRows)
                {
                    reader2.Read();
                    string valor = reader2.GetString(0);
                    txb_valorMensalidade.Text = valor;
                    string status = reader2.GetString(1);
                    txb_statusMensalidade.Text = status;
                    string vencimento = reader2.GetString(2);
                    DateTime venc = Convert.ToDateTime(vencimento);
                    date_VencimentoMesalidade.Value = new DateTime(venc.Year, venc.Month, venc.Day);
                    string mesrefencia = reader2.GetString(3);
                    txb_mesReferencia.Text = mesrefencia;
                    

                }

                conn2.Close();
            }
            catch (Exception ex) // detecta todos os erros
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ckb_masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txb_mesReferencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_VencimentoMesalidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_atualizarAluno_Click(object sender, EventArgs e)
        {
            btn_atualizarAluno.Enabled = false;
            btn_atualizarAluno.Visible = false;
            btn_salvar.Enabled = true;
            btn_salvar.Visible = true;

            txb_nome.Enabled = true;
            txb_cpf.Enabled = true;
            txb_telefone.Enabled = true;
            txb_email.Enabled = true;
            txb_cep.Enabled = true;
            txb_bairro.Enabled = true;
            txb_rua.Enabled = true;
            txb_estado.Enabled = true;

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if( txb_nome.Text != nome || txb_cpf.Text != Convert.ToString(cpf) || txb_telefone.Text != Convert.ToString(telefone) ||
                txb_email.Text != email || txb_cep.Text != Convert.ToString(cep) || txb_bairro.Text != bairro ||
                txb_rua.Text != rua || txb_estado.Text != uf)
            {
                nome = txb_nome.Text;
                cpf = Convert.ToDecimal(txb_cpf.Text);
                bairro = txb_bairro.Text;
                telefone = Convert.ToDecimal(txb_telefone.Text);
                email = txb_email.Text;
                cep = Convert.ToInt32(txb_cep.Text);                //foi pego todos os dados da tela
                rua = txb_rua.Text;
                uf = txb_estado.Text;

                MessageBox.Show("Dados alterados... Salvando no Banco");

                //try
                //{
                //    OracleConnection conn3 = new OracleConnection(oradb);
                //    conn3.Open();

                //    OracleCommand oda3 = conn3.CreateCommand();
                //    oda3.CommandType = CommandType.Text;
                //    oda3.CommandText = "UPDATE pessoa SET cep  = :cep, nome = :nome, cpf = :cpf, email = :email, numtelefone = :telefone WHERE matricula = :matricula_aluno";
                //    oda3.Parameters.Add("cep", cep);
                //    oda3.Parameters.Add("nome", nome);
                //    oda3.Parameters.Add("cpf", cpf);
                //    oda3.Parameters.Add("email", email);
                //    oda3.Parameters.Add("telefone", telefone);
                //    oda3.Parameters.Add("matricula_aluno", matricula_aluno);
                //    oda3.ExecuteNonQuery();


                //    OracleCommand oda4 = new OracleCommand("UPDATE endereco SET cep = " + cep + ", rua = '" + rua + "', bairro = '" + bairro + "', uf = '" + uf + "' cep=" + cep, conn3);
                //    oda4.ExecuteNonQuery();

                //    conn3.Close();
                //}
                //catch (Exception ex) // detecta todos os erros
                //{
                //    MessageBox.Show(ex.Message.ToString());
                //}

                MessageBox.Show("Dados alterados no Banco");

                index index = new index(matricula_instrutor);
                index.Show();
                Hide();
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
