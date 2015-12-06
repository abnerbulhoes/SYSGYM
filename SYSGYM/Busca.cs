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
    public partial class Busca : Form
    {
        string oradb = "Data Source=(DESCRIPTION="
+ "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
+ "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));"
+ "User Id=adm;Password=123456;";


        int matricula_instrutor;
        string substring;

        public Busca(int mat_instut ,string nome, string sub)
        {
            InitializeComponent();
            l_nome.Text = nome;
            matricula_instrutor = mat_instut;
            substring = sub;

            try
            {
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();

                OracleDataAdapter oda = new OracleDataAdapter("SELECT matricula AS Matricula, nome AS Nome FROM pessoa WHERE nome LIKE '" + substring + "%'", conn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex) // detecta todos os erros
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void l_nome_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Aluno Aluno = new Aluno(matricula_instrutor);
            Aluno.Show();
            Hide();
        }

        private void Busca_Load(object sender, EventArgs e)
        {

        }

        private void btn_selecionar_Click(object sender, EventArgs e) //pega a matricula do aluno selecionado
        {

            int matricula_aluno = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Perfil Perfil = new Perfil(matricula_instrutor, matricula_aluno);
            Perfil.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
