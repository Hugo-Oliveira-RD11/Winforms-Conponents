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
    public partial class F_ListBox : Form
    {
        List<String> Carros = new List<string>();
        public F_ListBox()
        {
            Carros.Add("Onix");
            Carros.Add("Gol");
            Carros.Add("Golf");

            InitializeComponent();

            Lb_Tudo.DataSource = Carros;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Carros.RemoveAt(Lb_Tudo.SelectedIndex);
            UpdateDataSouce();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string item = Carros[Lb_Tudo.SelectedIndex];
            MessageBox.Show(item);
            Tb_Adicionar.Focus();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Tb_Adicionar.Text))
            {
                Carros.Add(Tb_Adicionar.Text);
                UpdateDataSouce();
                Tb_Adicionar.Clear();
                Tb_Adicionar.Focus();

            }
            else
            {
                MessageBox.Show("safadinho, ta tentando quebrar meu sistema ne");
            }
        }
        private void UpdateDataSouce()
        {
            Lb_Tudo.DataSource = null;
            Lb_Tudo.DataSource = Carros;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Carros.Clear();
            UpdateDataSouce();
        }
    }
}
