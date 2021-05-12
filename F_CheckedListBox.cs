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
    public partial class F_CheckedListBox : Form
    {

        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Clb_All.Items.Clear();
            string[] Mytransports = new string[7] 
            {
                "carro","barco","moto","avião","cavalo","porco","mamute"
            };
            foreach (string mt in Mytransports)
            {
                Clb_All.Items.Add(mt, false);
            }
        }

        private void btn_Add_List_Click(object sender, EventArgs e)
        {
            Clb_All.Items.Add(tb_NewTransports.Text,false);
            tb_NewTransports.Clear();
            tb_NewTransports.Focus();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clb_All.Items.Clear();
        }

        private void btn_ShowChecked_Click(object sender, EventArgs e)
        {
            string texto= "";

            for(int i=0 ; i < Clb_All.CheckedItems.Count; i++)
            {
                texto += Clb_All.CheckedItems[i].ToString() + ", ";

            }
            MessageBox.Show(texto);

            
        }
    }
}
