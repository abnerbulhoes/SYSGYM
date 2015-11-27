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
    public partial class Saida : Form
    {
        public Saida(string nome)
        {
            InitializeComponent();
            l_nome.Text = nome;
        }

        private void Saida_Load(object sender, EventArgs e)
        {
            
        }
    }
}
