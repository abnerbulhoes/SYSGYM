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
    public partial class Inicial : Form
    {
        //string de conexao
        string oradb = "Data Source=(DESCRIPTION="
+ "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
+ "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));"
+ "User Id=adm;Password=123456;";

        public Inicial()
        {
            InitializeComponent();
        }

        int num_matricula;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Inicial_Load(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            n_matricula.Text = n_matricula.Text + "1";            
        }

        private void n_matricula_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bnt_2_Click(object sender, EventArgs e)
        {
            n_matricula.Text = n_matricula.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            n_matricula.Text = n_matricula.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            n_matricula.Text = n_matricula.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            n_matricula.Text = n_matricula.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            n_matricula.Text = n_matricula.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            n_matricula.Text = n_matricula.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            n_matricula.Text = n_matricula.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            n_matricula.Text = n_matricula.Text + "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            n_matricula.Text = n_matricula.Text + "0";
        }

        private void btn_limpar_Click_1(object sender, EventArgs e)
        {
            n_matricula.Text = "";
        }

                

        private void btn_ok_Click(object sender, EventArgs e)
        {

            if (n_matricula.Text == "" || n_matricula.Text == null)
            {
                num_matricula = 0;
            }
            else
                num_matricula = Convert.ToInt32(n_matricula.Text); // pegando matricula digitada na tela

            try
            {
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();

                OracleCommand oda = new OracleCommand("SELECT matricula FROM aluno WHERE matricula ="+ num_matricula, conn);
                OracleDataReader reader = oda.ExecuteReader();
                if (reader.HasRows)
                {
                    Opcao_Aluno Opcao_Aluno = new Opcao_Aluno(num_matricula);
                    Opcao_Aluno.Show();
                    Hide();
                }else {
                    OracleCommand oda2 = new OracleCommand("SELECT matricula, senha FROM instrutor WHERE matricula =" + num_matricula, conn);
                    OracleDataReader reader2 = oda2.ExecuteReader();
                    
                    if (reader2.HasRows)
                    {
                        reader2.Read();
                        int login = reader2.GetInt32(0);
                        string senha = reader2.GetString(1);

                        Login Login = new Login(num_matricula, login, senha); // passar login e senha para verificar na prox tela
                        Login.Show();
                        Hide();
                    }
                    else
                    {
                        Console.Beep();
                        MessageBox.Show("Numero de matrícula inválido!");
                        n_matricula.Text = "";
                    }
                }
                conn.Close();
            }            
            catch (Exception ex) // detecta todos os erros
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }
    }
}
