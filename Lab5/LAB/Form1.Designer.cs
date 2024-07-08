namespace LAB
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
            Cong = new Button();
            Tru = new Button();
            Nhan = new Button();
            Chia = new Button();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtAnswer = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Cong
            // 
            Cong.BackgroundImageLayout = ImageLayout.Center;
            Cong.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cong.Location = new Point(10, 54);
            Cong.Name = "Cong";
            Cong.Size = new Size(94, 52);
            Cong.TabIndex = 0;
            Cong.Text = "+";
            Cong.UseVisualStyleBackColor = false;
            Cong.Click += Cong_Click;
            // 
            // Tru
            // 
            Tru.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tru.Location = new Point(10, 120);
            Tru.Name = "Tru";
            Tru.Size = new Size(94, 57);
            Tru.TabIndex = 1;
            Tru.Text = "-";
            Tru.UseVisualStyleBackColor = true;
            Tru.Click += Tru_Click;
            // 
            // Nhan
            // 
            Nhan.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nhan.Location = new Point(125, 54);
            Nhan.Name = "Nhan";
            Nhan.Size = new Size(94, 52);
            Nhan.TabIndex = 2;
            Nhan.Text = "×";
            Nhan.UseVisualStyleBackColor = true;
            Nhan.Click += Nhan_Click;
            // 
            // Chia
            // 
            Chia.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Chia.Location = new Point(125, 120);
            Chia.Name = "Chia";
            Chia.Size = new Size(94, 57);
            Chia.TabIndex = 3;
            Chia.Text = "÷";
            Chia.UseVisualStyleBackColor = true;
            Chia.Click += Chia_Click;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(7, 21);
            txtNum1.Name = "txtNum1";
            txtNum1.PlaceholderText = "Enter Number 1";
            txtNum1.Size = new Size(125, 27);
            txtNum1.TabIndex = 4;
            txtNum1.TextChanged += textBox1_TextChanged;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(7, 183);
            txtNum2.Name = "txtNum2";
            txtNum2.PlaceholderText = "Enter number 2";
            txtNum2.Size = new Size(125, 27);
            txtNum2.TabIndex = 5;
            txtNum2.TextChanged += textBox2_TextChanged;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(323, 101);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.ReadOnly = true;
            txtAnswer.Size = new Size(125, 27);
            txtAnswer.TabIndex = 6;
            txtAnswer.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 104);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 7;
            label1.Text = "Answer";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 243);
            Controls.Add(label1);
            Controls.Add(txtAnswer);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(Chia);
            Controls.Add(Nhan);
            Controls.Add(Tru);
            Controls.Add(Cong);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cong;
        private Button Tru;
        private Button Nhan;
        private Button Chia;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtAnswer;
        private Label label1;
    }
}
