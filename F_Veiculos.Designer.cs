
namespace Componetes
{
    partial class F_Veiculos
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
            this.Tb_Mostrar_tudo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tb_Mostrar_tudo
            // 
            this.Tb_Mostrar_tudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Mostrar_tudo.Location = new System.Drawing.Point(12, 12);
            this.Tb_Mostrar_tudo.Multiline = true;
            this.Tb_Mostrar_tudo.Name = "Tb_Mostrar_tudo";
            this.Tb_Mostrar_tudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tb_Mostrar_tudo.Size = new System.Drawing.Size(528, 366);
            this.Tb_Mostrar_tudo.TabIndex = 0;
            // 
            // F_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 388);
            this.Controls.Add(this.Tb_Mostrar_tudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Veiculos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Veiculos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_Mostrar_tudo;
    }
}