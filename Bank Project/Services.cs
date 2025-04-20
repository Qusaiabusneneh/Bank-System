using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Project
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }
        void ShowAddClientScreen()
        {
            Form frm1 = new Add_Client();
            frm1.ShowDialog();
        }

        void ShowDeleteClientScreen()
        {
            Form frm = new Delete_Client();
            frm.ShowDialog();
        }

        void ShowUpdateClientScreen()
        {
            Form frm1 = new Update_Clinet();
            frm1.ShowDialog();
        }

        void ShowFindClientScreen()
        {
            Form frm1 = new Find_Client();
            frm1.ShowDialog();
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClient.SelectedIndex==0)
            {
                ShowAddClientScreen();
            }
            else if (cmbClient.SelectedIndex==1)
            {
                ShowDeleteClientScreen();
            }
            else if (cmbClient.SelectedIndex==2)
            {
                ShowUpdateClientScreen();
            }
            else
            {
                ShowFindClientScreen();
            }
        }

        private void TSMAddNewClient_Click(object sender, EventArgs e)
        {
            ShowAddClientScreen();
        }

        private void TSMDeleteClient_Click(object sender, EventArgs e)
        {
            ShowDeleteClientScreen();
        }

        private void TSMUpdateClient_Click(object sender, EventArgs e)
        {
            ShowUpdateClientScreen();
        }

        private void TSMFindClinet_Click(object sender, EventArgs e)
        {
            ShowFindClientScreen();
        }

        void ShowAddUserScreen()
        {
            Form frm1 = new Add_User();
            frm1.ShowDialog();
        }

        void ShowDeleteUserScreen()
        {
            Form frm1 = new Delete_User();
            frm1.ShowDialog();
        }

        void ShowUpdateUserScreen()
        {
            Form frm1 = new Update_User();
            frm1.ShowDialog();
        }

        void ShowFindUserScreen()
        {
            Form frm1 = new Find_User();
            frm1.ShowDialog();
        }

        void ShowINFOScreen()
        {
            Form frm1 = new BankINFO();
            frm1.ShowDialog();
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbUser.SelectedIndex==0)
            {
                ShowAddUserScreen();
            }
            else if (cmbUser.SelectedIndex==1)
            {
                ShowDeleteUserScreen();
            }
            else if (cmbUser.SelectedIndex==2)
            {
                ShowUpdateUserScreen();
            }
            else if(cmbUser.SelectedIndex==3)
            {
                ShowFindUserScreen();
            }
            else
            {
                ShowINFOScreen();
            }
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDeleteUserScreen();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAddUserScreen();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUpdateUserScreen();
        }

        private void findUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFindUserScreen();
        }

        private void clientTransationINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new BankINFO();
            frm1.Show();
        }

        void ShowDepositScreen()
        {
            Form frm1 = new Deposit();
            frm1.ShowDialog();
        }

        void ShowWithdrawScreen()
        {
            Form frm1 = new WithDraw_Screen();
            frm1.ShowDialog();
        }

        void ShowTotalBalanceScreen()
        {
            MessageBox.Show("Total Balance is ", "Total Balance",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TSMDeposit_Click(object sender, EventArgs e)
        {
            ShowDepositScreen();
        }

        private void TSMWithdraw_Click(object sender, EventArgs e)
        {
            ShowWithdrawScreen();
        }

        private void TSMTotalBalance_Click(object sender, EventArgs e)
        {
            ShowTotalBalanceScreen();
        }

        private void cmbTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTransaction.SelectedIndex==0)
            {
                ShowDepositScreen();
            }
            else if (cmbTransaction.SelectedIndex==1)
            {
                ShowWithdrawScreen();
            }
            else
            {
                ShowTotalBalanceScreen();
            }
        }
    }
}
