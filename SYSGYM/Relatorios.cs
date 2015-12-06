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
    public partial class Relatorios : Form
    {
        int matricula_instrutor;
        public Relatorios(int matricula_inst)
        {
            InitializeComponent();
            matricula_instrutor = matricula_inst;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            index index = new index(matricula_instrutor);
            index.Show();
            Hide();
        }

        private void btn_tds_mesnsalidades_Click(object sender, EventArgs e)
        {

        }
    }
}
