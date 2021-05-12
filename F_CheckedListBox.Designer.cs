
namespace Componetes
{
    partial class F_CheckedListBox
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
            this.Clb_All = new System.Windows.Forms.CheckedListBox();
            this.btn_ShowChecked = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lb_New_Transport = new System.Windows.Forms.Label();
            this.btn_Add_List = new System.Windows.Forms.Button();
            this.tb_NewTransports = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Clb_All
            // 
            this.Clb_All.FormattingEnabled = true;
            this.Clb_All.Items.AddRange(new object[] {
            "carro",
            "barco",
            "moto",
            "avião",
            "cavalo",
            "porco",
            "mamute"});
            this.Clb_All.Location = new System.Drawing.Point(13, 13);
            this.Clb_All.Name = "Clb_All";
            this.Clb_All.Size = new System.Drawing.Size(215, 310);
            this.Clb_All.TabIndex = 0;
            // 
            // btn_ShowChecked
            // 
            this.btn_ShowChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowChecked.Location = new System.Drawing.Point(235, 13);
            this.btn_ShowChecked.Name = "btn_ShowChecked";
            this.btn_ShowChecked.Size = new System.Drawing.Size(311, 34);
            this.btn_ShowChecked.TabIndex = 1;
            this.btn_ShowChecked.Text = "Mostrar Selecionados";
            this.btn_ShowChecked.UseVisualStyleBackColor = true;
            this.btn_ShowChecked.Click += new System.EventHandler(this.btn_ShowChecked_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(235, 53);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(311, 29);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "Limpar a lista";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(234, 88);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(312, 29);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Resetar a Lista";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lb_New_Transport
            // 
            this.lb_New_Transport.AutoSize = true;
            this.lb_New_Transport.Location = new System.Drawing.Point(234, 220);
            this.lb_New_Transport.Name = "lb_New_Transport";
            this.lb_New_Transport.Size = new System.Drawing.Size(171, 17);
            this.lb_New_Transport.TabIndex = 4;
            this.lb_New_Transport.Text = "Digite um novo transporte";
            // 
            // btn_Add_List
            // 
            this.btn_Add_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_List.Location = new System.Drawing.Point(235, 291);
            this.btn_Add_List.Name = "btn_Add_List";
            this.btn_Add_List.Size = new System.Drawing.Size(309, 32);
            this.btn_Add_List.TabIndex = 5;
            this.btn_Add_List.Text = "Adicionar items na Lista";
            this.btn_Add_List.UseVisualStyleBackColor = true;
            this.btn_Add_List.Click += new System.EventHandler(this.btn_Add_List_Click);
            // 
            // tb_NewTransports
            // 
            this.tb_NewTransports.Location = new System.Drawing.Point(239, 252);
            this.tb_NewTransports.Name = "tb_NewTransports";
            this.tb_NewTransports.Size = new System.Drawing.Size(307, 22);
            this.tb_NewTransports.TabIndex = 6;
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 340);
            this.Controls.Add(this.tb_NewTransports);
            this.Controls.Add(this.btn_Add_List);
            this.Controls.Add(this.lb_New_Transport);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_ShowChecked);
            this.Controls.Add(this.Clb_All);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Clb_All;
        private System.Windows.Forms.Button btn_ShowChecked;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lb_New_Transport;
        private System.Windows.Forms.Button btn_Add_List;
        private System.Windows.Forms.TextBox tb_NewTransports;
    }
}