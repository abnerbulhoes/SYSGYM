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
    public partial class Opcao_Aluno : Form
    {
        string oradb = "Data Source=(DESCRIPTION="
+ "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
+ "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));"
+ "User Id=adm;Password=123456;";

        int matricula_aluno;
        string nome_aluno; // com  a matricula, buscar o nome do aluno

        public Opcao_Aluno(int mat_alun)
        {
            InitializeComponent();
            matricula_aluno = mat_alun;

            try
            {
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();

                OracleCommand oda = new OracleCommand("SELECT matricula, nome FROM pessoa WHERE matricula =" + matricula_aluno, conn);
                OracleDataReader reader = oda.ExecuteReader();
                reader.Read();
                nome_aluno = reader.GetValue(1).ToString();  
                //var teste = reader.GetValue(0);
                conn.Close();
            }
            catch (Exception ex) // detecta todos os erros
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btn_entrada_Click(object sender, EventArgs e)
        {
            Entrada Entrada = new Entrada(nome_aluno);
            Entrada.Show();
            Hide();
        }

        private void btn_saida_Click(object sender, EventArgs e)
        {

            Saida Saida = new Saida(nome_aluno);
            Saida.Show();
            Hide();
        }

        private void Opcao_Aluno_Load(object sender, EventArgs e)
        {
            
        }
    }
}
