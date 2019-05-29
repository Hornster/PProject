using Desktop.Forms.Workspace;
using Desktop.Model.Authorization;
using Desktop.Network.Implementation;
using Desktop.Network.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Forms.Authorization
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handler for event that occurs when user presses signing in button.
        /// Validates input and initializes connection to database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string serverAddress = textBoxServerAddress.Text;
            IAuthManager authManager = new MockAuthManager();
            string errorMessage = authManager.SignIn(serverAddress, username, password);
            if (errorMessage == null)
            {
                Form main = new FormMain(this);
                main.Show();
                this.Hide();
                this.ClearFields();                    
            }else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void ClearFields()
        {
            textBoxPassword.Text = "";
        }

    }
}
