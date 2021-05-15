
namespace Componetes
{
    partial class F_ListView
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
            this.lv_Tudo = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lv_Tudo
            // 
            this.lv_Tudo.HideSelection = false;
            this.lv_Tudo.Location = new System.Drawing.Point(13, 13);
            this.lv_Tudo.MultiSelect = false;
            this.lv_Tudo.Name = "lv_Tudo";
            this.lv_Tudo.Size = new System.Drawing.Size(758, 307);
            this.lv_Tudo.TabIndex = 0;
            this.lv_Tudo.UseCompatibleStateImageBehavior = false;
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 600);
            this.Controls.Add(this.lv_Tudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ListView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Tudo;
    }
}