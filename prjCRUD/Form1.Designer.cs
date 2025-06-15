namespace prjCRUD
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
            lblId = new Label();
            lblNome = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtCelular = new TextBox();
            txtEmail = new TextBox();
            btnInserir = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            dgvContatos = new DataGridView();
            lblTitulo = new Label();
            rtb = new RichTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblTeste = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Beige;
            lblId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.FromArgb(30, 100, 210);
            lblId.Location = new Point(87, 106);
            lblId.Name = "lblId";
            lblId.Size = new Size(25, 17);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Beige;
            lblNome.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.FromArgb(30, 100, 210);
            lblNome.Location = new Point(87, 137);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 17);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Beige;
            lblTelefone.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTelefone.ForeColor = Color.FromArgb(30, 100, 210);
            lblTelefone.Location = new Point(87, 172);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(62, 17);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Beige;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(30, 100, 210);
            lblEmail.Location = new Point(91, 207);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 17);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // txtId
            // 
            txtId.BackColor = Color.LightGray;
            txtId.Location = new Point(149, 100);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(277, 23);
            txtId.TabIndex = 44343;
            txtId.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(230, 240, 255);
            txtNome.Location = new Point(149, 134);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(277, 23);
            txtNome.TabIndex = 5;
            // 
            // txtCelular
            // 
            txtCelular.BackColor = Color.FromArgb(230, 240, 255);
            txtCelular.Location = new Point(149, 169);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(277, 23);
            txtCelular.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(230, 240, 255);
            txtEmail.Location = new Point(149, 204);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(277, 23);
            txtEmail.TabIndex = 7;
            // 
            // btnInserir
            // 
            btnInserir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserir.ForeColor = Color.Black;
            btnInserir.Image = Properties.Resources.hd_bg2;
            btnInserir.Location = new Point(91, 248);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(74, 43);
            btnInserir.TabIndex = 8;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = Color.Black;
            btnAtualizar.Image = Properties.Resources.hd_bg2;
            btnAtualizar.Location = new Point(177, 248);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(84, 43);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Image = Properties.Resources.hd_bg2;
            btnExcluir.Location = new Point(273, 248);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(78, 43);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Image = Properties.Resources.hd_bg2;
            btnLimpar.Location = new Point(361, 248);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(105, 43);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Limpar Campos";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dgvContatos
            // 
            dgvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContatos.Location = new Point(91, 297);
            dgvContatos.Name = "dgvContatos";
            dgvContatos.Size = new Size(374, 150);
            dgvContatos.TabIndex = 12;
            dgvContatos.TabStop = false;
            dgvContatos.CellContentClick += dgvContatos_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Beige;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(30, 100, 190);
            lblTitulo.Location = new Point(189, 37);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(195, 37);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Projeto CRUD";
            // 
            // rtb
            // 
            rtb.BackColor = Color.Beige;
            rtb.Location = new Point(43, 21);
            rtb.Name = "rtb";
            rtb.ReadOnly = true;
            rtb.Size = new Size(459, 461);
            rtb.TabIndex = 1421;
            rtb.TabStop = false;
            rtb.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Beige;
            pictureBox1.Image = Properties.Resources.idea;
            pictureBox1.Location = new Point(393, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 38);
            pictureBox1.TabIndex = 44344;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Beige;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(439, 169);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 27);
            pictureBox2.TabIndex = 44345;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Beige;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(438, 206);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 22);
            pictureBox3.TabIndex = 44346;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Beige;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(439, 100);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 26);
            pictureBox4.TabIndex = 44347;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Beige;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(438, 137);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(29, 26);
            pictureBox5.TabIndex = 44348;
            pictureBox5.TabStop = false;
            // 
            // lblTeste
            // 
            lblTeste.AutoSize = true;
            lblTeste.Location = new Point(87, 459);
            lblTeste.Name = "lblTeste";
            lblTeste.Size = new Size(43, 15);
            lblTeste.TabIndex = 44349;
            lblTeste.Text = "output";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(549, 503);
            Controls.Add(lblTeste);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitulo);
            Controls.Add(dgvContatos);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(btnInserir);
            Controls.Add(txtEmail);
            Controls.Add(txtCelular);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(rtb);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projeto CRUD | Página Principal";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNome;
        private Label lblTelefone;
        private Label lblEmail;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtCelular;
        private TextBox txtEmail;
        private Button btnInserir;
        private Button btnAtualizar;
        private Button btnExcluir;
        private Button btnLimpar;
        private DataGridView dgvContatos;
        private Label lblTitulo;
        private RichTextBox rtb;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label lblTeste;
    }
}
