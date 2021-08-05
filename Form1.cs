using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringToStRIngG
{
    public partial class String_Form : Form
    {
        public String_Form()
        {
            InitializeComponent();
        }

        private void buttonEntryHeader_Click(object sender, EventArgs e)
        {

        }

        private void buttonAppExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOriginal_TextChanged(object sender, EventArgs e)
        {
            string textOriginal = textBoxOriginal.Text;
            List<String> textChanging = new List<String>();
            string temp;
            for(int i = 0; i < textOriginal.Length; i++)
            {
                //Upper
                if(i % 2 == 0)
                {
                    string textCopy = textOriginal.ToUpper();
                    temp = Convert.ToString(textCopy[i]);
                    textChanging.Add(temp);
                }
                //Lower
                else
                {
                    string textCopy = textOriginal.ToLower();
                    temp = Convert.ToString(textCopy[i]);
                    textChanging.Add(temp);
                }
            }
            StringBuilder displayText = new StringBuilder();
            for(int i = 0; i < textChanging.Count; i++)
            {
                displayText.Append(textChanging[i]);
            }
            textBoxRetarded.Text = displayText.ToString();
        }
    }
}
