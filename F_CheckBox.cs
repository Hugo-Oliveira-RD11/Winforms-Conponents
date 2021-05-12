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
    public partial class F_CheckBox : Form
    {
        public F_CheckBox()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if(Cb_Aceitar_Tudo.Checked == true)
            {
                MessageBox.Show("Voce acabou de vender a sua alma, meus parabens!");
                this.Hide();
                return;
            }
            else if (Cb_Aceitar_Tudo.Checked ==  false)
            {
                MessageBox.Show("Voce tem que aceitar o contrato para continuar a usar o aplicativo!");
            }
                
        }
    }
}
