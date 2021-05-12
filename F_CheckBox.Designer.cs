
namespace Componetes
{
    partial class F_CheckBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CheckBox));
            this.Cb_Aceitar_Tudo = new System.Windows.Forms.CheckBox();
            this.lb_Contrato = new System.Windows.Forms.Label();
            this.Tb_Todo_Contrato = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cb_Aceitar_Tudo
            // 
            this.Cb_Aceitar_Tudo.AutoSize = true;
            this.Cb_Aceitar_Tudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Aceitar_Tudo.Location = new System.Drawing.Point(144, 488);
            this.Cb_Aceitar_Tudo.Name = "Cb_Aceitar_Tudo";
            this.Cb_Aceitar_Tudo.Size = new System.Drawing.Size(175, 29);
            this.Cb_Aceitar_Tudo.TabIndex = 0;
            this.Cb_Aceitar_Tudo.Text = "Aceitar Contrato";
            this.Cb_Aceitar_Tudo.UseVisualStyleBackColor = true;
            this.Cb_Aceitar_Tudo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lb_Contrato
            // 
            this.lb_Contrato.AutoSize = true;
            this.lb_Contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Contrato.Location = new System.Drawing.Point(174, 41);
            this.lb_Contrato.Name = "lb_Contrato";
            this.lb_Contrato.Size = new System.Drawing.Size(109, 29);
            this.lb_Contrato.TabIndex = 1;
            this.lb_Contrato.Text = "Contrato";
            // 
            // Tb_Todo_Contrato
            // 
            this.Tb_Todo_Contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Todo_Contrato.Location = new System.Drawing.Point(12, 91);
            this.Tb_Todo_Contrato.Multiline = true;
            this.Tb_Todo_Contrato.Name = "Tb_Todo_Contrato";
            this.Tb_Todo_Contrato.ReadOnly = true;
            this.Tb_Todo_Contrato.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tb_Todo_Contrato.Size = new System.Drawing.Size(465, 381);
            this.Tb_Todo_Contrato.TabIndex = 2;
            this.Tb_Todo_Contrato.Text = resources.GetString("Tb_Todo_Contrato.Text");
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(12, 523);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(465, 49);
            this.btn_Ok.TabIndex = 3;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 584);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.Tb_Todo_Contrato);
            this.Controls.Add(this.lb_Contrato);
            this.Controls.Add(this.Cb_Aceitar_Tudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Contrato;
        private System.Windows.Forms.TextBox Tb_Todo_Contrato;
        private System.Windows.Forms.CheckBox Cb_Aceitar_Tudo;
        private System.Windows.Forms.Button btn_Ok;
    }
}