
namespace Componetes
{
    partial class F_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_1 = new System.Windows.Forms.Label();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.Tb_Tudo = new System.Windows.Forms.TextBox();
            this.Tb_Coisa_para_Adicionar = new System.Windows.Forms.TextBox();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_show_cars = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.Location = new System.Drawing.Point(116, 79);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(185, 29);
            this.lb_1.TabIndex = 0;
            this.lb_1.Text = "Digite um carro";
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adicionar.Location = new System.Drawing.Point(283, 127);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(112, 35);
            this.btn_Adicionar.TabIndex = 1;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // Tb_Tudo
            // 
            this.Tb_Tudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Tudo.Location = new System.Drawing.Point(12, 190);
            this.Tb_Tudo.Multiline = true;
            this.Tb_Tudo.Name = "Tb_Tudo";
            this.Tb_Tudo.ReadOnly = true;
            this.Tb_Tudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tb_Tudo.Size = new System.Drawing.Size(383, 198);
            this.Tb_Tudo.TabIndex = 2;
            // 
            // Tb_Coisa_para_Adicionar
            // 
            this.Tb_Coisa_para_Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Coisa_para_Adicionar.Location = new System.Drawing.Point(12, 128);
            this.Tb_Coisa_para_Adicionar.Name = "Tb_Coisa_para_Adicionar";
            this.Tb_Coisa_para_Adicionar.Size = new System.Drawing.Size(265, 26);
            this.Tb_Coisa_para_Adicionar.TabIndex = 3;
            // 
            // btn_Remover
            // 
            this.btn_Remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remover.Location = new System.Drawing.Point(12, 405);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(383, 33);
            this.btn_Remover.TabIndex = 4;
            this.btn_Remover.Text = "Remover Tudo";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_show_cars
            // 
            this.btn_show_cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_cars.Location = new System.Drawing.Point(12, 444);
            this.btn_show_cars.Name = "btn_show_cars";
            this.btn_show_cars.Size = new System.Drawing.Size(383, 32);
            this.btn_show_cars.TabIndex = 5;
            this.btn_show_cars.Text = "Mostrar Carros";
            this.btn_show_cars.UseVisualStyleBackColor = true;
            this.btn_show_cars.Click += new System.EventHandler(this.btn_show_cars_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(408, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.linkLabelToolStripMenuItem1,
            this.listBoxToolStripMenuItem,
            this.listViewToolStripMenuItem});
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.checkBoxToolStripMenuItem.Text = "Componentes";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abrirToolStripMenuItem.Text = "CheckBox";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // checkedListBoxToolStripMenuItem
            // 
            this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            this.checkedListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkedListBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dataToolStripMenuItem.Text = "DataTimerPicker";
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // linkLabelToolStripMenuItem1
            // 
            this.linkLabelToolStripMenuItem1.Name = "linkLabelToolStripMenuItem1";
            this.linkLabelToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.linkLabelToolStripMenuItem1.Text = "LinkLabel";
            this.linkLabelToolStripMenuItem1.Click += new System.EventHandler(this.linkLabelToolStripMenuItem1_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listViewToolStripMenuItem.Text = "ListView";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 507);
            this.Controls.Add(this.btn_show_cars);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.Tb_Coisa_para_Adicionar);
            this.Controls.Add(this.Tb_Tudo);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.TextBox Tb_Coisa_para_Adicionar;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_show_cars;
        public System.Windows.Forms.TextBox Tb_Tudo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkLabelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
    }
}

