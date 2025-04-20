namespace Bank_Project
{
    partial class BankINFO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tapControl1 = new System.Windows.Forms.TabControl();
            this.tabPaClient = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chAccountNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPinCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAccountBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabpUser = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.chUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPermission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabpTransaction = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.chDeposit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWithdraw = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tapControl1.SuspendLayout();
            this.tabPaClient.SuspendLayout();
            this.tabpUser.SuspendLayout();
            this.tabpTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tapControl1
            // 
            this.tapControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tapControl1.Controls.Add(this.tabPaClient);
            this.tapControl1.Controls.Add(this.tabpUser);
            this.tapControl1.Controls.Add(this.tabpTransaction);
            this.tapControl1.Location = new System.Drawing.Point(137, 79);
            this.tapControl1.Name = "tapControl1";
            this.tapControl1.SelectedIndex = 0;
            this.tapControl1.Size = new System.Drawing.Size(525, 359);
            this.tapControl1.TabIndex = 0;
            // 
            // tabPaClient
            // 
            this.tabPaClient.Controls.Add(this.listView1);
            this.tabPaClient.Location = new System.Drawing.Point(4, 25);
            this.tabPaClient.Name = "tabPaClient";
            this.tabPaClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaClient.Size = new System.Drawing.Size(517, 330);
            this.tabPaClient.TabIndex = 0;
            this.tabPaClient.Text = "Client";
            this.tabPaClient.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.SlateGray;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAccountNumber,
            this.chPinCode,
            this.chName,
            this.chPhone,
            this.chAccountBalance});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-4, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(526, 334);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chAccountNumber
            // 
            this.chAccountNumber.DisplayIndex = 2;
            this.chAccountNumber.Text = "Account Number";
            this.chAccountNumber.Width = 129;
            // 
            // chPinCode
            // 
            this.chPinCode.Text = "Pin Code";
            this.chPinCode.Width = 81;
            // 
            // chName
            // 
            this.chName.DisplayIndex = 0;
            this.chName.Text = "Name";
            this.chName.Width = 80;
            // 
            // chPhone
            // 
            this.chPhone.DisplayIndex = 4;
            this.chPhone.Text = "Phone";
            this.chPhone.Width = 136;
            // 
            // chAccountBalance
            // 
            this.chAccountBalance.DisplayIndex = 3;
            this.chAccountBalance.Text = "Account Balance";
            this.chAccountBalance.Width = 115;
            // 
            // tabpUser
            // 
            this.tabpUser.Controls.Add(this.listView2);
            this.tabpUser.Location = new System.Drawing.Point(4, 25);
            this.tabpUser.Name = "tabpUser";
            this.tabpUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabpUser.Size = new System.Drawing.Size(517, 330);
            this.tabpUser.TabIndex = 1;
            this.tabpUser.Text = "User";
            this.tabpUser.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.SlateGray;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUsername,
            this.chPassword,
            this.chPermission});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(-4, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(521, 334);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // chUsername
            // 
            this.chUsername.DisplayIndex = 2;
            this.chUsername.Text = "Username";
            this.chUsername.Width = 135;
            // 
            // chPassword
            // 
            this.chPassword.Text = "Password";
            this.chPassword.Width = 201;
            // 
            // chPermission
            // 
            this.chPermission.DisplayIndex = 0;
            this.chPermission.Text = "Permission";
            this.chPermission.Width = 182;
            // 
            // tabpTransaction
            // 
            this.tabpTransaction.Controls.Add(this.listView3);
            this.tabpTransaction.Location = new System.Drawing.Point(4, 25);
            this.tabpTransaction.Name = "tabpTransaction";
            this.tabpTransaction.Size = new System.Drawing.Size(517, 330);
            this.tabpTransaction.TabIndex = 2;
            this.tabpTransaction.Text = "Transaction";
            this.tabpTransaction.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.BackColor = System.Drawing.Color.SlateGray;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDeposit,
            this.chWithdraw});
            this.listView3.GridLines = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(-4, 1);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(521, 333);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // chDeposit
            // 
            this.chDeposit.DisplayIndex = 1;
            this.chDeposit.Text = "Deposit";
            this.chDeposit.Width = 282;
            // 
            // chWithdraw
            // 
            this.chWithdraw.DisplayIndex = 0;
            this.chWithdraw.Text = "Withdraw";
            this.chWithdraw.Width = 237;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bank INFO";
            // 
            // BankINFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tapControl1);
            this.Name = "BankINFO";
            this.Text = "BankINFO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tapControl1.ResumeLayout(false);
            this.tabPaClient.ResumeLayout(false);
            this.tabpUser.ResumeLayout(false);
            this.tabpTransaction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tapControl1;
        private System.Windows.Forms.TabPage tabPaClient;
        private System.Windows.Forms.TabPage tabpUser;
        private System.Windows.Forms.TabPage tabpTransaction;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chAccountNumber;
        private System.Windows.Forms.ColumnHeader chPinCode;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPhone;
        private System.Windows.Forms.ColumnHeader chAccountBalance;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader chUsername;
        private System.Windows.Forms.ColumnHeader chPassword;
        private System.Windows.Forms.ColumnHeader chPermission;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader chDeposit;
        private System.Windows.Forms.ColumnHeader chWithdraw;
        private System.Windows.Forms.Label label1;
    }
}