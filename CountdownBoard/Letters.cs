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
    public partial class Letters : Form
    {
        char[] consonantsArray;
        char[] vowelsArray;
        public Letters()
        {
            InitializeComponent();
        }

        private void btn_vowel_Click(object sender, EventArgs e)
        {
            int index = calculations.ChooseFromArray(vowelsArray);
            char choice = vowelsArray[index];
            List<char> tempList = new List<char>(vowelsArray);
            tempList.RemoveAt(index);
            vowelsArray = tempList.ToArray();
            CheckPictureBoxes(choice);
            if (vowelsArray.Length <= 62)
            {
                btn_vowel.Enabled = false;
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cons_Click(object sender, EventArgs e)
        {
            //char[] consonantsArray = consonant.GenerateConsonantsArray();
            //MessageBox.Show("Consonants Array: " + new string(consonantsArray));
            int index = calculations.ChooseFromArray(consonantsArray);
            char choice = consonantsArray[index];
            List<char> tempList = new List<char>(consonantsArray);
            tempList.RemoveAt(index);
            consonantsArray = tempList.ToArray();
            CheckPictureBoxes(choice);
            if (consonantsArray.Length <= 68)
            {
                btn_cons.Enabled = false;
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            consonantsArray = consonant.GenerateConsonantsArray();
            vowelsArray = vowel.GenerateVowelsArray();
            //MessageBox.Show("Vowels Remaining: " + vowelsArray.Length.ToString() + "\nConsonants Remaining: " + consonantsArray.Length.ToString());
        }

        public void CheckPictureBoxes(char choice)
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
            }
            else if (pb7.Image == null)
            {
                pb7.Image = image;
            }
            else if (pb8.Image == null)
            {
                pb8.Image = image;
            }
            else if (pb9.Image == null)
            {
                pb9.Image = image;
                btn_cons.Enabled = false;
                btn_vowel.Enabled = false;
            }
            else
            {
                MessageBox.Show("You already have 6 numbers on the board. Please generate a target.");
            }
        }
    }
}
