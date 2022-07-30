using RacingMaster.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingMaster
{
    public partial class frmIntroduce : Form
    {
        Account account = new Account();

        public frmIntroduce()
        {
            InitializeComponent();
        }

        #region Method
        private void Login()
        {
            using (var context = new RacingMasterContext())
            {
                List<Account> Accounts = context.Accounts.
                    Where(x => x.UserName.Equals(tbUsername.Text)).ToList();
                if (Accounts.Count != 0)
                {
                    Account account = Accounts[0];
                    frmGamePlay newform = new frmGamePlay(account);
                    newform.FormClosed += frm_Close;
                    newform.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Username not found!");
                }
            }
        }

        private void Register()
        {
            if (tbUsername.Text.Trim() != "")
            {
                try
                {
                    account.UserName = tbUsername.Text.Trim();
                    using (var context = new RacingMasterContext())
                    {
                        context.Accounts.Add(account);
                        context.SaveChanges();
                    }
                    Login();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Username already in use!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username!");
            }
            
        }

        private void frm_Close(object sender, EventArgs e)
        {
            tbUsername.Text = null;
            tbUsername.Select();
            this.Visible = true;
        }
        #endregion

        #region Event
        private void btAdd_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void btLog_Click(object sender, EventArgs e)
        {
            Login();
        }
        #endregion
    }
}
