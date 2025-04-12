namespace prjAula10_04_calcularMedia
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
            textNota2 = new TextBox();
            textNota1 = new TextBox();
            textNota3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textMedia = new TextBox();
            textStatus = new TextBox();
            lblMedia = new Label();
            lblStatus = new Label();
            btnCalcular = new Button();
            btnSair = new Button();
            monthCalendar1 = new MonthCalendar();
            label4 = new Label();
            SuspendLayout();
            // 
            // textNota2
            // 
            textNota2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textNota2.Location = new Point(66, 95);
            textNota2.Margin = new Padding(3, 2, 3, 2);
            textNota2.Name = "textNota2";
            textNota2.Size = new Size(110, 23);
            textNota2.TabIndex = 0;
            // 
            // textNota1
            // 
            textNota1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textNota1.Location = new Point(66, 63);
            textNota1.Margin = new Padding(3, 2, 3, 2);
            textNota1.Name = "textNota1";
            textNota1.Size = new Size(110, 23);
            textNota1.TabIndex = 0;
            // 
            // textNota3
            // 
            textNota3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textNota3.Location = new Point(66, 122);
            textNota3.Margin = new Padding(3, 2, 3, 2);
            textNota3.Name = "textNota3";
            textNota3.Size = new Size(110, 23);
            textNota3.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(18, 66);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Nota 1:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(18, 98);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Nota 2:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(15, 125);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Nota 3:";
            // 
            // textMedia
            // 
            textMedia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textMedia.Enabled = false;
            textMedia.Location = new Point(245, 81);
            textMedia.Margin = new Padding(3, 2, 3, 2);
            textMedia.Name = "textMedia";
            textMedia.Size = new Size(110, 23);
            textMedia.TabIndex = 5;
            // 
            // textStatus
            // 
            textStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textStatus.Enabled = false;
            textStatus.Location = new Point(245, 117);
            textStatus.Margin = new Padding(3, 2, 3, 2);
            textStatus.Name = "textStatus";
            textStatus.Size = new Size(110, 23);
            textStatus.TabIndex = 6;
            // 
            // lblMedia
            // 
            lblMedia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(196, 84);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(43, 15);
            lblMedia.TabIndex = 7;
            lblMedia.Text = "Média:";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(197, 122);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(80, 174);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(82, 22);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(218, 174);
            btnSair.Margin = new Padding(3, 2, 3, 2);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(82, 22);
            btnSair.TabIndex = 10;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.HotTrack;
            monthCalendar1.ForeColor = SystemColors.MenuText;
            monthCalendar1.Location = new Point(438, 34);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 21);
            label4.Name = "label4";
            label4.Size = new Size(146, 15);
            label4.TabIndex = 12;
            label4.Text = "Sistema de Calcular Média";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label4);
            Controls.Add(monthCalendar1);
            Controls.Add(btnSair);
            Controls.Add(btnCalcular);
            Controls.Add(lblStatus);
            Controls.Add(lblMedia);
            Controls.Add(textStatus);
            Controls.Add(textMedia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textNota3);
            Controls.Add(textNota1);
            Controls.Add(textNota2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNota2;
        private TextBox textNota1;
        private TextBox textNota3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textMedia;
        private TextBox textStatus;
        private Label lblMedia;
        private Label lblStatus;
        private Button btnCalcular;
        private Button btnSair;
        private MonthCalendar monthCalendar1;
        private Label label4;
    }
}
