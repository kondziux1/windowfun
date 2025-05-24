using System.Threading;

namespace windowfun
{
    partial class Jump
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
            this.kabel = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // kabel
            // 
            this.kabel.Enabled = true;
            this.kabel.Interval = 16;
            this.kabel.Tick += new System.EventHandler(this.kabel_Tick);
// 
            // jump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::windowfun.Properties.Resources._0710_11_1__00_00_00_00_Still0d01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(120, 120);
            this.ControlBox = false;
            this.DoubleBuffered = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "jump";
            this.ShowIcon = false;
            this.ShowInTaskbar = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "jump";
            this.ResumeLayout(false);
            this.Click += new System.EventHandler(this.ziut_Click);

        }

        #endregion

        private System.Windows.Forms.Timer kabel;
        private System.Windows.Forms.Button button1;
    }
}