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
            UpdateDataSouce(Lb_Tudo, Carros);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string item = Carros[Lb_Tudo.SelectedIndex];
                MessageBox.Show(item);
                Tb_Adicionar.Focus();

            }
            catch
            {
                MessageBox.Show("tem que ter algum item para poder ser exibido!");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Tb_Adicionar.Text))
            {
                Carros.Add(Tb_Adicionar.Text);
                UpdateDataSouce(Lb_Tudo,Carros);
                Tb_Adicionar.Clear();
                Tb_Adicionar.Focus();

            }
            else
            {
                MessageBox.Show("safadinho, ta tentando quebrar meu sistema ne");
            }
        }
        private void UpdateDataSource(ListBox listbox,List<String> list)
        {
            listbox.DataSource = null;
            listbox.DataSource = list;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Carros.Clear();
            UpdateDataSouce(Lb_Tudo, Carros);
        }
    }
}
