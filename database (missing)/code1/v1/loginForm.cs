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
    public partial class loginForm : Form
    {
        Controller controllerObj;
        public loginForm()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string email = emailTextbox.Text;
            string password = passwordTextbox.Text;

            //make sure that both email and password aren't empty textboxes
            if (email.Equals("") || password.Equals(""))
            {
                MessageBox.Show("make sure that both email and passwords aren't empty textboxes");
            }
            else
            {
                //TODO : check if email is present in the database
                if (email.Equals("abdo"))
                {
                    //TODO : check if the password is correct
                    if (password.Equals("1234"))
                    {
                        //TODO : we must open the user insterface , so we must first know the type of the user
                        //TODO : pass the information of the user with the new form
                        string type = "Admin";
                        if (type.Equals("ouwner"))
                        {
                            //TODO: open the owner interface
                        }
                        else if (type.Equals("administrator"))
                        {
                            //TODO: open the administrator interface
                        }
                        else if (type.Equals("Reader"))
                        {
                            //TODO: open the Reader interface
                        }
                        else if (type.Equals("Librarian"))
                        {
                            //TODO: open the Librarian interface
                        }
                    }
                    else
                    {
                        MessageBox.Show("the password is incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("the email is incorrect");
                }

            }

        }

        private void signUplabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //open the sign up form
            signupForm f = new signupForm();
            f.ShowDialog();
        }
    }
}
