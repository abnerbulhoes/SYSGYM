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
    public partial class Aluno : Form
    {
        public Aluno()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            index index = new index();
            index.Show();
            Hide();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Aluno_Cadastrar Aluno_Cadastrar = new Aluno_Cadastrar();
            Aluno_Cadastrar.Show();
            Hide();
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            l_nome.Visible = true;
            txb_nome.Visible = true;
            btn_buscar.Visible = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txb_nome.Text == null || txb_nome.Text == "")
            {
                Console.Beep();
                MessageBox.Show("Nenhum nome digitado!");                
            }
            else
            {
                Busca Busca = new Busca(txb_nome.Text);
                Busca.Show();
                Hide();
            }
        }

        private void txb_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
