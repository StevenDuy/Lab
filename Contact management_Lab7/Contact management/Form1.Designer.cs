namespace Contact_management
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
            listViewContact = new ListView();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxPhone = new TextBox();
            labelLastName = new Label();
            labelFirstName = new Label();
            labelPhone = new Label();
            buttonAddContact = new Button();
            buttonSoft = new Button();
            SuspendLayout();
            // 
            // listViewContact
            // 
            listViewContact.Location = new Point(312, 47);
            listViewContact.Name = "listViewContact";
            listViewContact.Size = new Size(435, 453);
            listViewContact.TabIndex = 0;
            listViewContact.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(127, 140);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(153, 27);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(127, 79);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(153, 27);
            textBoxFirstName.TabIndex = 2;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(127, 201);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(153, 27);
            textBoxPhone.TabIndex = 3;
            textBoxPhone.KeyPress += textBoxPhone_KeyPress;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(43, 143);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(79, 20);
            labelLastName.TabIndex = 4;
            labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(42, 82);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(80, 20);
            labelFirstName.TabIndex = 5;
            labelFirstName.Text = "First Name";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(43, 204);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(50, 20);
            labelPhone.TabIndex = 6;
            labelPhone.Text = "Phone";
            // 
            // buttonAddContact
            // 
            buttonAddContact.Location = new Point(42, 400);
            buttonAddContact.Name = "buttonAddContact";
            buttonAddContact.Size = new Size(100, 100);
            buttonAddContact.TabIndex = 7;
            buttonAddContact.Text = "Add Contact";
            buttonAddContact.UseVisualStyleBackColor = true;
            buttonAddContact.Click += buttonAddContact_Click;
            // 
            // buttonSoft
            // 
            buttonSoft.Location = new Point(180, 400);
            buttonSoft.Name = "buttonSoft";
            buttonSoft.Size = new Size(100, 100);
            buttonSoft.TabIndex = 8;
            buttonSoft.Text = "Sort List";
            buttonSoft.UseVisualStyleBackColor = true;
            buttonSoft.Click += buttonSoft_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(buttonSoft);
            Controls.Add(buttonAddContact);
            Controls.Add(labelPhone);
            Controls.Add(labelFirstName);
            Controls.Add(labelLastName);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLastName);
            Controls.Add(listViewContact);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewContact;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private TextBox textBoxPhone;
        private Label labelLastName;
        private Label labelFirstName;
        private Label labelPhone;
        private Button buttonAddContact;
        private Button buttonSoft;
    }
}
