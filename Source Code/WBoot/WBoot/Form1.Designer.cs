namespace WBoot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clocktime = new System.Windows.Forms.Label();
            this.settime = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.timebox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.content = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.contactname = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.deleteprofile = new System.Windows.Forms.Button();
            this.AddProfile = new System.Windows.Forms.Button();
            this.ProfileListBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clocktime);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Time";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // clocktime
            // 
            this.clocktime.AutoSize = true;
            this.clocktime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clocktime.Location = new System.Drawing.Point(16, 16);
            this.clocktime.Name = "clocktime";
            this.clocktime.Size = new System.Drawing.Size(112, 42);
            this.clocktime.TabIndex = 1;
            this.clocktime.Text = "00:00";
            // 
            // settime
            // 
            this.settime.BackColor = System.Drawing.Color.MediumTurquoise;
            this.settime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settime.Location = new System.Drawing.Point(282, 161);
            this.settime.Name = "settime";
            this.settime.Size = new System.Drawing.Size(92, 25);
            this.settime.TabIndex = 2;
            this.settime.Text = "Save Profile";
            this.settime.UseVisualStyleBackColor = false;
            this.settime.Click += new System.EventHandler(this.settime_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.settime);
            this.groupBox2.Location = new System.Drawing.Point(12, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 186);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message Information";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.timebox);
            this.groupBox6.Location = new System.Drawing.Point(276, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(87, 49);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Time";
            // 
            // timebox
            // 
            this.timebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timebox.Location = new System.Drawing.Point(6, 17);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(75, 22);
            this.timebox.TabIndex = 1;
            this.timebox.Text = "00:00 PM";
            this.timebox.WordWrap = false;
            this.timebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.content);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Location = new System.Drawing.Point(9, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 112);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Content";
            // 
            // content
            // 
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.content.Location = new System.Drawing.Point(6, 13);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(249, 93);
            this.content.TabIndex = 5;
            this.content.Text = "";
            this.content.TextChanged += new System.EventHandler(this.content_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.contactname);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(9, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 49);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Name";
            // 
            // contactname
            // 
            this.contactname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactname.Location = new System.Drawing.Point(6, 19);
            this.contactname.Name = "contactname";
            this.contactname.Size = new System.Drawing.Size(249, 20);
            this.contactname.TabIndex = 5;
            this.contactname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WBoot.Properties.Resources.whatsbot;
            this.pictureBox2.Location = new System.Drawing.Point(403, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 68);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "WhatsApp ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bot V1.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Schedule";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.deleteprofile);
            this.groupBox5.Controls.Add(this.AddProfile);
            this.groupBox5.Controls.Add(this.ProfileListBox);
            this.groupBox5.Location = new System.Drawing.Point(12, 97);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(374, 51);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Profile";
            // 
            // deleteprofile
            // 
            this.deleteprofile.Location = new System.Drawing.Point(319, 19);
            this.deleteprofile.Name = "deleteprofile";
            this.deleteprofile.Size = new System.Drawing.Size(32, 23);
            this.deleteprofile.TabIndex = 2;
            this.deleteprofile.Text = "X";
            this.deleteprofile.UseVisualStyleBackColor = true;
            this.deleteprofile.Click += new System.EventHandler(this.deleteprofile_Click);
            // 
            // AddProfile
            // 
            this.AddProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProfile.Location = new System.Drawing.Point(277, 19);
            this.AddProfile.Name = "AddProfile";
            this.AddProfile.Size = new System.Drawing.Size(36, 23);
            this.AddProfile.TabIndex = 1;
            this.AddProfile.Text = " +";
            this.AddProfile.UseVisualStyleBackColor = true;
            this.AddProfile.Click += new System.EventHandler(this.AddProfile_Click);
            // 
            // ProfileListBox
            // 
            this.ProfileListBox.DisplayMember = "Select Profile";
            this.ProfileListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileListBox.FormattingEnabled = true;
            this.ProfileListBox.Location = new System.Drawing.Point(6, 19);
            this.ProfileListBox.Name = "ProfileListBox";
            this.ProfileListBox.Size = new System.Drawing.Size(264, 24);
            this.ProfileListBox.TabIndex = 0;
            this.ProfileListBox.ValueMember = "Select Profile";
            this.ProfileListBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(744, 382);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Whatzapp Schedule Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label clocktime;
        private System.Windows.Forms.Button settime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox content;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox contactname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox ProfileListBox;
        private System.Windows.Forms.Button deleteprofile;
        private System.Windows.Forms.Button AddProfile;
        private System.Windows.Forms.TextBox timebox;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

