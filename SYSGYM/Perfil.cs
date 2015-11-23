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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void dataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Aluno Aluno = new Aluno();
            Aluno.Show();
            Hide();
        }

        private void btn_excluirMensalidade_Click(object sender, EventArgs e)
        {

        }

        private void l_peso_Click(object sender, EventArgs e)
        {

        }

        private void l_gluteo_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluirAvaliacao_Click(object sender, EventArgs e)
        {
                        
        }

        private void btn_alterarAvaliacao_Click(object sender, EventArgs e)
        {           
            btn_atualizarAvaliacao.Visible = true;
        }

        private void btn_atualizarAvaliacao_Click(object sender, EventArgs e)
        {
            
        }
    }
}
