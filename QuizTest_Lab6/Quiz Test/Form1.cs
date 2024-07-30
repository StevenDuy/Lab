using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Quiz_Test
{
    public partial class Form1 : Form
    {
        //public List<Data> Datas = new List<Data>();
        private void ClearAllTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    ClearAllTextBoxes(c);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            //textBoxUserName1.Text = data.UsernameLogin;
            //textBoxUsername2.Text = data.UsernameRegist;
            //textBoxPassWord1.Text = data.PasswordLogin;
            //textBoxPassword2.Text = data.PasswordRegist;
        }


        public class Data
        {
            public string UsernameRegist { get; set; }
            public string PasswordRegist { get; set; }
            public string UsernameLogin { get; set; }
            public string PasswordLogin { get; set; }
        }

        private void linkLabelRegist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearAllTextBoxes(this);
            checkBoxMale.Checked = false;
            checkBoxFemale.Checked = false;
            checkBoxJava.Checked = false;
            checkBoxCSharp.Checked = false;
            checkBoxPHP.Checked = false;
            checkBoxSwift.Checked = false;

            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void buttonSubmit1_Click(object sender, EventArgs e)
        {
            string UsernameLogin = textBoxUserName1.Text;
            string UsernameRegist = textBoxUsername2.Text;
            string PasswordLogin = textBoxPassWord1.Text;
            string PasswordRegist = textBoxPassword2.Text;


            if (UsernameLogin == UsernameRegist && PasswordLogin == PasswordRegist && !string.IsNullOrEmpty(UsernameLogin) && !string.IsNullOrEmpty(PasswordLogin))
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else { MessageBox.Show("Wrong username or password please try again", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
        }

        private void buttonSubmit2_Click(object sender, EventArgs e)
        {
            string UsernameRegist = textBoxUsername2.Text;
            string PasswordRegist = textBoxPassword2.Text;
            string UsernameLogin = textBoxUserName1.Text;
            string PasswordLogin = textBoxPassWord1.Text;

            Data data = new Data
            {
                UsernameRegist = UsernameRegist,
                UsernameLogin = UsernameLogin,
                PasswordRegist = PasswordRegist,
                PasswordLogin = PasswordLogin,
            };
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void buttonReset2_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
            checkBoxMale.Checked = false;
            checkBoxFemale.Checked = false;
            checkBoxJava.Checked = false;
            checkBoxCSharp.Checked = false;
            checkBoxPHP.Checked = false;
            checkBoxSwift.Checked = false;
        }

        private void buttonReset1_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMale.Checked == true) { checkBoxFemale.Checked = false; }
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFemale.Checked == true) { checkBoxMale.Checked = false; }
        }

        private void checkBoxJava_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJava.Checked == true)
            {
                checkBoxPHP.Checked = false;
                checkBoxCSharp.Checked = false;
                checkBoxSwift.Checked = false;
            }
        }

        private void checkBoxPHP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPHP.Checked == true)
            {
                checkBoxJava.Checked = false;
                checkBoxCSharp.Checked = false;
                checkBoxSwift.Checked = false;
            }
        }

        private void checkBoxCSharp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCSharp.Checked == true)
            {
                checkBoxPHP.Checked = false;
                checkBoxJava.Checked = false;
                checkBoxSwift.Checked = false;
            }
        }

        private void checkBoxSwift_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSwift.Checked == true)
            {
                checkBoxPHP.Checked = false;
                checkBoxCSharp.Checked = false;
                checkBoxJava.Checked = false;
            }
        }
    }
}
