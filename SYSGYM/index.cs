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
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_alunos_Click(object sender, EventArgs e)
        {
            Aluno Aluno = new Aluno();
            Aluno.Show();
            Hide();
        }
    }
}
