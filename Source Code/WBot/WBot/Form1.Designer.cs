namespace WBot
{
    partial class Form1
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
            this.HRS = new System.Windows.Forms.TextBox();
            this.MIN = new System.Windows.Forms.TextBox();
            this.MERIDIAN = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // HRS
            // 
            this.HRS.Location = new System.Drawing.Point(16, 19);
            this.HRS.Name = "HRS";
            this.HRS.Size = new System.Drawing.Size(48, 20);
            this.HRS.TabIndex = 0;
            // 
            // MIN
            // 
            this.MIN.Location = new System.Drawing.Point(70, 19);
            this.MIN.Name = "MIN";
            this.MIN.Size = new System.Drawing.Size(51, 20);
            this.MIN.TabIndex = 1;
            // 
            // MERIDIAN
            // 
            this.MERIDIAN.Location = new System.Drawing.Point(127, 19);
            this.MERIDIAN.Name = "MERIDIAN";
            this.MERIDIAN.Size = new System.Drawing.Size(31, 20);
            this.MERIDIAN.TabIndex = 2;
            this.MERIDIAN.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 176);
            this.Controls.Add(this.MERIDIAN);
            this.Controls.Add(this.MIN);
            this.Controls.Add(this.HRS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HRS;
        private System.Windows.Forms.TextBox MIN;
        private System.Windows.Forms.TextBox MERIDIAN;
        private System.Windows.Forms.Timer Timer;
    }
}