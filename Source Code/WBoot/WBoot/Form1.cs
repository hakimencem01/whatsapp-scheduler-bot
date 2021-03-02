using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;



namespace WBoot
{
   
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

           
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
             
            try
            {
                string textdata = File.ReadAllText(@"Data.txt");
                textdata = textdata.Replace('\r', ' ');
                string[] splitdata = textdata.Split(new char[] { '\n' }); // split per profile
                foreach (string perProfile in splitdata)

                {
                    
                    string[] splitProfileData = perProfile.Split(';');
                    string ProfileName = splitProfileData[0];
                    string contactData = splitProfileData[1];
                    string contentData = splitProfileData[2];
                    string TimeData = splitProfileData[3];

                    // Add all data to ProfileData memory
                    ProfileData.ProfileList.Add(ProfileName);
                    ProfileData.ContactList.Add(contactData);
                    ProfileData.MessageList.Add(contentData);
                    ProfileData.TimeList.Add(TimeData);
                } 
                
            }
            catch (Exception y) { }
            

            // adding profile name list to combobox
            RefreshList();
         

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string clockCurrent = DateTime.Now.ToString("h:mm:ss tt");
            clocktime.Text = clockCurrent;
            string listof = "";
            if (ProfileData.stateNew == true) // if new profile added. refresh list
            {
                ProfileData.stateNew = false;
                ProfileListBox.Items.Clear();

                
                int index = 0;
                foreach (string profile in ProfileData.ProfileList)
                {
                    ProfileListBox.Items.Add(profile);
                    
                    index++;

                }

            }
            System.Threading.Thread.Sleep(100);
            int indexx = 0;
            foreach (string message in ProfileData.TimeList)
            {
                listof += message + "\n";
                indexx++;

            }
           
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            ProfileData.TimeList[(ProfileData.currentProfileSelected)] = timebox.Text;
        }

        private void settime_Click(object sender, EventArgs e)
        {
            // ready data
            // name;content;time
            /*
            */

            RewriteData();
            MessageBox.Show("Profile Saved !");
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ProfileData.ContactList[ProfileData.currentProfileSelected] = contactname.Text;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

      

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ProfileData.currentProfileSelected = ProfileListBox.Items.IndexOf(ProfileListBox.Text);
            int currentnum = ProfileData.currentProfileSelected;
           
            contactname.Text = ProfileData.ContactList[currentnum].ToString();
            content.Text = ProfileData.MessageList[currentnum].ToString();
            timebox.Text = ProfileData.TimeList[currentnum].ToString();


        }

        private void AddProfile_Click(object sender, EventArgs e)
        {

            Form f2 = new Form2();
            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void content_TextChanged(object sender, EventArgs e)
        {
            ProfileData.MessageList[ProfileData.currentProfileSelected] = content.Text;
        }

        private void deleteprofile_Click(object sender, EventArgs e)
        {
            ProfileData.ProfileList.RemoveAt(ProfileData.currentProfileSelected);
            ProfileData.ContactList.RemoveAt(ProfileData.currentProfileSelected);
            ProfileData.MessageList.RemoveAt(ProfileData.currentProfileSelected);
            ProfileData.TimeList.RemoveAt(ProfileData.currentProfileSelected);
            
            RefreshList();
            RewriteData();

        }
        public void RefreshList()
        {
            ProfileListBox.Text = "Profiles . . .";
            ProfileListBox.Items.Clear();
            string listof = "";
            int index = 0;
            foreach (string profile in ProfileData.ProfileList)
            {
                ProfileListBox.Items.Add(profile);

                listof += ProfileData.ProfileList[index];
                index++;


            }
        }
        private void RewriteData()
        {

            string fullData = "";
            int currentselection = (ProfileData.currentProfileSelected);
            ProfileData.MessageList[currentselection] = content.Text;
            ProfileData.ContactList[currentselection] = contactname.Text;
            ProfileData.TimeList[currentselection] = timebox.Text;

            for (int x = 0; x < (ProfileData.ProfileList.Count); x++)
            {
                fullData += ProfileData.ProfileList[x] + ";" + ProfileData.ContactList[x] + ";" + ProfileData.MessageList[x] + ";" +
                            ProfileData.TimeList[x] + "\r\n";
            }
            try
            {
                File.WriteAllText(@"Data.txt", fullData);
            }
            catch (Exception x)
            {

            }
           

        }
    }
   
    public class ProfileData
    {
        public static ArrayList ProfileList = new ArrayList();
        public static ArrayList ContactList = new ArrayList();
        public static ArrayList MessageList = new ArrayList();
        public static ArrayList TimeList = new ArrayList();
        public static bool stateNew = false;
        public static int currentProfileSelected = 0;
    }

    
    
}
