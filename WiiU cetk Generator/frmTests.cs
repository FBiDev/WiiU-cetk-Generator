using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiiU_cetk_Generator
{
    public partial class frmTests : Form
    {
        public frmTests()
        {
            InitializeComponent();

            txtSearchID.GotFocus += new EventHandler(RemoveText);
            txtSearchID.LostFocus += new EventHandler(AddText);

            //comboBox1.SelectedIndexChanged += new EventHandler(RemoveBkg);

            this.Shown += new EventHandler(Show);
        }

        public void Show(object sender, EventArgs e)
        {
        }

        public void RemoveBkg(object sender, EventArgs e)
        {
            lblInvisible.Focus();
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (txtSearchID.Text == "Title ID")
            {
                txtSearchID.Text = "";
                txtSearchID.ForeColor = Color.Black;
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchID.Text))
            {
                txtSearchID.Text = "Title ID";
                txtSearchID.ForeColor = Color.Gray;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlSearch_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
    }
}
