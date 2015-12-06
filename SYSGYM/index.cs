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
        int matricula_instrutor;

        public index(int mat_instrut)
        {
            InitializeComponent();
            matricula_instrutor = mat_instrut; //matricula do instrutor logado
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void btn_alunos_Click(object sender, EventArgs e)
        {
            Aluno Aluno = new Aluno(matricula_instrutor); // ir passando a matricula do instrutor para caso seja feita a avaliacao salvar.
            Aluno.Show();
            Hide();
        }

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void btn_gerarRelatorio_Click(object sender, EventArgs e)
        {
            Relatorios Relatorio = new Relatorios(matricula_instrutor);
            Relatorio.Show();
            Hide();
        }
    }
}
