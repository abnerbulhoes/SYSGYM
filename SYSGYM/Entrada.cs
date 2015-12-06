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
    public partial class Entrada : Form
    {
        public Entrada(string nome)
        {
            InitializeComponent();
            l_nome.Text = nome;                       
        }

        private void Entrada_Load(object sender, EventArgs e)
        {

        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Inicial Inicial = new Inicial();
            Inicial.Show();
            Hide();
        }
    }
}
