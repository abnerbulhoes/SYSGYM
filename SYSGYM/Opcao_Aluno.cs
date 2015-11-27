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
    public partial class Opcao_Aluno : Form
    {
        int matricula_aluno;
        string nome_aluno; // com  a matricula, buscar o nome do aluno

        public Opcao_Aluno(int mat_alun)
        {
            InitializeComponent();
            matricula_aluno = mat_alun;
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
