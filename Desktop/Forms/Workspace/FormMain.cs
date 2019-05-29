using Desktop.Forms.Authorization;
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

namespace Desktop.Forms.Workspace
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// A reference to form responsible for signing in, which is shown after user logs out.
        /// </summary>
        private Form signInForm;

        /// <summary>
        /// 
        /// </summary>
        public FormMain(Form signInForm)
        {
            InitializeComponent();
            this.signInForm = signInForm;

        }

        /// <summary>
        /// Logs out user and closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonShowBuildings_Click(object sender, EventArgs e)
        {
            new FormBuildings().Show();
        }

        /// <summary>
        /// Event handler for form closing. Asks whether user is sure and logs user out.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            IAuthManager authManager = new MockAuthManager();
            try
            {
                authManager.SignOut();
                signInForm.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                e.Cancel = true;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
