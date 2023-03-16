using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_09
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void log_in_button2_Click(object sender, EventArgs e)
        {
            Form1 form1 =new Form1();
            form1.Show();
            this.Hide();
        }

        private void sign_up_button_Click(object sender, EventArgs e)
        {
            string name = new_name_textBox.Text;
            string user_name = new_username_textBox.Text;
            string password = new_password_textBox.Text;
            int count = password.Length;
            string retype_pass = retype_textBox.Text;

            if(Utility.users.Count > 0)
            {
                foreach(User u in Utility.users)
                {
                    if(count >=6)
                    {
                        if(password == retype_pass)
                        {
                            string path = "userid.txt";
                            StreamWriter sw = File.AppendText(path);
                            User uu = new User(user_name, name, password);
                            Utility.users.Add(uu);
                            string ss = $"{user_name},{password},{name}";
                            MessageBox.Show("Sign Up Successful");
                            sw.WriteLine(ss);
                            sw.Close();

                            Form1 form1= new Form1();
                            form1.Show();
                            this.Hide();
                        }
                    }
                }
            }
            
            
        }

        private void username_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
