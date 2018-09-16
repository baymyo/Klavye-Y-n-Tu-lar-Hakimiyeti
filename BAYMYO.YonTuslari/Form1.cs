using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAYMYO.YonTuslari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            // Sol yön tuşunu kontrol eden if bloğu
            if (keyData == Keys.Left && button1.Left > 0)
                button1.Location = new Point(button1.Left - 10, button1.Top);
            // Sağ yön tuşunu kontrol eden if bloğu
            else if (keyData == Keys.Right && button1.Right < this.Size.Width)
                button1.Location = new Point(button1.Left + 10, button1.Top);
            // Yukarı yön tuşunu kontrol eden if bloğu
            else if (keyData == Keys.Up && button1.Top > 0)
                button1.Location = new Point(button1.Left, button1.Top - 10);
            // Aşağı yön tuşunu kontrol eden if bloğu
            else if (keyData == Keys.Down && button1.Bottom < this.Size.Height - 50)
                button1.Location = new Point(button1.Left, button1.Top + 10);
            return base.ProcessDialogKey(keyData);
        }

    }
}
