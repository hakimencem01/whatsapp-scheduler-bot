namespace WBoot
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputAddProfile = new System.Windows.Forms.TextBox();
            this.addProfile_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputAddProfile);
            this.groupBox1.Controls.Add(this.addProfile_btn);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Profile";
            // 
            // inputAddProfile
            // 
            this.inputAddProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputAddProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAddProfile.Location = new System.Drawing.Point(9, 18);
            this.inputAddProfile.Name = "inputAddProfile";
            this.inputAddProfile.Size = new System.Drawing.Size(242, 24);
            this.inputAddProfile.TabIndex = 1;
            this.inputAddProfile.TextChanged += new System.EventHandler(this.inputAddProfile_TextChanged);
            // 
            // addProfile_btn
            // 
            this.addProfile_btn.Location = new System.Drawing.Point(257, 11);
            this.addProfile_btn.Name = "addProfile_btn";
            this.addProfile_btn.Size = new System.Drawing.Size(73, 31);
            this.addProfile_btn.TabIndex = 1;
            this.addProfile_btn.Text = "Add Profile";
            this.addProfile_btn.UseVisualStyleBackColor = true;
            this.addProfile_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 57);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Create Profile";
            this.Load += new System.EventHandler(this.createProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputAddProfile;
        private System.Windows.Forms.Button addProfile_btn;
    }
}