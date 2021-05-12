
namespace Componetes
{
    partial class F_ComboBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_Veiculos = new System.Windows.Forms.ComboBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lb_Add = new System.Windows.Forms.Label();
            this.tb_Add = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Veiculos
            // 
            this.cb_Veiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Veiculos.FormattingEnabled = true;
            this.cb_Veiculos.Items.AddRange(new object[] {
            "Carro",
            "Moto",
            "Avião",
            "Barco",
            "Porco",
            "Vaca"});
            this.cb_Veiculos.Location = new System.Drawing.Point(12, 12);
            this.cb_Veiculos.Name = "cb_Veiculos";
            this.cb_Veiculos.Size = new System.Drawing.Size(190, 28);
            this.cb_Veiculos.TabIndex = 0;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(221, 46);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(234, 28);
            this.btn_Reset.TabIndex = 1;
            this.btn_Reset.Text = "Restaurar";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(221, 80);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(234, 29);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lb_Add
            // 
            this.lb_Add.AutoSize = true;
            this.lb_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Add.Location = new System.Drawing.Point(217, 173);
            this.lb_Add.Name = "lb_Add";
            this.lb_Add.Size = new System.Drawing.Size(202, 20);
            this.lb_Add.TabIndex = 3;
            this.lb_Add.Text = "Adicione Nova opção aqui";
            // 
            // tb_Add
            // 
            this.tb_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Add.Location = new System.Drawing.Point(221, 214);
            this.tb_Add.Name = "tb_Add";
            this.tb_Add.Size = new System.Drawing.Size(234, 26);
            this.tb_Add.TabIndex = 4;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(221, 257);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(234, 27);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Adicionar";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowAll.Location = new System.Drawing.Point(221, 12);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(234, 28);
            this.btn_ShowAll.TabIndex = 6;
            this.btn_ShowAll.Text = "Mostrar Selecionado";
            this.btn_ShowAll.UseVisualStyleBackColor = true;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 378);
            this.Controls.Add(this.btn_ShowAll);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tb_Add);
            this.Controls.Add(this.lb_Add);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.cb_Veiculos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combobox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Veiculos;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lb_Add;
        private System.Windows.Forms.TextBox tb_Add;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_ShowAll;
    }
}