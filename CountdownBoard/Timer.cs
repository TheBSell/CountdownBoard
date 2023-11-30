using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace CountdownBoard
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string file = "C:\\Users\\bryan\\Documents\\GitHub\\CountdownBoard\\CountdownBoard\\Resources\\Clock.mp4";
            axWindowsMediaPlayer1.URL = file;
        }
    }
}
