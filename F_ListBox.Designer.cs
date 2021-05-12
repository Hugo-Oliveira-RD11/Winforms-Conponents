
namespace Componetes
{
    partial class F_ListBox
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
            this.Lb_Tudo = new System.Windows.Forms.ListBox();
            this.Tb_Adicionar = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Obter = new System.Windows.Forms.Button();
            this.lb_Carro = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_Tudo
            // 
            this.Lb_Tudo.FormattingEnabled = true;
            this.Lb_Tudo.ItemHeight = 16;
            this.Lb_Tudo.Location = new System.Drawing.Point(13, 13);
            this.Lb_Tudo.Name = "Lb_Tudo";
            this.Lb_Tudo.Size = new System.Drawing.Size(164, 228);
            this.Lb_Tudo.TabIndex = 0;
            // 
            // Tb_Adicionar
            // 
            this.Tb_Adicionar.Location = new System.Drawing.Point(183, 36);
            this.Tb_Adicionar.Name = "Tb_Adicionar";
            this.Tb_Adicionar.Size = new System.Drawing.Size(194, 22);
            this.Tb_Adicionar.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(183, 64);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(194, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Adicionar";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(183, 93);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(194, 23);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "Remover";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Obter
            // 
            this.btn_Obter.Location = new System.Drawing.Point(183, 122);
            this.btn_Obter.Name = "btn_Obter";
            this.btn_Obter.Size = new System.Drawing.Size(194, 23);
            this.btn_Obter.TabIndex = 4;
            this.btn_Obter.Text = "Obter";
            this.btn_Obter.UseVisualStyleBackColor = true;
            this.btn_Obter.Click += new System.EventHandler(this.button3_Click);
            // 
            // lb_Carro
            // 
            this.lb_Carro.AutoSize = true;
            this.lb_Carro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Carro.Location = new System.Drawing.Point(184, 13);
            this.lb_Carro.Name = "lb_Carro";
            this.lb_Carro.Size = new System.Drawing.Size(51, 20);
            this.lb_Carro.TabIndex = 5;
            this.lb_Carro.Text = "Carro";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(183, 152);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(194, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lb_Carro);
            this.Controls.Add(this.btn_Obter);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.Tb_Adicionar);
            this.Controls.Add(this.Lb_Tudo);
            this.Name = "F_ListBox";
            this.Text = "F_ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lb_Tudo;
        private System.Windows.Forms.TextBox Tb_Adicionar;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Obter;
        private System.Windows.Forms.Label lb_Carro;
        private System.Windows.Forms.Button btn_clear;
    }
}