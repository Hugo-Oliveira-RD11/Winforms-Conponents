using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componetes
{
    public partial class F_DateTimerPicker : Form
    {
        public F_DateTimerPicker()
        {
            InitializeComponent();
        }

        private void btn_captador_Click(object sender, EventArgs e)
        {
            tb_TodaData.Text = dtp_data.Text;

        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            string data = tb_add_dia.Text +"  "+ tb_add_mes.Text +"  "+ tb_add_ano.Text;
            dtp_data.Value = Convert.ToDateTime(data);
        }

        private void btn_hoje_Click(object sender, EventArgs e)
        {
            DateTime hoje = new DateTime();
            hoje = DateTime.Today;
            dtp_data.Value = hoje;

        }
    }
}
