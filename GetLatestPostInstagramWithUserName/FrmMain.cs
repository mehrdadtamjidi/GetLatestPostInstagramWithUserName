using GetLatestPostInstagramWithUserName.InstagramCore;
using InstagramApiSharp.API;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace GetLatestPostInstagramWithUserName
{
    public partial class FrmMain : Form
    {
        private static IInstaApi InstaApi;
        int CountPost = 0;

        public FrmMain()
        {
            InitializeComponent();
            Load += FrmMain_Load;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default["Username"].ToString()) && !String.IsNullOrEmpty(Properties.Settings.Default["Password"].ToString()))
            {
                txtUserName.Text = Properties.Settings.Default["Username"].ToString();
                txtPassword.Text = Properties.Settings.Default["Password"].ToString();
            }
        }

        private async void bgwGetLinkPost_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            InstaOperation InstaOperation = new InstaOperation();
            string path = Application.StartupPath + $"\\File\\Post\\{DateTime.Now.ToString("yyyyMMddHHmm")}.txt";

            try
            {
                for (int i = 0; i < lbUserAndPostList.Items.Count; i++)
                {
                    if (bgwGetLinkPost.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }

                    else
                    {
                        #region GetLatestPsot
                        string username = lbUserAndPostList.Items[i].ToString();
                        int countPage = 1;
                        if (string.IsNullOrEmpty(txtCountPage.Text))
                        {
                            countPage = 0;
                        }
                        else
                        {
                            countPage = int.Parse(txtCountPage.Text);
                        }
                        var latestPsot = await InstaOperation.GetLatestPsot(InstaApi, username, countPage);

                        lbUserAndPostList.Invoke((MethodInvoker)delegate
                        {
                            foreach (var postLink in latestPsot)
                            {
                                CountPost++;
                                logRtxt.AppendText(lbUserAndPostList.Items[i].ToString() + " : " + postLink);
                                lblPostLog.Text = CountPost.ToString();
                            }
                        });


                        using (StreamWriter file = new StreamWriter(path, true))
                        {
                            foreach (var postLink in latestPsot)
                            {
                                if (!postLink.Contains("Error"))
                                {
                                    file.WriteLine($"{postLink}");
                                }
                            }
                        }
                        #endregion
                    }
                }


                MessageBox.Show("The operation is finshed!!!", "Message");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUserName.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                var InstaLogin = new InstaLogin();
                var InstaOperation = new InstaOperation();

                InstaApi = await InstaLogin.SinginAsync(txtUserName.Text, txtPassword.Text);
                if (InstaApi == null || !InstaApi.IsUserAuthenticated)
                {
                    lblResultLogin.Visible = true;
                    lblResultLogin.ForeColor = Color.Red;
                    lblResultLogin.Text = $"Fail login into Instagram servers...";
                }
                else
                {
                    Properties.Settings.Default["Username"] = txtUserName.Text;
                    Properties.Settings.Default["Password"] = txtPassword.Text;
                    Properties.Settings.Default.Save();

                    lblResultLogin.Visible = true;
                    lblResultLogin.ForeColor = Color.Green;
                    lblResultLogin.Text = $"Connecting & login into Instagram servers...";
                }

            }
            else
            {
                MessageBox.Show("Fill in all the items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnLoadUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All File txt|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //string[] lines = File.ReadAllLines(open.FileName);
                //File.WriteAllLines(open.FileName, lines.Distinct().ToArray());

                StreamReader read = new StreamReader(open.FileName);
                while (read.Peek() > -1)
                {
                    string mobile = read.ReadLine();
                    lbUserAndPostList.Items.Add(mobile);
                }
                read.Close();
                _lblCount.Text = (lbUserAndPostList.Items.Count).ToString();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbUserAndPostList.Items.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (lbUserAndPostList.Items.Count > 0)
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                bgwGetLinkPost.RunWorkerAsync();
            }
            else
                MessageBox.Show("Fill in all the items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (bgwGetLinkPost.WorkerSupportsCancellation == true)
            {
                bgwGetLinkPost.CancelAsync();
            }

            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}
