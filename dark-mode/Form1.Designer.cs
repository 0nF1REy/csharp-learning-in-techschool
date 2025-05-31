namespace dark_mode
{
    partial class frmPrincipal
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
            btnSwitch = new Button();
            richTextBox1 = new RichTextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnSwitch
            // 
            btnSwitch.Location = new Point(485, 16);
            btnSwitch.Name = "btnSwitch";
            btnSwitch.Size = new Size(124, 45);
            btnSwitch.TabIndex = 0;
            btnSwitch.Text = "Trocar Tema";
            btnSwitch.UseVisualStyleBackColor = true;
            btnSwitch.Click += btnSwitch_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(33, 67);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(576, 260);
            richTextBox1.TabIndex = 1024;
            richTextBox1.TabStop = false;
            richTextBox1.Text = "";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(377, 16);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 1025;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(377, 42);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 1026;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(33, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(318, 23);
            dateTimePicker1.TabIndex = 1027;
            dateTimePicker1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 23);
            textBox1.TabIndex = 1028;
            textBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 355);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(richTextBox1);
            Controls.Add(btnSwitch);
            Name = "frmPrincipal";
            Text = "Dark Mode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSwitch;
        private RichTextBox richTextBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
    }
}
