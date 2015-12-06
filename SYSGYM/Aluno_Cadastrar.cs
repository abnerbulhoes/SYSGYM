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
    public partial class Aluno_Cadastrar : Form
    {
        string oradb = "Data Source=(DESCRIPTION="
+ "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
+ "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));"
+ "User Id=adm;Password=123456;";


        int matricula_instrutor;
        public Aluno_Cadastrar(int mat_instrut)
        {
            InitializeComponent();
            matricula_instrutor = mat_instrut;

            try
            {
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();

                OracleCommand oda = new OracleCommand("SELECT COUNT(matricula) FROM pessoa", conn);
                OracleDataReader reader = oda.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    int tot_matr = reader.GetInt32(0) + 1;
                    tbx_matricula.Text = Convert.ToString(tot_matr);
                }                
                conn.Close();
            }
            catch (Exception ex) // detecta todos os erros
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Aluno Aluno = new Aluno(matricula_instrutor);
            Aluno.Show();
            Hide();
        }

        private void ckb_masculino_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ckb_feminino_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void pic_foto_Click(object sender, EventArgs e)
        {

        }

        private void tbx_matricula_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataCadastro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txb_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckb_feminino_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string nome, email, bairro, rua, uf;
            decimal cpf, telefone;
            int cep;
            DateTime dataNasci, dataCadas;

            if (txb_nome.Text == "" || txb_cpf.Text == "" || dataNascimento == dateCadastro || 
                ckb_masculino.CanSelect == false && ckb_feminino.CanSelect == false || txb_telefone.Text == "" ||
                txb_email.Text == "" || txb_cep.Text == "" || txb_bairro.Text == "" || txb_rua.Text == "" || txb_estado.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                nome = txb_nome.Text;
                cpf = Convert.ToDecimal(txb_cpf.Text);
                bairro = txb_bairro.Text;
                dataNasci = dataNascimento.Value;
                dataCadas = dateCadastro.Value;
                telefone = Convert.ToDecimal(txb_telefone.Text);
                email = txb_email.Text;
                cep = Convert.ToInt32(txb_cep.Text);                //foi pego todos os dados da tela
                rua = txb_rua.Text;
                uf = txb_estado.Text;

                try
                {
                    OracleConnection conn = new OracleConnection(oradb);
                    conn.Open();

                    OracleCommand oda = new OracleCommand("", conn);
                    


                    conn.Close();
                }
                catch (Exception ex) // detecta todos os erros
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                index index = new index(matricula_instrutor); // apos salva no banco, volta pra tela index
                index.Show();
                Hide();
            }
        }

        private void Aluno_Cadastrar_Load(object sender, EventArgs e)
        {

        }
    }
}
