using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WBoot
{
    public partial class Form2 : Form
    {
        public object Profile { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void createProfile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            createNewProfile();
        }

        public void createNewProfile()
        {
            WBoot.ProfileData.stateNew = true;
            ProfileData.ProfileList.Add(inputAddProfile.Text);
            ProfileData.ContactList.Add("");
            ProfileData.MessageList.Add("");
            ProfileData.TimeList.Add("0:00 PM");

            this.Close();
        }
        private void inputAddProfile_TextChanged(object sender, EventArgs e)
        {
            

        }
       

    }
}
