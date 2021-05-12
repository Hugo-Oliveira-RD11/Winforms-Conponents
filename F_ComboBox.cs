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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_Veiculos.Text);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cb_Veiculos.Items.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tb_Add.Text))
            {
                if (cb_Veiculos.Items.Contains(tb_Add.Text) == false)
                {
                    cb_Veiculos.Items.Add(tb_Add.Text);
                    tb_Add.Clear();
                    tb_Add.Focus();

                }
                else
                {
                    MessageBox.Show("Essa opção ja exite, por favor tente ser mais criativo!!");
                    tb_Add.Focus();
                }

            }
            else
            {
                MessageBox.Show("Por favor digite algum, n tem como adicionar uma opção sem uma letra!");
                tb_Add.Focus();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            object[] Tudo = {
                "Carro","Moto","Avião","Porco","Barco","Vaca"
            };
            cb_Veiculos.Items.Clear();
            cb_Veiculos.Items.AddRange(Tudo);
        }
    }
}
