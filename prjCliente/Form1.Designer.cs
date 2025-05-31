namespace prjCliente
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
            richTextBox1 = new RichTextBox();
            lblCadastrarCliente = new Label();
            lblNome = new Label();
            lblCelular = new Label();
            lblEmail = new Label();
            txtNome = new TextBox();
            txtCelular = new TextBox();
            txtEmail = new TextBox();
            btnCadastrar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.SlateGray;
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.ForeColor = Color.FloralWhite;
            richTextBox1.Location = new Point(161, 38);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(430, 260);
            richTextBox1.TabIndex = 888;
            richTextBox1.TabStop = false;
            richTextBox1.Text = "";
            // 
            // lblCadastrarCliente
            // 
            lblCadastrarCliente.AutoSize = true;
            lblCadastrarCliente.BackColor = Color.SlateGray;
            lblCadastrarCliente.Font = new Font("Segoe UI", 18F);
            lblCadastrarCliente.ForeColor = Color.Aqua;
            lblCadastrarCliente.Location = new Point(266, 60);
            lblCadastrarCliente.Name = "lblCadastrarCliente";
            lblCadastrarCliente.Size = new Size(195, 32);
            lblCadastrarCliente.TabIndex = 2;
            lblCadastrarCliente.Text = "Cadastrar Cliente";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.SlateGray;
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(188, 128);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome:";
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.BackColor = Color.SlateGray;
            lblCelular.ForeColor = Color.White;
            lblCelular.Location = new Point(188, 162);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(47, 15);
            lblCelular.TabIndex = 4;
            lblCelular.Text = "Celular:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.SlateGray;
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(189, 195);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "E-mail:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(204, 229, 255);
            txtNome.Location = new Point(248, 125);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(268, 23);
            txtNome.TabIndex = 0;
            // 
            // txtCelular
            // 
            txtCelular.BackColor = Color.FromArgb(204, 229, 255);
            txtCelular.Location = new Point(248, 159);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(268, 23);
            txtCelular.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(204, 229, 255);
            txtEmail.Location = new Point(247, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 23);
            txtEmail.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Transparent;
            btnCadastrar.BackgroundImage = (Image)resources.GetObject("btnCadastrar.BackgroundImage");
            btnCadastrar.Font = new Font("Segoe UI", 10F);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.ImageAlign = ContentAlignment.MiddleRight;
            btnCadastrar.Location = new Point(313, 232);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(148, 34);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SlateGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(538, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 18);
            pictureBox1.TabIndex = 889;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.SlateGray;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(538, 195);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 18);
            pictureBox2.TabIndex = 890;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.SlateGray;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(539, 160);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 18);
            pictureBox3.TabIndex = 891;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.SlateGray;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(467, 62);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(36, 30);
            pictureBox4.TabIndex = 892;
            pictureBox4.TabStop = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(787, 339);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtEmail);
            Controls.Add(txtCelular);
            Controls.Add(txtNome);
            Controls.Add(lblEmail);
            Controls.Add(lblCelular);
            Controls.Add(lblNome);
            Controls.Add(lblCadastrarCliente);
            Controls.Add(richTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private Label lblCadastrarCliente;
        private Label lblNome;
        private Label lblCelular;
        private Label lblEmail;
        private TextBox txtNome;
        private TextBox txtCelular;
        private TextBox txtEmail;
        private Button btnCadastrar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
