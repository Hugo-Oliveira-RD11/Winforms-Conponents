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
    public partial class F_Veiculos : Form
    {
        public string conteudo;

        public F_Principal f_Principal;
        public F_Veiculos(string conteudo,F_Principal f)
        {
            InitializeComponent();
            Tb_Mostrar_tudo.Text = conteudo;
            this.conteudo = conteudo;
            f_Principal = f;

        }



        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.conteudo != Tb_Mostrar_tudo.Text)
            {
                f_Principal.Tb_Tudo.Text = Tb_Mostrar_tudo.Text;
            }
        }
    }
}
