using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v1
{
    public partial class signupForm : Form
    {
        Controller controllerObj;

        public signupForm()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {

            //note : this is reader because only the reader can create email by himself
            string name = nameTextBox.Text;
            string password = passwordTextBox.Text;
            string email = emailTextBox.Text;
            char gender; 
            int age = int.Parse(ageTextbox.Text);

            //check for the entered values
            if(name.Equals(""))
            {
                MessageBox.Show("plz enter your name");
            }    
            else if(email.Equals(""))
            {
                MessageBox.Show("plz enter your email");
            }
            else if(genderComboBox.SelectedItem == null)
            {
                MessageBox.Show("plz select your gender");
            }
            else if(age < 6 || age > 99)
            {
                MessageBox.Show("age must be in range 6 : 99");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("plz enter your password");
            }
            else
            {
                //check for the password to be (0-9 ,A-Z) format 
                bool isValid = true;
                foreach (char s in password)
                {
                    if(s < 48 || (s > 57 && s < 65) || (s > 90 && s < 97) || s >122)
                    {
                        isValid = false;
                        break;
                    }
                }

                if(isValid)
                {
                    gender = genderComboBox.Text.ToCharArray()[0];
                    //the data is correct so insert into Reader table
                    //TODO :  insert into reader entity



                    //after insertion , go back to sign in
                    this.Close();
                }
                else
                {
                    MessageBox.Show("plz make sure that the password contains only characters & numbers _ no special character allowed");
                }

            }
        }
    }
}
