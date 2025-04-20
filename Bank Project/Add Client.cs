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
    public partial class Add_Client : Form
    {
        public Add_Client()
        {
            InitializeComponent();
        }


        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtName, "Name should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, "");
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();

            }
        }

        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountNumber.Text))
            {
                e.Cancel = true;
                txtAccountNumber.Focus();
                errorProvider1.SetError(txtAccountNumber, "Account Number should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAccountNumber, "");
            }
        }

        private void txtPinCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPinCode.Text))
            {
                e.Cancel = true;
                txtPinCode.Focus();
                errorProvider1.SetError(txtPinCode, "Pin Code should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPinCode, "");
            }
        }

        private void txtAccountBalance_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountBalance.Text))
            {
                e.Cancel = true;
                txtAccountBalance.Focus();
                errorProvider1.SetError(txtAccountBalance, "Account Balance should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAccountBalance, "");
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "Phone should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }
        }
    }
}
