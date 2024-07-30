namespace Quiz_Test
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelQuest = new Label();
            panel1 = new Panel();
            buttonNext = new Button();
            checkBoxAnsw4 = new CheckBox();
            checkBoxAnsw3 = new CheckBox();
            checkBoxAnsw2 = new CheckBox();
            checkBoxAnsw1 = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelQuest
            // 
            labelQuest.AutoSize = true;
            labelQuest.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuest.Location = new Point(46, 87);
            labelQuest.Name = "labelQuest";
            labelQuest.Size = new Size(590, 38);
            labelQuest.TabIndex = 0;
            labelQuest.Text = "Which planet is known as the “Red Planet”?";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCoral;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonNext);
            panel1.Controls.Add(checkBoxAnsw4);
            panel1.Controls.Add(checkBoxAnsw3);
            panel1.Controls.Add(checkBoxAnsw2);
            panel1.Controls.Add(checkBoxAnsw1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 212);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 341);
            panel1.TabIndex = 1;
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.Turquoise;
            buttonNext.Location = new Point(295, 235);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(145, 82);
            buttonNext.TabIndex = 4;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // checkBoxAnsw4
            // 
            checkBoxAnsw4.AutoSize = true;
            checkBoxAnsw4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxAnsw4.Location = new Point(46, 226);
            checkBoxAnsw4.Name = "checkBoxAnsw4";
            checkBoxAnsw4.Size = new Size(73, 24);
            checkBoxAnsw4.TabIndex = 3;
            checkBoxAnsw4.Text = "Venus";
            checkBoxAnsw4.UseVisualStyleBackColor = true;
            checkBoxAnsw4.CheckedChanged += checkBoxAnsw4_CheckedChanged;
            // 
            // checkBoxAnsw3
            // 
            checkBoxAnsw3.AutoSize = true;
            checkBoxAnsw3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxAnsw3.Location = new Point(46, 153);
            checkBoxAnsw3.Name = "checkBoxAnsw3";
            checkBoxAnsw3.Size = new Size(80, 24);
            checkBoxAnsw3.TabIndex = 2;
            checkBoxAnsw3.Text = "Jupiter";
            checkBoxAnsw3.UseVisualStyleBackColor = true;
            checkBoxAnsw3.CheckedChanged += checkBoxAnsw3_CheckedChanged;
            // 
            // checkBoxAnsw2
            // 
            checkBoxAnsw2.AutoSize = true;
            checkBoxAnsw2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxAnsw2.Location = new Point(46, 84);
            checkBoxAnsw2.Name = "checkBoxAnsw2";
            checkBoxAnsw2.Size = new Size(68, 24);
            checkBoxAnsw2.TabIndex = 1;
            checkBoxAnsw2.Text = "Earth";
            checkBoxAnsw2.UseVisualStyleBackColor = true;
            checkBoxAnsw2.CheckedChanged += checkBoxAnsw2_CheckedChanged;
            // 
            // checkBoxAnsw1
            // 
            checkBoxAnsw1.AutoSize = true;
            checkBoxAnsw1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxAnsw1.Location = new Point(46, 19);
            checkBoxAnsw1.Name = "checkBoxAnsw1";
            checkBoxAnsw1.Size = new Size(66, 24);
            checkBoxAnsw1.TabIndex = 0;
            checkBoxAnsw1.Text = "Mars";
            checkBoxAnsw1.UseVisualStyleBackColor = true;
            checkBoxAnsw1.CheckedChanged += checkBoxAnsw1_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(panel1);
            Controls.Add(labelQuest);
            MinimumSize = new Size(800, 600);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelQuest;
        private Panel panel1;
        private Button buttonNext;
        private CheckBox checkBoxAnsw4;
        private CheckBox checkBoxAnsw3;
        private CheckBox checkBoxAnsw2;
        private CheckBox checkBoxAnsw1;
    }
}