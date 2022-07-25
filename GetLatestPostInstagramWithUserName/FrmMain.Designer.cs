namespace GetLatestPostInstagramWithUserName
{
    partial class FrmMain
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
            this.bgwGetLinkPost = new System.ComponentModel.BackgroundWorker();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPostLog = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.logRtxt = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this._lblCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadUser = new System.Windows.Forms.Button();
            this.lbUserAndPostList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResultLogin = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountPage = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgwGetLinkPost
            // 
            this.bgwGetLinkPost.WorkerReportsProgress = true;
            this.bgwGetLinkPost.WorkerSupportsCancellation = true;
            this.bgwGetLinkPost.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGetLinkPost_DoWork);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(283, 544);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(73, 36);
            this.btnStop.TabIndex = 27;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(204, 544);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(73, 36);
            this.btnStart.TabIndex = 26;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPostLog);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.logRtxt);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this._lblCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLoadUser);
            this.panel1.Controls.Add(this.lbUserAndPostList);
            this.panel1.Location = new System.Drawing.Point(16, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 431);
            this.panel1.TabIndex = 25;
            // 
            // lblPostLog
            // 
            this.lblPostLog.AutoSize = true;
            this.lblPostLog.Location = new System.Drawing.Point(478, 395);
            this.lblPostLog.Name = "lblPostLog";
            this.lblPostLog.Size = new System.Drawing.Size(0, 13);
            this.lblPostLog.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Count :";
            // 
            // logRtxt
            // 
            this.logRtxt.Location = new System.Drawing.Point(234, 16);
            this.logRtxt.Name = "logRtxt";
            this.logRtxt.Size = new System.Drawing.Size(295, 368);
            this.logRtxt.TabIndex = 17;
            this.logRtxt.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(98, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // _lblCount
            // 
            this._lblCount.AutoSize = true;
            this._lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this._lblCount.Location = new System.Drawing.Point(225, 393);
            this._lblCount.Name = "_lblCount";
            this._lblCount.Size = new System.Drawing.Size(0, 13);
            this._lblCount.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Count :";
            // 
            // btnLoadUser
            // 
            this.btnLoadUser.Location = new System.Drawing.Point(17, 390);
            this.btnLoadUser.Name = "btnLoadUser";
            this.btnLoadUser.Size = new System.Drawing.Size(75, 23);
            this.btnLoadUser.TabIndex = 13;
            this.btnLoadUser.Text = "Load";
            this.btnLoadUser.UseVisualStyleBackColor = true;
            this.btnLoadUser.Click += new System.EventHandler(this.btnLoadUser_Click);
            // 
            // lbUserAndPostList
            // 
            this.lbUserAndPostList.FormattingEnabled = true;
            this.lbUserAndPostList.Location = new System.Drawing.Point(14, 16);
            this.lbUserAndPostList.Name = "lbUserAndPostList";
            this.lbUserAndPostList.Size = new System.Drawing.Size(214, 368);
            this.lbUserAndPostList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultLogin);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 75);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Account";
            // 
            // lblResultLogin
            // 
            this.lblResultLogin.AutoSize = true;
            this.lblResultLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblResultLogin.Location = new System.Drawing.Point(99, 56);
            this.lblResultLogin.Name = "lblResultLogin";
            this.lblResultLogin.Size = new System.Drawing.Size(0, 24);
            this.lblResultLogin.TabIndex = 17;
            this.lblResultLogin.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(319, 23);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(135, 20);
            this.txtPassword.TabIndex = 16;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(459, 23);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(74, 21);
            this.buttonLogin.TabIndex = 14;
            this.buttonLogin.Text = "Connect";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(2);
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(99, 23);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(141, 20);
            this.txtUserName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "User Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Count page : ";
            // 
            // txtCountPage
            // 
            this.txtCountPage.Location = new System.Drawing.Point(98, 554);
            this.txtCountPage.Name = "txtCountPage";
            this.txtCountPage.Size = new System.Drawing.Size(100, 20);
            this.txtCountPage.TabIndex = 29;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 588);
            this.Controls.Add(this.txtCountPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Latest Post Instagram With UserName - M@T";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bgwGetLinkPost;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label _lblCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadUser;
        private System.Windows.Forms.ListBox lbUserAndPostList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResultLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountPage;
        private System.Windows.Forms.RichTextBox logRtxt;
        private System.Windows.Forms.Label lblPostLog;
        private System.Windows.Forms.Label label5;
    }
}

