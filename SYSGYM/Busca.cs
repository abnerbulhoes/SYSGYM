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
    public partial class Busca : Form
    {
        public Busca()
        {
            InitializeComponent();            
        }

        public Busca(string nome)
        {
            InitializeComponent();
            l_nome.Text = nome;
        }

        private void l_nome_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Aluno Aluno = new Aluno();
            Aluno.Show();
            Hide();
        }

        private void Busca_Load(object sender, EventArgs e)
        {

        }
    }
}
