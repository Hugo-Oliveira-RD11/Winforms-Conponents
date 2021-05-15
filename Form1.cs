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
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();         
        }
        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Tb_Coisa_para_Adicionar.Text))
            {
                MessageBox.Show("Vc tem q escrever alguma coisa para ser adicionada");
                Tb_Coisa_para_Adicionar.Focus();
                return;
            }
            Tb_Tudo.Text += Tb_Coisa_para_Adicionar.Text + ", ";

            Tb_Coisa_para_Adicionar.Clear();
            Tb_Coisa_para_Adicionar.Focus();
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            Tb_Tudo.Clear();
            Tb_Coisa_para_Adicionar.Focus();
        }

        private void btn_show_cars_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(Tb_Tudo.Text,this) ;
            f_Veiculos.ShowDialog();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_checkBox = new F_CheckBox();
            f_checkBox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimerPicker f_DateTimerPicker = new F_DateTimerPicker();
            f_DateTimerPicker.ShowDialog();
        }

        private void linkLabelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_LinkLabel = new F_LinkLabel();
            f_LinkLabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_ListView = new F_ListView();
            f_ListView.ShowDialog();
        }
    }
}
