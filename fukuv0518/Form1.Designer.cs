namespace fukuv0518
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
            namebtn = new Button();
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // namebtn
            // 
            namebtn.Location = new Point(132, 87);
            namebtn.Name = "namebtn";
            namebtn.Size = new Size(75, 23);
            namebtn.TabIndex = 0;
            namebtn.Text = "氏名";
            namebtn.UseVisualStyleBackColor = true;
            namebtn.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(354, 191);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "左";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(354, 86);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "消える";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(536, 169);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(156, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "押すなよ！絶対押すなよ！";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(namebtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button namebtn;
        private Button button2;
        private Button button3;
        private CheckBox checkBox1;
    }
}