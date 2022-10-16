using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        void RemoveBG(PictureBox pb, PictureBox pb2)
        {
            var pos = this.PointToScreen(pb2.Location);
            pos = pb.PointToClient(pos);
            pb2.Parent = pb;
            pb2.Location = pos;
            pb2.BackColor = Color.Transparent;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ChangeWhenClose(Button btn)
        {
            btn.BackColor = Color.Red;
        }

        void ChangeWhenLeave(Button btn)
        {
            btn.BackColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            ChangeWhenClose(btnClose);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            ChangeWhenLeave(btnClose);
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtUserName.Text = "";
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                txtUserName.Text = "Enter Your Username";
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Text = "";
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Text = "Enter Your Password";
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
