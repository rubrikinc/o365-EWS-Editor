namespace EWSEditor.Forms
{
    partial class ServiceDialog
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
        private new void InitializeComponent()
        {
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtXAnchorMailbox = new System.Windows.Forms.TextBox();
            this.chkSetXAnchorMailbox = new System.Windows.Forms.CheckBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TempConnectingIdCombo = new System.Windows.Forms.ComboBox();
            this.lblImpIdType = new System.Windows.Forms.Label();
            this.ImpersonationCheck = new System.Windows.Forms.CheckBox();
            this.lblImpId = new System.Windows.Forms.Label();
            this.ImpersonatedIdTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDefaultUserNameSmtp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOAuthAuthority = new System.Windows.Forms.TextBox();
            this.lblOAuthAuthority = new System.Windows.Forms.Label();
            this.txtOAuthServerName = new System.Windows.Forms.TextBox();
            this.lblOAuthServerName = new System.Windows.Forms.Label();
            this.txtOAuthAppId = new System.Windows.Forms.TextBox();
            this.lblOAuthRedirectUri = new System.Windows.Forms.Label();
            this.lblOAuthAppId = new System.Windows.Forms.Label();
            this.txtOAuthRedirectUri = new System.Windows.Forms.TextBox();
            this.rdoCredentialsDefaultWindows = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoCredentialsOAuth = new System.Windows.Forms.RadioButton();
            this.rdoCredentialsUserSpecified = new System.Windows.Forms.RadioButton();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.lblExImp = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDefaultSmtp = new System.Windows.Forms.Button();
            this.btnDefault365Settings = new System.Windows.Forms.Button();
            this.rdoServiceUrl = new System.Windows.Forms.RadioButton();
            this.rdoAutodiscoverEmail = new System.Windows.Forms.RadioButton();
            this.lblUseAutodiscoverCheck = new System.Windows.Forms.Label();
            this.lblExchangeServiceURLTextDesc = new System.Windows.Forms.Label();
            this.lblAutodiscoverEmailDesc = new System.Windows.Forms.Label();
            this.ExchangeServiceURLText = new System.Windows.Forms.TextBox();
            this.AutodiscoverEmailText = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.TempExchangeVersionCombo = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtXPublicFolderMailbox = new System.Windows.Forms.TextBox();
            this.chkSetXPublicFolderMailbox = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtAuthority = new System.Windows.Forms.TextBox();
            this.lblAppSecretAuthority = new System.Windows.Forms.Label();
            this.lblTenantID = new System.Windows.Forms.Label();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.lblAppSecret = new System.Windows.Forms.Label();
            this.lblAppID = new System.Windows.Forms.Label();
            this.rdoAppSecretOauth = new System.Windows.Forms.RadioButton();
            this.txtAppSecret = new System.Windows.Forms.TextBox();
            this.txtTenantID = new System.Windows.Forms.TextBox();
            this.txtScope = new System.Windows.Forms.TextBox();
            this.lblScope = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Worker
            // 
            this.Worker.WorkerReportsProgress = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(656, 669);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(736, 669);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SMTP:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtXAnchorMailbox);
            this.panel4.Controls.Add(this.chkSetXAnchorMailbox);
            this.panel4.Location = new System.Drawing.Point(514, 99);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 82);
            this.panel4.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(3, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "and when accessing a public folder.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(3, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Normaly set to the target mailbox when using Impersonation";
            // 
            // txtXAnchorMailbox
            // 
            this.txtXAnchorMailbox.Enabled = false;
            this.txtXAnchorMailbox.Location = new System.Drawing.Point(68, 26);
            this.txtXAnchorMailbox.Margin = new System.Windows.Forms.Padding(0);
            this.txtXAnchorMailbox.Name = "txtXAnchorMailbox";
            this.txtXAnchorMailbox.Size = new System.Drawing.Size(208, 20);
            this.txtXAnchorMailbox.TabIndex = 7;
            // 
            // chkSetXAnchorMailbox
            // 
            this.chkSetXAnchorMailbox.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkSetXAnchorMailbox.Location = new System.Drawing.Point(3, 4);
            this.chkSetXAnchorMailbox.Margin = new System.Windows.Forms.Padding(0);
            this.chkSetXAnchorMailbox.Name = "chkSetXAnchorMailbox";
            this.chkSetXAnchorMailbox.Size = new System.Drawing.Size(272, 22);
            this.chkSetXAnchorMailbox.TabIndex = 5;
            this.chkSetXAnchorMailbox.Text = "Set X-AnchorMailox header.";
            this.chkSetXAnchorMailbox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkSetXAnchorMailbox.UseVisualStyleBackColor = true;
            this.chkSetXAnchorMailbox.CheckedChanged += new System.EventHandler(this.chkSetXAnchorMailbox_CheckedChanged);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(511, 265);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(101, 23);
            this.btnOptions.TabIndex = 0;
            this.btnOptions.Text = "Global Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.TempConnectingIdCombo);
            this.panel3.Controls.Add(this.lblImpIdType);
            this.panel3.Controls.Add(this.ImpersonationCheck);
            this.panel3.Controls.Add(this.lblImpId);
            this.panel3.Controls.Add(this.ImpersonatedIdTextBox);
            this.panel3.Location = new System.Drawing.Point(514, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 86);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(3, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Set to mailbox being accessed using EWS Impersonation.";
            // 
            // TempConnectingIdCombo
            // 
            this.TempConnectingIdCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TempConnectingIdCombo.Enabled = false;
            this.TempConnectingIdCombo.FormattingEnabled = true;
            this.TempConnectingIdCombo.ItemHeight = 13;
            this.TempConnectingIdCombo.Location = new System.Drawing.Point(75, 21);
            this.TempConnectingIdCombo.Name = "TempConnectingIdCombo";
            this.TempConnectingIdCombo.Size = new System.Drawing.Size(103, 21);
            this.TempConnectingIdCombo.TabIndex = 2;
            // 
            // lblImpIdType
            // 
            this.lblImpIdType.AutoSize = true;
            this.lblImpIdType.Enabled = false;
            this.lblImpIdType.Location = new System.Drawing.Point(24, 24);
            this.lblImpIdType.Name = "lblImpIdType";
            this.lblImpIdType.Size = new System.Drawing.Size(46, 13);
            this.lblImpIdType.TabIndex = 1;
            this.lblImpIdType.Text = "Id Type:";
            // 
            // ImpersonationCheck
            // 
            this.ImpersonationCheck.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ImpersonationCheck.Location = new System.Drawing.Point(9, 3);
            this.ImpersonationCheck.Name = "ImpersonationCheck";
            this.ImpersonationCheck.Size = new System.Drawing.Size(220, 18);
            this.ImpersonationCheck.TabIndex = 0;
            this.ImpersonationCheck.Text = "Check if using EWS Impersonation.  ";
            this.ImpersonationCheck.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ImpersonationCheck.UseVisualStyleBackColor = true;
            this.ImpersonationCheck.CheckedChanged += new System.EventHandler(this.ChkImpersonation_CheckedChanged);
            // 
            // lblImpId
            // 
            this.lblImpId.AutoSize = true;
            this.lblImpId.Enabled = false;
            this.lblImpId.Location = new System.Drawing.Point(24, 47);
            this.lblImpId.Name = "lblImpId";
            this.lblImpId.Size = new System.Drawing.Size(19, 13);
            this.lblImpId.TabIndex = 3;
            this.lblImpId.Text = "Id:";
            this.lblImpId.Click += new System.EventHandler(this.lblImpId_Click);
            // 
            // ImpersonatedIdTextBox
            // 
            this.ImpersonatedIdTextBox.Enabled = false;
            this.ImpersonatedIdTextBox.Location = new System.Drawing.Point(58, 44);
            this.ImpersonatedIdTextBox.Name = "ImpersonatedIdTextBox";
            this.ImpersonatedIdTextBox.Size = new System.Drawing.Size(224, 20);
            this.ImpersonatedIdTextBox.TabIndex = 4;
            this.ImpersonatedIdTextBox.TextChanged += new System.EventHandler(this.ImpersonatedIdTextBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtScope);
            this.panel2.Controls.Add(this.lblScope);
            this.panel2.Controls.Add(this.txtAuthority);
            this.panel2.Controls.Add(this.lblAppSecretAuthority);
            this.panel2.Controls.Add(this.txtTenantID);
            this.panel2.Controls.Add(this.lblTenantID);
            this.panel2.Controls.Add(this.txtAppID);
            this.panel2.Controls.Add(this.lblAppSecret);
            this.panel2.Controls.Add(this.lblAppID);
            this.panel2.Controls.Add(this.txtAppSecret);
            this.panel2.Controls.Add(this.rdoAppSecretOauth);
            this.panel2.Controls.Add(this.btnDefaultUserNameSmtp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtOAuthAuthority);
            this.panel2.Controls.Add(this.lblOAuthAuthority);
            this.panel2.Controls.Add(this.txtOAuthServerName);
            this.panel2.Controls.Add(this.lblOAuthServerName);
            this.panel2.Controls.Add(this.txtOAuthAppId);
            this.panel2.Controls.Add(this.lblOAuthRedirectUri);
            this.panel2.Controls.Add(this.lblOAuthAppId);
            this.panel2.Controls.Add(this.txtOAuthRedirectUri);
            this.panel2.Controls.Add(this.rdoCredentialsDefaultWindows);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rdoCredentialsOAuth);
            this.panel2.Controls.Add(this.rdoCredentialsUserSpecified);
            this.panel2.Controls.Add(this.txtDomain);
            this.panel2.Controls.Add(this.lblExImp);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.lblDomain);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Location = new System.Drawing.Point(8, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 478);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnDefaultUserNameSmtp
            // 
            this.btnDefaultUserNameSmtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultUserNameSmtp.Location = new System.Drawing.Point(389, 38);
            this.btnDefaultUserNameSmtp.Name = "btnDefaultUserNameSmtp";
            this.btnDefaultUserNameSmtp.Size = new System.Drawing.Size(70, 23);
            this.btnDefaultUserNameSmtp.TabIndex = 4;
            this.btnDefaultUserNameSmtp.Text = "Default";
            this.btnDefaultUserNameSmtp.UseVisualStyleBackColor = true;
            this.btnDefaultUserNameSmtp.Click += new System.EventHandler(this.btnDefaultUserNameSmtp_Click);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(23, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Suggestion: Use UPN/SMTP address and no domain for Outlook 365.";
            // 
            // txtOAuthAuthority
            // 
            this.txtOAuthAuthority.Enabled = false;
            this.txtOAuthAuthority.Location = new System.Drawing.Point(104, 226);
            this.txtOAuthAuthority.Margin = new System.Windows.Forms.Padding(0);
            this.txtOAuthAuthority.Name = "txtOAuthAuthority";
            this.txtOAuthAuthority.Size = new System.Drawing.Size(367, 20);
            this.txtOAuthAuthority.TabIndex = 20;
            this.txtOAuthAuthority.Text = "https://login.windows.net/common";
            // 
            // lblOAuthAuthority
            // 
            this.lblOAuthAuthority.AutoSize = true;
            this.lblOAuthAuthority.Enabled = false;
            this.lblOAuthAuthority.Location = new System.Drawing.Point(23, 226);
            this.lblOAuthAuthority.Margin = new System.Windows.Forms.Padding(0);
            this.lblOAuthAuthority.Name = "lblOAuthAuthority";
            this.lblOAuthAuthority.Size = new System.Drawing.Size(76, 13);
            this.lblOAuthAuthority.TabIndex = 19;
            this.lblOAuthAuthority.Text = "Auth Authority:";
            // 
            // txtOAuthServerName
            // 
            this.txtOAuthServerName.Enabled = false;
            this.txtOAuthServerName.Location = new System.Drawing.Point(104, 206);
            this.txtOAuthServerName.Margin = new System.Windows.Forms.Padding(0);
            this.txtOAuthServerName.Name = "txtOAuthServerName";
            this.txtOAuthServerName.Size = new System.Drawing.Size(367, 20);
            this.txtOAuthServerName.TabIndex = 18;
            this.txtOAuthServerName.Text = "https://outlook.office365.com";
            // 
            // lblOAuthServerName
            // 
            this.lblOAuthServerName.AutoSize = true;
            this.lblOAuthServerName.Enabled = false;
            this.lblOAuthServerName.Location = new System.Drawing.Point(24, 210);
            this.lblOAuthServerName.Margin = new System.Windows.Forms.Padding(0);
            this.lblOAuthServerName.Name = "lblOAuthServerName";
            this.lblOAuthServerName.Size = new System.Drawing.Size(72, 13);
            this.lblOAuthServerName.TabIndex = 17;
            this.lblOAuthServerName.Text = "Server Name:";
            // 
            // txtOAuthAppId
            // 
            this.txtOAuthAppId.Enabled = false;
            this.txtOAuthAppId.Location = new System.Drawing.Point(104, 184);
            this.txtOAuthAppId.Margin = new System.Windows.Forms.Padding(0);
            this.txtOAuthAppId.Name = "txtOAuthAppId";
            this.txtOAuthAppId.Size = new System.Drawing.Size(367, 20);
            this.txtOAuthAppId.TabIndex = 16;
            this.txtOAuthAppId.Text = "0e4bf2e2-aa7d-46e8-aa12-263adeb3a62b";
            // 
            // lblOAuthRedirectUri
            // 
            this.lblOAuthRedirectUri.AutoSize = true;
            this.lblOAuthRedirectUri.Enabled = false;
            this.lblOAuthRedirectUri.Location = new System.Drawing.Point(24, 164);
            this.lblOAuthRedirectUri.Margin = new System.Windows.Forms.Padding(0);
            this.lblOAuthRedirectUri.Name = "lblOAuthRedirectUri";
            this.lblOAuthRedirectUri.Size = new System.Drawing.Size(72, 13);
            this.lblOAuthRedirectUri.TabIndex = 13;
            this.lblOAuthRedirectUri.Text = "Redirect URI:";
            // 
            // lblOAuthAppId
            // 
            this.lblOAuthAppId.AutoSize = true;
            this.lblOAuthAppId.Enabled = false;
            this.lblOAuthAppId.Location = new System.Drawing.Point(24, 185);
            this.lblOAuthAppId.Margin = new System.Windows.Forms.Padding(0);
            this.lblOAuthAppId.Name = "lblOAuthAppId";
            this.lblOAuthAppId.Size = new System.Drawing.Size(72, 13);
            this.lblOAuthAppId.TabIndex = 15;
            this.lblOAuthAppId.Text = "Client App ID:";
            // 
            // txtOAuthRedirectUri
            // 
            this.txtOAuthRedirectUri.Enabled = false;
            this.txtOAuthRedirectUri.Location = new System.Drawing.Point(104, 162);
            this.txtOAuthRedirectUri.Margin = new System.Windows.Forms.Padding(0);
            this.txtOAuthRedirectUri.Name = "txtOAuthRedirectUri";
            this.txtOAuthRedirectUri.Size = new System.Drawing.Size(367, 20);
            this.txtOAuthRedirectUri.TabIndex = 14;
            this.txtOAuthRedirectUri.Text = "https://microsoft.com/EwsEditor";
            this.txtOAuthRedirectUri.TextChanged += new System.EventHandler(this.txtOAuthRedirectUri_TextChanged);
            // 
            // rdoCredentialsDefaultWindows
            // 
            this.rdoCredentialsDefaultWindows.AutoSize = true;
            this.rdoCredentialsDefaultWindows.Checked = true;
            this.rdoCredentialsDefaultWindows.Location = new System.Drawing.Point(6, 3);
            this.rdoCredentialsDefaultWindows.Margin = new System.Windows.Forms.Padding(0);
            this.rdoCredentialsDefaultWindows.Name = "rdoCredentialsDefaultWindows";
            this.rdoCredentialsDefaultWindows.Size = new System.Drawing.Size(136, 17);
            this.rdoCredentialsDefaultWindows.TabIndex = 0;
            this.rdoCredentialsDefaultWindows.TabStop = true;
            this.rdoCredentialsDefaultWindows.Text = "Use Default Credentails";
            this.rdoCredentialsDefaultWindows.UseVisualStyleBackColor = true;
            this.rdoCredentialsDefaultWindows.CheckedChanged += new System.EventHandler(this.rdoCredentialsDefaultWindows_CheckedChanged);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(23, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(446, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Use credentials of mailbox being accessed or the those of the EWS Impersonation a" +
    "ccount.";
            // 
            // rdoCredentialsOAuth
            // 
            this.rdoCredentialsOAuth.AutoSize = true;
            this.rdoCredentialsOAuth.Location = new System.Drawing.Point(5, 144);
            this.rdoCredentialsOAuth.Name = "rdoCredentialsOAuth";
            this.rdoCredentialsOAuth.Size = new System.Drawing.Size(290, 17);
            this.rdoCredentialsOAuth.TabIndex = 12;
            this.rdoCredentialsOAuth.Text = "Use oAuth (Registration must have been completed first)";
            this.rdoCredentialsOAuth.UseVisualStyleBackColor = true;
            this.rdoCredentialsOAuth.CheckedChanged += new System.EventHandler(this.rdoCredentialsOAuth_CheckedChanged);
            // 
            // rdoCredentialsUserSpecified
            // 
            this.rdoCredentialsUserSpecified.AutoSize = true;
            this.rdoCredentialsUserSpecified.Location = new System.Drawing.Point(6, 21);
            this.rdoCredentialsUserSpecified.Margin = new System.Windows.Forms.Padding(0);
            this.rdoCredentialsUserSpecified.Name = "rdoCredentialsUserSpecified";
            this.rdoCredentialsUserSpecified.Size = new System.Drawing.Size(366, 17);
            this.rdoCredentialsUserSpecified.TabIndex = 1;
            this.rdoCredentialsUserSpecified.Text = "Use the following credentials instead of the default Windows credentials.";
            this.rdoCredentialsUserSpecified.UseVisualStyleBackColor = true;
            this.rdoCredentialsUserSpecified.CheckedChanged += new System.EventHandler(this.rdoCredentialsUserSpecified_CheckedChanged);
            // 
            // txtDomain
            // 
            this.txtDomain.Enabled = false;
            this.txtDomain.Location = new System.Drawing.Point(93, 84);
            this.txtDomain.Margin = new System.Windows.Forms.Padding(0);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(286, 20);
            this.txtDomain.TabIndex = 9;
            // 
            // lblExImp
            // 
            this.lblExImp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblExImp.AutoSize = true;
            this.lblExImp.Location = new System.Drawing.Point(22, 300);
            this.lblExImp.Margin = new System.Windows.Forms.Padding(0);
            this.lblExImp.Name = "lblExImp";
            this.lblExImp.Size = new System.Drawing.Size(0, 13);
            this.lblExImp.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Enabled = false;
            this.lblPassword.Location = new System.Drawing.Point(23, 63);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Enabled = false;
            this.lblDomain.Location = new System.Drawing.Point(23, 84);
            this.lblDomain.Margin = new System.Windows.Forms.Padding(0);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(46, 13);
            this.lblDomain.TabIndex = 8;
            this.lblDomain.Text = "Domain:";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(93, 63);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '�';
            this.txtPassword.Size = new System.Drawing.Size(286, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(93, 43);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(286, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Enabled = false;
            this.lblUserName.Location = new System.Drawing.Point(23, 43);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnDefaultSmtp);
            this.panel1.Controls.Add(this.btnDefault365Settings);
            this.panel1.Controls.Add(this.rdoServiceUrl);
            this.panel1.Controls.Add(this.rdoAutodiscoverEmail);
            this.panel1.Controls.Add(this.lblUseAutodiscoverCheck);
            this.panel1.Controls.Add(this.lblExchangeServiceURLTextDesc);
            this.panel1.Controls.Add(this.lblAutodiscoverEmailDesc);
            this.panel1.Controls.Add(this.ExchangeServiceURLText);
            this.panel1.Controls.Add(this.AutodiscoverEmailText);
            this.panel1.Location = new System.Drawing.Point(8, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 121);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(3, 90);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(488, 27);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Note: For Autodiscover against out of network servers such as Exchange Online, yo" +
    "u should set disable SCP Autodiscover so that only POX will be used.  You can do" +
    " this from the Global Options window.";
            // 
            // btnDefaultSmtp
            // 
            this.btnDefaultSmtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultSmtp.Location = new System.Drawing.Point(423, 12);
            this.btnDefaultSmtp.Name = "btnDefaultSmtp";
            this.btnDefaultSmtp.Size = new System.Drawing.Size(70, 23);
            this.btnDefaultSmtp.TabIndex = 3;
            this.btnDefaultSmtp.Text = "Default";
            this.btnDefaultSmtp.UseVisualStyleBackColor = true;
            this.btnDefaultSmtp.Click += new System.EventHandler(this.btnDefaultSmtp_Click);
            // 
            // btnDefault365Settings
            // 
            this.btnDefault365Settings.Location = new System.Drawing.Point(421, 52);
            this.btnDefault365Settings.Name = "btnDefault365Settings";
            this.btnDefault365Settings.Size = new System.Drawing.Size(70, 23);
            this.btnDefault365Settings.TabIndex = 8;
            this.btnDefault365Settings.Text = "365 Default";
            this.btnDefault365Settings.UseVisualStyleBackColor = true;
            this.btnDefault365Settings.Click += new System.EventHandler(this.btnDefault365Settings_Click);
            // 
            // rdoServiceUrl
            // 
            this.rdoServiceUrl.AutoSize = true;
            this.rdoServiceUrl.Location = new System.Drawing.Point(22, 52);
            this.rdoServiceUrl.Name = "rdoServiceUrl";
            this.rdoServiceUrl.Size = new System.Drawing.Size(89, 17);
            this.rdoServiceUrl.TabIndex = 5;
            this.rdoServiceUrl.TabStop = true;
            this.rdoServiceUrl.Text = "Service URL:";
            this.rdoServiceUrl.UseVisualStyleBackColor = true;
            this.rdoServiceUrl.CheckedChanged += new System.EventHandler(this.rdoServiceUrl_CheckedChanged);
            // 
            // rdoAutodiscoverEmail
            // 
            this.rdoAutodiscoverEmail.AutoSize = true;
            this.rdoAutodiscoverEmail.Checked = true;
            this.rdoAutodiscoverEmail.Location = new System.Drawing.Point(22, 16);
            this.rdoAutodiscoverEmail.Name = "rdoAutodiscoverEmail";
            this.rdoAutodiscoverEmail.Size = new System.Drawing.Size(118, 17);
            this.rdoAutodiscoverEmail.TabIndex = 1;
            this.rdoAutodiscoverEmail.TabStop = true;
            this.rdoAutodiscoverEmail.Text = "Autodiscover Email:";
            this.rdoAutodiscoverEmail.UseVisualStyleBackColor = true;
            this.rdoAutodiscoverEmail.CheckedChanged += new System.EventHandler(this.rdoAutodiscoverEmail_CheckedChanged);
            // 
            // lblUseAutodiscoverCheck
            // 
            this.lblUseAutodiscoverCheck.AutoSize = true;
            this.lblUseAutodiscoverCheck.Location = new System.Drawing.Point(2, 0);
            this.lblUseAutodiscoverCheck.Name = "lblUseAutodiscoverCheck";
            this.lblUseAutodiscoverCheck.Size = new System.Drawing.Size(303, 13);
            this.lblUseAutodiscoverCheck.TabIndex = 0;
            this.lblUseAutodiscoverCheck.Text = "Use Autodiscover or use Exchange Web Service URL directly:";
            // 
            // lblExchangeServiceURLTextDesc
            // 
            this.lblExchangeServiceURLTextDesc.AutoSize = true;
            this.lblExchangeServiceURLTextDesc.Enabled = false;
            this.lblExchangeServiceURLTextDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblExchangeServiceURLTextDesc.Location = new System.Drawing.Point(146, 71);
            this.lblExchangeServiceURLTextDesc.Margin = new System.Windows.Forms.Padding(0);
            this.lblExchangeServiceURLTextDesc.Name = "lblExchangeServiceURLTextDesc";
            this.lblExchangeServiceURLTextDesc.Size = new System.Drawing.Size(281, 13);
            this.lblExchangeServiceURLTextDesc.TabIndex = 7;
            this.lblExchangeServiceURLTextDesc.Text = "Example: https://mail.contoso.com/EWS/Exchange.asmx";
            // 
            // lblAutodiscoverEmailDesc
            // 
            this.lblAutodiscoverEmailDesc.Enabled = false;
            this.lblAutodiscoverEmailDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAutodiscoverEmailDesc.Location = new System.Drawing.Point(142, 34);
            this.lblAutodiscoverEmailDesc.Margin = new System.Windows.Forms.Padding(0);
            this.lblAutodiscoverEmailDesc.Name = "lblAutodiscoverEmailDesc";
            this.lblAutodiscoverEmailDesc.Size = new System.Drawing.Size(276, 15);
            this.lblAutodiscoverEmailDesc.TabIndex = 4;
            this.lblAutodiscoverEmailDesc.Text = "Target mailbox.  Example: myuser@contoso.com";
            // 
            // ExchangeServiceURLText
            // 
            this.ExchangeServiceURLText.Location = new System.Drawing.Point(144, 52);
            this.ExchangeServiceURLText.Name = "ExchangeServiceURLText";
            this.ExchangeServiceURLText.Size = new System.Drawing.Size(275, 20);
            this.ExchangeServiceURLText.TabIndex = 6;
            // 
            // AutodiscoverEmailText
            // 
            this.AutodiscoverEmailText.Location = new System.Drawing.Point(144, 15);
            this.AutodiscoverEmailText.Name = "AutodiscoverEmailText";
            this.AutodiscoverEmailText.Size = new System.Drawing.Size(275, 20);
            this.AutodiscoverEmailText.TabIndex = 2;
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(4, 3);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(117, 18);
            this.lblVersion.TabIndex = 9;
            this.lblVersion.Text = "EWS Schema Version:";
            // 
            // TempExchangeVersionCombo
            // 
            this.TempExchangeVersionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TempExchangeVersionCombo.FormattingEnabled = true;
            this.TempExchangeVersionCombo.Location = new System.Drawing.Point(127, 2);
            this.TempExchangeVersionCombo.Name = "TempExchangeVersionCombo";
            this.TempExchangeVersionCombo.Size = new System.Drawing.Size(290, 21);
            this.TempExchangeVersionCombo.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lblVersion);
            this.panel5.Controls.Add(this.TempExchangeVersionCombo);
            this.panel5.Location = new System.Drawing.Point(8, 127);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(498, 41);
            this.panel5.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(4, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(462, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Set the version of the EWS Schema to use.  This is not the same thing as the Exch" +
    "ange version.";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.txtXPublicFolderMailbox);
            this.panel6.Controls.Add(this.chkSetXPublicFolderMailbox);
            this.panel6.Location = new System.Drawing.Point(513, 185);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(298, 68);
            this.panel6.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(3, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Set when accessing a public folder.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(24, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "SMTP:";
            // 
            // txtXPublicFolderMailbox
            // 
            this.txtXPublicFolderMailbox.Enabled = false;
            this.txtXPublicFolderMailbox.Location = new System.Drawing.Point(68, 26);
            this.txtXPublicFolderMailbox.Margin = new System.Windows.Forms.Padding(0);
            this.txtXPublicFolderMailbox.Name = "txtXPublicFolderMailbox";
            this.txtXPublicFolderMailbox.Size = new System.Drawing.Size(208, 20);
            this.txtXPublicFolderMailbox.TabIndex = 7;
            // 
            // chkSetXPublicFolderMailbox
            // 
            this.chkSetXPublicFolderMailbox.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkSetXPublicFolderMailbox.Location = new System.Drawing.Point(3, 4);
            this.chkSetXPublicFolderMailbox.Margin = new System.Windows.Forms.Padding(0);
            this.chkSetXPublicFolderMailbox.Name = "chkSetXPublicFolderMailbox";
            this.chkSetXPublicFolderMailbox.Size = new System.Drawing.Size(272, 22);
            this.chkSetXPublicFolderMailbox.TabIndex = 5;
            this.chkSetXPublicFolderMailbox.Text = "Set X-PublicFolderMailbox header.";
            this.chkSetXPublicFolderMailbox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkSetXPublicFolderMailbox.UseVisualStyleBackColor = true;
            this.chkSetXPublicFolderMailbox.CheckedChanged += new System.EventHandler(this.chkSetXPublicFolderMailbox_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(511, 297);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(285, 42);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "Note: For delegate access: Log in as the delegate then the tree menu select \"Add " +
    "Root Folder...\".  Use one of the options to add the folder of the mailbox to the" +
    " folder tree.";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.Red;
            this.textBox3.Location = new System.Drawing.Point(510, 352);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(285, 42);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "Note: It\'s best to set the X-AnchorMailbox header for Impersonation - it resolves" +
    " a lot of issue.  It also can help with delegate access..";
            // 
            // txtAuthority
            // 
            this.txtAuthority.Enabled = false;
            this.txtAuthority.Location = new System.Drawing.Point(104, 346);
            this.txtAuthority.Margin = new System.Windows.Forms.Padding(0);
            this.txtAuthority.Name = "txtAuthority";
            this.txtAuthority.Size = new System.Drawing.Size(367, 20);
            this.txtAuthority.TabIndex = 29;
            this.txtAuthority.Text = "https://login.microsoftonline.com/";
            // 
            // lblAppSecretAuthority
            // 
            this.lblAppSecretAuthority.AutoSize = true;
            this.lblAppSecretAuthority.Enabled = false;
            this.lblAppSecretAuthority.Location = new System.Drawing.Point(23, 346);
            this.lblAppSecretAuthority.Margin = new System.Windows.Forms.Padding(0);
            this.lblAppSecretAuthority.Name = "lblAppSecretAuthority";
            this.lblAppSecretAuthority.Size = new System.Drawing.Size(76, 13);
            this.lblAppSecretAuthority.TabIndex = 28;
            this.lblAppSecretAuthority.Text = "Auth Authority:";
            // 
            // lblTenantID
            // 
            this.lblTenantID.AutoSize = true;
            this.lblTenantID.Enabled = false;
            this.lblTenantID.Location = new System.Drawing.Point(24, 330);
            this.lblTenantID.Margin = new System.Windows.Forms.Padding(0);
            this.lblTenantID.Name = "lblTenantID";
            this.lblTenantID.Size = new System.Drawing.Size(58, 13);
            this.lblTenantID.TabIndex = 26;
            this.lblTenantID.Text = "Tenant ID:";
            // 
            // txtAppID
            // 
            this.txtAppID.Enabled = false;
            this.txtAppID.Location = new System.Drawing.Point(104, 282);
            this.txtAppID.Margin = new System.Windows.Forms.Padding(0);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.Size = new System.Drawing.Size(367, 20);
            this.txtAppID.TabIndex = 25;
            // 
            // lblAppSecret
            // 
            this.lblAppSecret.AutoSize = true;
            this.lblAppSecret.Enabled = false;
            this.lblAppSecret.Location = new System.Drawing.Point(24, 306);
            this.lblAppSecret.Margin = new System.Windows.Forms.Padding(0);
            this.lblAppSecret.Name = "lblAppSecret";
            this.lblAppSecret.Size = new System.Drawing.Size(63, 13);
            this.lblAppSecret.TabIndex = 22;
            this.lblAppSecret.Text = "App Secret:";
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Enabled = false;
            this.lblAppID.Location = new System.Drawing.Point(24, 283);
            this.lblAppID.Margin = new System.Windows.Forms.Padding(0);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(72, 13);
            this.lblAppID.TabIndex = 24;
            this.lblAppID.Text = "Client App ID:";
            // 
            // rdoAppSecretOauth
            // 
            this.rdoAppSecretOauth.AutoSize = true;
            this.rdoAppSecretOauth.Location = new System.Drawing.Point(5, 264);
            this.rdoAppSecretOauth.Name = "rdoAppSecretOauth";
            this.rdoAppSecretOauth.Size = new System.Drawing.Size(379, 17);
            this.rdoAppSecretOauth.TabIndex = 21;
            this.rdoAppSecretOauth.Text = "Use oAuth (Using App Secret- Registration must have been completed first)";
            this.rdoAppSecretOauth.UseVisualStyleBackColor = true;
            this.rdoAppSecretOauth.CheckedChanged += new System.EventHandler(this.rdoAppSecretOauth_CheckedChanged);
            // 
            // txtAppSecret
            // 
            this.txtAppSecret.Enabled = false;
            this.txtAppSecret.Location = new System.Drawing.Point(104, 304);
            this.txtAppSecret.Margin = new System.Windows.Forms.Padding(0);
            this.txtAppSecret.Name = "txtAppSecret";
            this.txtAppSecret.Size = new System.Drawing.Size(367, 20);
            this.txtAppSecret.TabIndex = 23;
            // 
            // txtTenantID
            // 
            this.txtTenantID.Enabled = false;
            this.txtTenantID.Location = new System.Drawing.Point(104, 326);
            this.txtTenantID.Margin = new System.Windows.Forms.Padding(0);
            this.txtTenantID.Name = "txtTenantID";
            this.txtTenantID.Size = new System.Drawing.Size(367, 20);
            this.txtTenantID.TabIndex = 27;
            // 
            // txtScope
            // 
            this.txtScope.Enabled = false;
            this.txtScope.Location = new System.Drawing.Point(104, 368);
            this.txtScope.Margin = new System.Windows.Forms.Padding(0);
            this.txtScope.Name = "txtScope";
            this.txtScope.Size = new System.Drawing.Size(367, 20);
            this.txtScope.TabIndex = 31;
            this.txtScope.Text = "https://outlook.office.com/.default";
            // 
            // lblScope
            // 
            this.lblScope.AutoSize = true;
            this.lblScope.Enabled = false;
            this.lblScope.Location = new System.Drawing.Point(23, 368);
            this.lblScope.Margin = new System.Windows.Forms.Padding(0);
            this.lblScope.Name = "lblScope";
            this.lblScope.Size = new System.Drawing.Size(41, 13);
            this.lblScope.TabIndex = 30;
            this.lblScope.Text = "Scope:";
            // 
            // ServiceDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(823, 695);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ServiceDialog";
            this.Text = "EWS Editor - Exchange Service Configuration";
            this.Load += new System.EventHandler(this.ServiceDialog_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblExImp;
        private System.Windows.Forms.ComboBox TempExchangeVersionCombo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblImpId;
        private System.Windows.Forms.CheckBox ImpersonationCheck;
        private System.Windows.Forms.Label lblImpIdType;
        private System.Windows.Forms.ComboBox TempConnectingIdCombo;
        private System.Windows.Forms.TextBox ImpersonatedIdTextBox;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox ExchangeServiceURLText;
        private System.Windows.Forms.TextBox AutodiscoverEmailText;
        private System.ComponentModel.BackgroundWorker Worker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Label lblExchangeServiceURLTextDesc;
        private System.Windows.Forms.Label lblAutodiscoverEmailDesc;
        private System.Windows.Forms.RadioButton rdoServiceUrl;
        private System.Windows.Forms.RadioButton rdoAutodiscoverEmail;
        private System.Windows.Forms.Label lblUseAutodiscoverCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDefault365Settings;
        private System.Windows.Forms.Button btnDefaultSmtp;
        private System.Windows.Forms.CheckBox chkSetXAnchorMailbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXAnchorMailbox;
        private System.Windows.Forms.RadioButton rdoCredentialsUserSpecified;
        private System.Windows.Forms.RadioButton rdoCredentialsOAuth;
        private System.Windows.Forms.RadioButton rdoCredentialsDefaultWindows;
        private System.Windows.Forms.TextBox txtOAuthAppId;
        private System.Windows.Forms.Label lblOAuthRedirectUri;
        private System.Windows.Forms.Label lblOAuthAppId;
        private System.Windows.Forms.TextBox txtOAuthRedirectUri;
        private System.Windows.Forms.TextBox txtOAuthAuthority;
        private System.Windows.Forms.Label lblOAuthAuthority;
        private System.Windows.Forms.TextBox txtOAuthServerName;
        private System.Windows.Forms.Label lblOAuthServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDefaultUserNameSmtp;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtXPublicFolderMailbox;
        private System.Windows.Forms.CheckBox chkSetXPublicFolderMailbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtAuthority;
        private System.Windows.Forms.Label lblAppSecretAuthority;
        private System.Windows.Forms.Label lblTenantID;
        private System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.Label lblAppSecret;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.RadioButton rdoAppSecretOauth;
        private System.Windows.Forms.TextBox txtAppSecret;
        private System.Windows.Forms.TextBox txtTenantID;
        private System.Windows.Forms.TextBox txtScope;
        private System.Windows.Forms.Label lblScope;
    }
}