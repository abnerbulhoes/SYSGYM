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
    public partial class Aluno_Cadastrar : Form
    {
        public Aluno_Cadastrar()
        {
            InitializeComponent();
            tbx_matricula.Text = "001";            
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Aluno Aluno = new Aluno();
            Aluno.Show();
            Hide();
        }

        private void ckb_masculino_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_feminino.Checked == true)
            {
                ckb_feminino.Checked = false;
            }
        }

        private void ckb_feminino_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_masculino.Checked == true)
            {
                ckb_masculino.Checked = false;
            }
        }

        private void pic_foto_Click(object sender, EventArgs e)
        {

        }

        private void tbx_matricula_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataCadastro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txb_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
