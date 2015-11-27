using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSGYM
{
    public partial class Login : Form
    {
        string login;
        int senha, matricula_instrutor;

        public Login(int mat_instrut, string logi, int senh)
        {
            InitializeComponent();
            login = logi;
            senha = senh;
            matricula_instrutor = mat_instrut;       
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            if (txb_login.Text == "" || txb_login == null || txb_senha.Text == "" || txb_senha == null)
            {
                Console.Beep();
                MessageBox.Show("Login ou senha inválidos!");                
            }
            else if( txb_login.Text == login && txb_senha.Text == Convert.ToString(senha)) // testando login
            {
                index index = new index(matricula_instrutor);
                index.Show();
                Hide();
            }
            else
            {
                Console.Beep();
                MessageBox.Show("Login ou senha inválidos!");
                txb_login.Text = "";
                txb_senha.Text = "";
            }
        }

        private void txb_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
