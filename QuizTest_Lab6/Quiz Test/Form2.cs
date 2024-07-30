using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBoxAnsw1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnsw1.Checked)
            {
                checkBoxAnsw2.Checked = false;
                checkBoxAnsw3.Checked = false;
                checkBoxAnsw4.Checked = false;
            }
        }

        private void checkBoxAnsw2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnsw2.Checked)
            {
                checkBoxAnsw1.Checked = false;
                checkBoxAnsw3.Checked = false;
                checkBoxAnsw4.Checked = false;
            }
        }

        private void checkBoxAnsw3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnsw3.Checked)
            {
                checkBoxAnsw2.Checked = false;
                checkBoxAnsw1.Checked = false;
                checkBoxAnsw4.Checked = false;
            }
        }

        private void checkBoxAnsw4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAnsw4.Checked)
            {
                checkBoxAnsw2.Checked = false;
                checkBoxAnsw3.Checked = false;
                checkBoxAnsw1.Checked = false;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (checkBoxAnsw1.Checked)
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Wrong answer please try again", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
        }
    }
}
