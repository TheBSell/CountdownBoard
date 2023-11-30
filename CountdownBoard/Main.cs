using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountdownBoard
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_letters_Click(object sender, EventArgs e)
        {
            Letters letters = new Letters();
            letters.Show();
        }

        private void btn_numbers_Click(object sender, EventArgs e)
        {
            Numbers numbers = new Numbers();
            numbers.Show();

        }

        private void btn_timer_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Show();
        }

        //private void btn_quit_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
    }
}
