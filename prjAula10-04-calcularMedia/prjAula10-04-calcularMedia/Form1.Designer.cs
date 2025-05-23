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
            SuspendLayout();
            // 
            // textNota2
            // 
            textNota2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textNota2.Location = new Point(302, 85);
            textNota2.Name = "textNota2";
            textNota2.Size = new Size(125, 27);
            textNota2.TabIndex = 0;
            // 
            // textNota1
            // 
            textNota1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textNota1.Location = new Point(75, 84);
            textNota1.Name = "textNota1";
            textNota1.Size = new Size(125, 27);
            textNota1.TabIndex = 0;
            // 
            // textNota3
            // 
            textNota3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textNota3.Location = new Point(537, 85);
            textNota3.Name = "textNota3";
            textNota3.Size = new Size(125, 27);
            textNota3.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(20, 88);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 2;
            label1.Text = "Nota1:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(246, 89);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 3;
            label2.Text = "Nota2:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(480, 90);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 4;
            label3.Text = "Nota3:";
            // 
            // textMedia
            // 
            textMedia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textMedia.Enabled = false;
            textMedia.Location = new Point(75, 185);
            textMedia.Name = "textMedia";
            textMedia.Size = new Size(125, 27);
            textMedia.TabIndex = 5;
            // 
            // textStatus
            // 
            textStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textStatus.Enabled = false;
            textStatus.Location = new Point(302, 185);
            textStatus.Name = "textStatus";
            textStatus.Size = new Size(125, 27);
            textStatus.TabIndex = 6;
            // 
            // lblMedia
            // 
            lblMedia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(18, 190);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(54, 20);
            lblMedia.TabIndex = 7;
            lblMedia.Text = "Média:";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(247, 190);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 20);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(694, 86);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(694, 146);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
            btnSair.TabIndex = 10;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
