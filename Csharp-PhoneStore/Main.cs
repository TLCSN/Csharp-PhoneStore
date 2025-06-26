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

namespace Csharp_PhoneStore
{
    public partial class Main : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);
      
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            TxtSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TxtSearch.Width, TxtSearch.Height, 10, 10));
            BtnIconSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnIconSearch.Width, BtnIconSearch.Height, 10, 10));
            
        }


        private bool isDarkTheme = false;
        private void TbDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            isDarkTheme = !isDarkTheme;

            if (isDarkTheme)
            {
                this.BackColor = Color.DarkGray;
                this.ForeColor = Color.DodgerBlue;
            }
            else
            {
                this.BackColor = Color.DarkCyan;
                this.ForeColor = SystemColors.GrayText;
            }

            // Update child controls' ForeColor too
            foreach (Control ctrl in this.Controls)
            {
                ctrl.ForeColor = this.ForeColor;
                ctrl.BackColor = this.BackColor;
            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
