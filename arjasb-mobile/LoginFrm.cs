using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace arjasb_mobile
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }
        private void LoginFrm_Load(object sender, EventArgs e)
        {
            this.label3.Text = "";

        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("نام کاربر را وارد کنید", "اخطار در فرمت داده ها");
                    txtUserName.Select();
                    txtUserName.SelectAll();
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("پسورد را وارد کنید", "اخطار در فرمت داده ها");
                    txtPassword.Select();
                    txtPassword.SelectAll();
                }
                else
                {
                    SqlConnection con = new SqlConnection(Properties.Settings.Default.arjasb_mobile_DBConnectionString);
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    SqlDataReader dreader;
                    com.CommandType = CommandType.Text;
                    com.CommandText = "SELECT * FROM authenticatetbl  where users=@users and password=@password";
                    com.Parameters.AddWithValue("@users", txtUserName.Text);
                    com.Parameters.AddWithValue("@password", txtPassword.Text);
                    con.Open();
                    dreader = com.ExecuteReader();
                    if (dreader.Read())
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                        this.DialogResult = System.Windows.Forms.DialogResult.Abort;
                    con.Close();
                    this.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("داده ها را در فرمت صحیح وارد کنید", "اخطار در فرمت داده ها");
                txtUserName.Select();
                txtUserName.SelectAll();
            }
            //if (txtUserName.Text == "admin" && txtPassword.Text == "123")
            //{
            //    var MainFrmObj = new MainFrm();
            //    MainFrmObj.ShowDialog();
            //}
            //else
            //    this.label3.Text = "نام کاربری یا پسوورد اشتباه است";
        }







        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            this.label3.Text = "";
        }

      
      
       
    }
}
