
namespace Componetes
{
    partial class F_DateTimerPicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.btn_captador = new System.Windows.Forms.Button();
            this.tb_TodaData = new System.Windows.Forms.TextBox();
            this.tb_add_ano = new System.Windows.Forms.TextBox();
            this.tb_add_mes = new System.Windows.Forms.TextBox();
            this.tb_add_dia = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_hoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(13, 13);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(304, 22);
            this.dtp_data.TabIndex = 0;
            // 
            // btn_captador
            // 
            this.btn_captador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_captador.Location = new System.Drawing.Point(324, 11);
            this.btn_captador.Name = "btn_captador";
            this.btn_captador.Size = new System.Drawing.Size(349, 33);
            this.btn_captador.TabIndex = 1;
            this.btn_captador.Text = "Pegar a data";
            this.btn_captador.UseVisualStyleBackColor = true;
            this.btn_captador.Click += new System.EventHandler(this.btn_captador_Click);
            // 
            // tb_TodaData
            // 
            this.tb_TodaData.Location = new System.Drawing.Point(12, 41);
            this.tb_TodaData.Name = "tb_TodaData";
            this.tb_TodaData.ReadOnly = true;
            this.tb_TodaData.Size = new System.Drawing.Size(305, 22);
            this.tb_TodaData.TabIndex = 2;
            // 
            // tb_add_ano
            // 
            this.tb_add_ano.Location = new System.Drawing.Point(225, 68);
            this.tb_add_ano.Name = "tb_add_ano";
            this.tb_add_ano.Size = new System.Drawing.Size(91, 22);
            this.tb_add_ano.TabIndex = 8;
            // 
            // tb_add_mes
            // 
            this.tb_add_mes.Location = new System.Drawing.Point(118, 68);
            this.tb_add_mes.Name = "tb_add_mes";
            this.tb_add_mes.Size = new System.Drawing.Size(100, 22);
            this.tb_add_mes.TabIndex = 7;
            // 
            // tb_add_dia
            // 
            this.tb_add_dia.Location = new System.Drawing.Point(12, 69);
            this.tb_add_dia.Name = "tb_add_dia";
            this.tb_add_dia.Size = new System.Drawing.Size(100, 22);
            this.tb_add_dia.TabIndex = 6;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adicionar.Location = new System.Drawing.Point(323, 67);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(349, 32);
            this.btn_Adicionar.TabIndex = 9;
            this.btn_Adicionar.Text = "Adicionar Data";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_hoje
            // 
            this.btn_hoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoje.Location = new System.Drawing.Point(324, 120);
            this.btn_hoje.Name = "btn_hoje";
            this.btn_hoje.Size = new System.Drawing.Size(348, 30);
            this.btn_hoje.TabIndex = 10;
            this.btn_hoje.Text = "hoje";
            this.btn_hoje.UseVisualStyleBackColor = true;
            this.btn_hoje.Click += new System.EventHandler(this.btn_hoje_Click);
            // 
            // F_DateTimerPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 249);
            this.Controls.Add(this.btn_hoje);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.tb_add_ano);
            this.Controls.Add(this.tb_add_mes);
            this.Controls.Add(this.tb_add_dia);
            this.Controls.Add(this.tb_TodaData);
            this.Controls.Add(this.btn_captador);
            this.Controls.Add(this.dtp_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_DateTimerPicker";
            this.Text = "F_DateTimerPicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Button btn_captador;
        private System.Windows.Forms.TextBox tb_TodaData;
        private System.Windows.Forms.TextBox tb_add_ano;
        private System.Windows.Forms.TextBox tb_add_mes;
        private System.Windows.Forms.TextBox tb_add_dia;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_hoje;
    }
}