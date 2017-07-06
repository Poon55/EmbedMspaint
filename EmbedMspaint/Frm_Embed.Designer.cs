namespace EmbedMspaint
{
    partial class Frm_Embed
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
            this.components = new System.ComponentModel.Container();
            this.embedPanel1 = new EmbedMspaint.EmbedPanel(this.components);
            this.SuspendLayout();
            // 
            // embedPanel1
            // 
            this.embedPanel1.AppProcess = null;
            this.embedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.embedPanel1.Location = new System.Drawing.Point(0, 0);
            this.embedPanel1.Name = "embedPanel1";
            this.embedPanel1.Size = new System.Drawing.Size(569, 375);
            this.embedPanel1.TabIndex = 0;
            // 
            // Frm_Embed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 375);
            this.Controls.Add(this.embedPanel1);
            this.Name = "Frm_Embed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "将画板嵌入到自己的程序窗体内部";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Embed_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private EmbedPanel embedPanel1;
    }
}