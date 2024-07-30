namespace Quiz_Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxUserName1 = new TextBox();
            labelUsername1 = new Label();
            labelPassword1 = new Label();
            textBoxPassWord1 = new TextBox();
            buttonSubmit1 = new Button();
            buttonReset2 = new Button();
            linkLabelRegist = new LinkLabel();
            textBoxUsername2 = new TextBox();
            textBoxPhone2 = new TextBox();
            textBoxPassword2 = new TextBox();
            labelUsername2 = new Label();
            labelPhone2 = new Label();
            labelPassword2 = new Label();
            linkLabelLogin = new LinkLabel();
            buttonSubmit2 = new Button();
            checkBoxSwift = new CheckBox();
            checkBoxCSharp = new CheckBox();
            checkBoxPHP = new CheckBox();
            checkBoxJava = new CheckBox();
            labelLanguage = new Label();
            panel2 = new Panel();
            labelGender = new Label();
            panelGender = new Panel();
            checkBoxMale = new CheckBox();
            checkBoxFemale = new CheckBox();
            buttonReset1 = new Button();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panelGender.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxUserName1
            // 
            textBoxUserName1.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserName1.Location = new Point(98, 22);
            textBoxUserName1.Name = "textBoxUserName1";
            textBoxUserName1.PlaceholderText = "Please enter username";
            textBoxUserName1.Size = new Size(200, 27);
            textBoxUserName1.TabIndex = 0;
            // 
            // labelUsername1
            // 
            labelUsername1.AutoSize = true;
            labelUsername1.Location = new Point(1, 24);
            labelUsername1.Name = "labelUsername1";
            labelUsername1.Size = new Size(75, 20);
            labelUsername1.TabIndex = 1;
            labelUsername1.Text = "Username";
            // 
            // labelPassword1
            // 
            labelPassword1.AutoSize = true;
            labelPassword1.Location = new Point(1, 95);
            labelPassword1.Name = "labelPassword1";
            labelPassword1.Size = new Size(70, 20);
            labelPassword1.TabIndex = 2;
            labelPassword1.Text = "Password";
            // 
            // textBoxPassWord1
            // 
            textBoxPassWord1.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassWord1.Location = new Point(98, 92);
            textBoxPassWord1.Name = "textBoxPassWord1";
            textBoxPassWord1.PlaceholderText = "Please enter password";
            textBoxPassWord1.Size = new Size(200, 27);
            textBoxPassWord1.TabIndex = 3;
            textBoxPassWord1.UseSystemPasswordChar = true;
            // 
            // buttonSubmit1
            // 
            buttonSubmit1.BackColor = Color.Lime;
            buttonSubmit1.FlatStyle = FlatStyle.Flat;
            buttonSubmit1.Location = new Point(1, 164);
            buttonSubmit1.Name = "buttonSubmit1";
            buttonSubmit1.Size = new Size(100, 50);
            buttonSubmit1.TabIndex = 4;
            buttonSubmit1.Text = "Submit";
            buttonSubmit1.UseVisualStyleBackColor = false;
            buttonSubmit1.Click += buttonSubmit1_Click;
            // 
            // buttonReset2
            // 
            buttonReset2.BackColor = Color.LightCoral;
            buttonReset2.FlatStyle = FlatStyle.Flat;
            buttonReset2.Location = new Point(245, 359);
            buttonReset2.Name = "buttonReset2";
            buttonReset2.Size = new Size(100, 50);
            buttonReset2.TabIndex = 5;
            buttonReset2.Text = "Reset";
            buttonReset2.UseVisualStyleBackColor = false;
            buttonReset2.Click += buttonReset2_Click;
            // 
            // linkLabelRegist
            // 
            linkLabelRegist.AutoSize = true;
            linkLabelRegist.Location = new Point(23, 218);
            linkLabelRegist.Name = "linkLabelRegist";
            linkLabelRegist.Size = new Size(254, 20);
            linkLabelRegist.TabIndex = 7;
            linkLabelRegist.TabStop = true;
            linkLabelRegist.Text = "You have not an account? Regist now";
            linkLabelRegist.LinkClicked += linkLabelRegist_LinkClicked;
            // 
            // textBoxUsername2
            // 
            textBoxUsername2.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername2.Location = new Point(102, 11);
            textBoxUsername2.Name = "textBoxUsername2";
            textBoxUsername2.PlaceholderText = "Please enter your username";
            textBoxUsername2.Size = new Size(254, 27);
            textBoxUsername2.TabIndex = 8;
            // 
            // textBoxPhone2
            // 
            textBoxPhone2.BorderStyle = BorderStyle.FixedSingle;
            textBoxPhone2.Location = new Point(102, 69);
            textBoxPhone2.Name = "textBoxPhone2";
            textBoxPhone2.PlaceholderText = "Please enter your phone number";
            textBoxPhone2.Size = new Size(254, 27);
            textBoxPhone2.TabIndex = 9;
            // 
            // textBoxPassword2
            // 
            textBoxPassword2.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword2.Location = new Point(105, 124);
            textBoxPassword2.Name = "textBoxPassword2";
            textBoxPassword2.PlaceholderText = "Please enter your password";
            textBoxPassword2.Size = new Size(251, 27);
            textBoxPassword2.TabIndex = 10;
            // 
            // labelUsername2
            // 
            labelUsername2.AutoSize = true;
            labelUsername2.Location = new Point(8, 13);
            labelUsername2.Name = "labelUsername2";
            labelUsername2.Size = new Size(75, 20);
            labelUsername2.TabIndex = 11;
            labelUsername2.Text = "Username";
            // 
            // labelPhone2
            // 
            labelPhone2.AutoSize = true;
            labelPhone2.Location = new Point(8, 71);
            labelPhone2.Name = "labelPhone2";
            labelPhone2.Size = new Size(50, 20);
            labelPhone2.TabIndex = 12;
            labelPhone2.Text = "Phone";
            // 
            // labelPassword2
            // 
            labelPassword2.AutoSize = true;
            labelPassword2.Location = new Point(8, 124);
            labelPassword2.Name = "labelPassword2";
            labelPassword2.Size = new Size(70, 20);
            labelPassword2.TabIndex = 13;
            labelPassword2.Text = "Password";
            // 
            // linkLabelLogin
            // 
            linkLabelLogin.AutoSize = true;
            linkLabelLogin.Location = new Point(86, 414);
            linkLabelLogin.Name = "linkLabelLogin";
            linkLabelLogin.Size = new Size(196, 20);
            linkLabelLogin.TabIndex = 14;
            linkLabelLogin.TabStop = true;
            linkLabelLogin.Text = "You have an account? Log in";
            linkLabelLogin.LinkClicked += linkLabelLogin_LinkClicked;
            // 
            // buttonSubmit2
            // 
            buttonSubmit2.BackColor = Color.Lime;
            buttonSubmit2.FlatStyle = FlatStyle.Flat;
            buttonSubmit2.Location = new Point(16, 359);
            buttonSubmit2.Name = "buttonSubmit2";
            buttonSubmit2.Size = new Size(100, 50);
            buttonSubmit2.TabIndex = 15;
            buttonSubmit2.Text = "Submit";
            buttonSubmit2.UseVisualStyleBackColor = false;
            buttonSubmit2.Click += buttonSubmit2_Click;
            // 
            // checkBoxSwift
            // 
            checkBoxSwift.AutoSize = true;
            checkBoxSwift.Location = new Point(234, 320);
            checkBoxSwift.Name = "checkBoxSwift";
            checkBoxSwift.Size = new Size(64, 24);
            checkBoxSwift.TabIndex = 20;
            checkBoxSwift.Text = "Swift";
            checkBoxSwift.UseVisualStyleBackColor = true;
            checkBoxSwift.CheckedChanged += checkBoxSwift_CheckedChanged;
            // 
            // checkBoxCSharp
            // 
            checkBoxCSharp.AutoSize = true;
            checkBoxCSharp.Location = new Point(123, 320);
            checkBoxCSharp.Name = "checkBoxCSharp";
            checkBoxCSharp.Size = new Size(49, 24);
            checkBoxCSharp.TabIndex = 19;
            checkBoxCSharp.Text = "C#";
            checkBoxCSharp.UseVisualStyleBackColor = true;
            checkBoxCSharp.CheckedChanged += checkBoxCSharp_CheckedChanged;
            // 
            // checkBoxPHP
            // 
            checkBoxPHP.AutoSize = true;
            checkBoxPHP.Location = new Point(234, 262);
            checkBoxPHP.Name = "checkBoxPHP";
            checkBoxPHP.Size = new Size(58, 24);
            checkBoxPHP.TabIndex = 18;
            checkBoxPHP.Text = "PHP";
            checkBoxPHP.UseVisualStyleBackColor = true;
            checkBoxPHP.CheckedChanged += checkBoxPHP_CheckedChanged;
            // 
            // checkBoxJava
            // 
            checkBoxJava.AutoSize = true;
            checkBoxJava.Location = new Point(123, 263);
            checkBoxJava.Name = "checkBoxJava";
            checkBoxJava.Size = new Size(59, 24);
            checkBoxJava.TabIndex = 16;
            checkBoxJava.Text = "Java";
            checkBoxJava.UseVisualStyleBackColor = true;
            checkBoxJava.CheckedChanged += checkBoxJava_CheckedChanged;
            // 
            // labelLanguage
            // 
            labelLanguage.AutoSize = true;
            labelLanguage.Location = new Point(9, 263);
            labelLanguage.Name = "labelLanguage";
            labelLanguage.Size = new Size(74, 20);
            labelLanguage.TabIndex = 17;
            labelLanguage.Text = "Language";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(labelGender);
            panel2.Controls.Add(panelGender);
            panel2.Controls.Add(buttonReset2);
            panel2.Controls.Add(linkLabelLogin);
            panel2.Controls.Add(checkBoxSwift);
            panel2.Controls.Add(buttonSubmit2);
            panel2.Controls.Add(labelPassword2);
            panel2.Controls.Add(labelLanguage);
            panel2.Controls.Add(labelPhone2);
            panel2.Controls.Add(checkBoxJava);
            panel2.Controls.Add(labelUsername2);
            panel2.Controls.Add(checkBoxCSharp);
            panel2.Controls.Add(textBoxPassword2);
            panel2.Controls.Add(textBoxPhone2);
            panel2.Controls.Add(checkBoxPHP);
            panel2.Controls.Add(textBoxUsername2);
            panel2.Location = new Point(203, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 442);
            panel2.TabIndex = 21;
            panel2.Visible = false;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(90, 179);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(57, 20);
            labelGender.TabIndex = 22;
            labelGender.Text = "Gender";
            // 
            // panelGender
            // 
            panelGender.BorderStyle = BorderStyle.FixedSingle;
            panelGender.Controls.Add(checkBoxMale);
            panelGender.Controls.Add(checkBoxFemale);
            panelGender.Location = new Point(86, 191);
            panelGender.Name = "panelGender";
            panelGender.Size = new Size(195, 46);
            panelGender.TabIndex = 21;
            // 
            // checkBoxMale
            // 
            checkBoxMale.AutoSize = true;
            checkBoxMale.Location = new Point(3, 19);
            checkBoxMale.Name = "checkBoxMale";
            checkBoxMale.Size = new Size(64, 24);
            checkBoxMale.TabIndex = 5;
            checkBoxMale.Text = "Male";
            checkBoxMale.UseVisualStyleBackColor = true;
            checkBoxMale.CheckedChanged += checkBoxMale_CheckedChanged;
            // 
            // checkBoxFemale
            // 
            checkBoxFemale.AutoSize = true;
            checkBoxFemale.Location = new Point(111, 19);
            checkBoxFemale.Name = "checkBoxFemale";
            checkBoxFemale.Size = new Size(79, 24);
            checkBoxFemale.TabIndex = 6;
            checkBoxFemale.Text = "Female";
            checkBoxFemale.UseVisualStyleBackColor = true;
            checkBoxFemale.CheckedChanged += checkBoxFemale_CheckedChanged;
            // 
            // buttonReset1
            // 
            buttonReset1.BackColor = Color.LightCoral;
            buttonReset1.FlatStyle = FlatStyle.Flat;
            buttonReset1.Location = new Point(198, 164);
            buttonReset1.Name = "buttonReset1";
            buttonReset1.Size = new Size(100, 50);
            buttonReset1.TabIndex = 23;
            buttonReset1.Text = "Reset";
            buttonReset1.UseVisualStyleBackColor = false;
            buttonReset1.Click += buttonReset1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(linkLabelRegist);
            panel1.Controls.Add(buttonReset1);
            panel1.Controls.Add(textBoxUserName1);
            panel1.Controls.Add(buttonSubmit1);
            panel1.Controls.Add(labelUsername1);
            panel1.Controls.Add(textBoxPassWord1);
            panel1.Controls.Add(labelPassword1);
            panel1.Location = new Point(244, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 280);
            panel1.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelGender.ResumeLayout(false);
            panelGender.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxUserName1;
        private Label labelUsername1;
        private Label labelPassword1;
        private TextBox textBoxPassWord1;
        private Button buttonSubmit1;
        private Button buttonReset2;
        private LinkLabel linkLabelRegist;
        private TextBox textBoxUsername2;
        private TextBox textBoxPhone2;
        private TextBox textBoxPassword2;
        private Label labelUsername2;
        private Label labelPhone2;
        private Label labelPassword2;
        private LinkLabel linkLabelLogin;
        private Button buttonSubmit2;
        private CheckBox checkBoxSwift;
        private CheckBox checkBoxCSharp;
        private CheckBox checkBoxPHP;
        private CheckBox checkBoxJava;
        private Label labelLanguage;
        private Panel panel2;
        private Panel panelGender;
        private CheckBox checkBoxMale;
        private CheckBox checkBoxFemale;
        private Label labelGender;
        private Button buttonReset1;
        private Panel panel1;
    }
}
