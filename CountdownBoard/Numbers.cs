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
    public partial class Numbers : Form
    {
        int[] LargeNumbers;
        int[] SmallNumbers;
        public Numbers()
        {
            InitializeComponent();
        }
        private void btn_target_Click(object sender, EventArgs e)
        {
            targetBox.Text = string.Empty;
            int target = calculations.RNG();
            targetBox.Text = target.ToString();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lg_Click(object sender, EventArgs e)
        {
            //int[] numbersArray = largeNum.GenerateLargeNumbersArray();
            //MessageBox.Show("Large Numbers: " + string.Join(", ", numbersArray));
            //MessageBox.Show("Large Numbers: " + string.Join(", ", LargeNumbers));
            int index = calculations.ChooseFromArray(LargeNumbers);
            int choice = LargeNumbers[index];
            List<int> tempList = new List<int>(LargeNumbers);
            tempList.RemoveAt(index);
            LargeNumbers = tempList.ToArray();
            CheckPictureBoxes(choice);
            if (LargeNumbers.Length == 0)
            {
                btn_lg.Enabled = false;
            }

        }

        private void btn_sm_Click(object sender, EventArgs e)
        {
            //int[] numbersArray = smallNum.GenerateSmallNumbersArray();
            //MessageBox.Show("Small Numbers: " + string.Join(", ", numbersArray));
            //MessageBox.Show("Small Numbers: " + string.Join(", ", SmallNumbers));
            int index = calculations.ChooseFromArray(SmallNumbers);
            int choice = SmallNumbers[index];
            List<int> tempList = new List<int>(SmallNumbers);
            tempList.RemoveAt(index);
            SmallNumbers = tempList.ToArray();
            CheckPictureBoxes(choice);
        }

        public void OnLoad(object sender, EventArgs e)
        {
            btn_target.Enabled = false;
            LargeNumbers = largeNum.GenerateLargeNumbersArray();
            SmallNumbers = smallNum.GenerateSmallNumbersArray();
        }

        public void CheckPictureBoxes(int choice)
        {
            string file = choice.ToString();
            Bitmap image = (Bitmap)Properties.Resources.ResourceManager.GetObject(file);
            if (pb1.Image == null)
            {
                pb1.Image = image;
            }
            else if (pb2.Image == null)
            {
                pb2.Image = image;
            }
            else if (pb3.Image == null)
            {
                pb3.Image = image;
            }
            else if (pb4.Image == null)
            {
                pb4.Image = image;
            }
            else if (pb5.Image == null)
            {
                pb5.Image = image;
            }
            else if (pb6.Image == null)
            {
                pb6.Image = image;
                btn_lg.Enabled = false;
                btn_sm.Enabled = false;
                btn_target.Enabled = true;
            }
            else
            {
                MessageBox.Show("You already have 6 numbers on the board. Please generate a target.");
            }
        }
    }
}
