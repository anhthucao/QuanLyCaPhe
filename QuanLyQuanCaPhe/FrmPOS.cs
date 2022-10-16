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
    public partial class FrmPOS : Form
    {
        public FrmPOS()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            ChangeWhenClose(btnClose);
        }

        void ChangeWhenClose(Button btn)
        {
            btn.BackColor = Color.Red;
        }

        void ChangeWhenLeave(Button btn)
        {
            btn.BackColor = Color.White;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            ChangeWhenLeave(btnClose);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
