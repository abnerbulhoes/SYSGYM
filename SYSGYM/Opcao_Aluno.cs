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
        public Opcao_Aluno()
        {
            InitializeComponent();
        }

        private void btn_entrada_Click(object sender, EventArgs e)
        {
            Entrada Entrada = new Entrada();
            Entrada.Show();
            Hide();
        }

        private void btn_saida_Click(object sender, EventArgs e)
        {
            Saida Saida = new Saida();
            Saida.Show();
            Hide();
        }
    }
}
