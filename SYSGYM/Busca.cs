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
        int matricula_instrutor;

        public Busca(int mat_instut ,string nome)
        {
            InitializeComponent();
            l_nome.Text = nome;
            matricula_instrutor = mat_instut;
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
            int matricula_aluno = 0; // colocar a matricula do selecionado com base na query exibida
            Perfil Perfil = new Perfil(matricula_instrutor, matricula_aluno);
            Perfil.Show();
            Hide();
        }
    }
}
