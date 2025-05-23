namespace QuadraticEquationSolver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            lblValores = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            btnCalcularX1 = new Button();
            btnCalcularX2 = new Button();
            lblResposta = new Label();
            txtResposta = new TextBox();
            SuspendLayout();
            // 
            // lblValores
            // 
            lblValores.AutoSize = true;
            lblValores.BackColor = Color.Transparent;
            lblValores.Font = new Font("Segoe UI", 15F);
            lblValores.Location = new Point(108, 66);
            lblValores.Name = "lblValores";
            lblValores.Size = new Size(75, 28);
            lblValores.TabIndex = 0;
            lblValores.Text = "Valores";
            // 
            // txtA
            // 
            txtA.BackColor = Color.FromArgb(175, 255, 255);
            txtA.Location = new Point(93, 111);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 1;
            // 
            // txtB
            // 
            txtB.BackColor = Color.FromArgb(175, 255, 255);
            txtB.Location = new Point(93, 153);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 2;
            // 
            // txtC
            // 
            txtC.BackColor = Color.FromArgb(175, 255, 255);
            txtC.Location = new Point(93, 199);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 23);
            txtC.TabIndex = 3;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.BackColor = Color.Transparent;
            lblA.Location = new Point(56, 114);
            lblA.Name = "lblA";
            lblA.Size = new Size(15, 15);
            lblA.TabIndex = 4;
            lblA.Text = "A";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.BackColor = Color.Transparent;
            lblB.Location = new Point(56, 156);
            lblB.Name = "lblB";
            lblB.Size = new Size(14, 15);
            lblB.TabIndex = 5;
            lblB.Text = "B";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.BackColor = Color.Transparent;
            lblC.Location = new Point(56, 207);
            lblC.Name = "lblC";
            lblC.Size = new Size(15, 15);
            lblC.TabIndex = 6;
            lblC.Text = "C";
            // 
            // btnCalcularX1
            // 
            btnCalcularX1.BackColor = Color.LemonChiffon;
            btnCalcularX1.Location = new Point(287, 78);
            btnCalcularX1.Name = "btnCalcularX1";
            btnCalcularX1.Size = new Size(75, 23);
            btnCalcularX1.TabIndex = 7;
            btnCalcularX1.Text = "Calcular X1";
            btnCalcularX1.UseVisualStyleBackColor = false;
            btnCalcularX1.Click += btnCalcularX1_Click;
            // 
            // btnCalcularX2
            // 
            btnCalcularX2.BackColor = Color.LemonChiffon;
            btnCalcularX2.Location = new Point(287, 127);
            btnCalcularX2.Name = "btnCalcularX2";
            btnCalcularX2.Size = new Size(75, 24);
            btnCalcularX2.TabIndex = 8;
            btnCalcularX2.Text = "Calcular X2";
            btnCalcularX2.UseVisualStyleBackColor = false;
            btnCalcularX2.Click += btnCalcularX2_Click;
            // 
            // lblResposta
            // 
            lblResposta.AutoSize = true;
            lblResposta.BackColor = Color.Transparent;
            lblResposta.Location = new Point(274, 179);
            lblResposta.Name = "lblResposta";
            lblResposta.Size = new Size(54, 15);
            lblResposta.TabIndex = 9;
            lblResposta.Text = "Resposta";
            // 
            // txtResposta
            // 
            txtResposta.BackColor = Color.FromArgb(175, 255, 255);
            txtResposta.Location = new Point(276, 201);
            txtResposta.Name = "txtResposta";
            txtResposta.ReadOnly = true;
            txtResposta.Size = new Size(100, 23);
            txtResposta.TabIndex = 10;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(401, 294);
            Controls.Add(txtResposta);
            Controls.Add(lblResposta);
            Controls.Add(btnCalcularX2);
            Controls.Add(btnCalcularX1);
            Controls.Add(lblC);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblValores);
            Name = "frmPrincipal";
            Text = "Quadratic Equation Solver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValores;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label lblA;
        private Label lblB;
        private Label lblC;
        private Button btnCalcularX1;
        private Button btnCalcularX2;
        private Label lblResposta;
        private TextBox txtResposta;
    }
}
