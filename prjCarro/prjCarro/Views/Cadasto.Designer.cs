namespace prjCarro.Views
{
    partial class frmCadastro
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
            lblCadastroDeCarro = new Label();
            lblMarca = new Label();
            lblAno = new Label();
            lblModelo = new Label();
            lblPlaca = new Label();
            lblTipoCombustivel = new Label();
            lblQntPortas = new Label();
            lblCadAssentos = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtAno = new TextBox();
            txtPlaca = new TextBox();
            txtQntPortas = new TextBox();
            txtCadAssentos = new TextBox();
            txtTipoCombustivel = new TextBox();
            btnVisualizarDados = new Button();
            SuspendLayout();
            // 
            // lblCadastroDeCarro
            // 
            lblCadastroDeCarro.AutoSize = true;
            lblCadastroDeCarro.BackColor = Color.Transparent;
            lblCadastroDeCarro.Font = new Font("Segoe UI", 20F);
            lblCadastroDeCarro.Location = new Point(208, 27);
            lblCadastroDeCarro.Name = "lblCadastroDeCarro";
            lblCadastroDeCarro.Size = new Size(232, 37);
            lblCadastroDeCarro.TabIndex = 0;
            lblCadastroDeCarro.Text = "Cadastro de Carro";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(69, 103);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca:";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new Point(69, 188);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(32, 15);
            lblAno.TabIndex = 2;
            lblAno.Text = "Ano:";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(69, 143);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(51, 15);
            lblModelo.TabIndex = 3;
            lblModelo.Text = "Modelo:";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(69, 224);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(38, 15);
            lblPlaca.TabIndex = 4;
            lblPlaca.Text = "Placa:";
            // 
            // lblTipoCombustivel
            // 
            lblTipoCombustivel.AutoSize = true;
            lblTipoCombustivel.Location = new Point(70, 321);
            lblTipoCombustivel.Name = "lblTipoCombustivel";
            lblTipoCombustivel.Size = new Size(119, 15);
            lblTipoCombustivel.TabIndex = 5;
            lblTipoCombustivel.Text = "Tipo de Combustível:";
            // 
            // lblQntPortas
            // 
            lblQntPortas.AutoSize = true;
            lblQntPortas.Location = new Point(69, 262);
            lblQntPortas.Name = "lblQntPortas";
            lblQntPortas.Size = new Size(124, 15);
            lblQntPortas.TabIndex = 6;
            lblQntPortas.Text = "Quantidade de Portas:";
            // 
            // lblCadAssentos
            // 
            lblCadAssentos.AutoSize = true;
            lblCadAssentos.Location = new Point(69, 292);
            lblCadAssentos.Name = "lblCadAssentos";
            lblCadAssentos.Size = new Size(120, 15);
            lblCadAssentos.TabIndex = 7;
            lblCadAssentos.Text = "Cadastro de Assentos";
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.FromArgb(231, 216, 201);
            txtMarca.Location = new Point(209, 100);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(432, 23);
            txtMarca.TabIndex = 8;
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.FromArgb(231, 216, 201);
            txtModelo.Location = new Point(208, 140);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(433, 23);
            txtModelo.TabIndex = 9;
            // 
            // txtAno
            // 
            txtAno.BackColor = Color.FromArgb(231, 216, 201);
            txtAno.Location = new Point(209, 182);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(432, 23);
            txtAno.TabIndex = 10;
            // 
            // txtPlaca
            // 
            txtPlaca.BackColor = Color.FromArgb(231, 216, 201);
            txtPlaca.Location = new Point(208, 219);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(433, 23);
            txtPlaca.TabIndex = 11;
            // 
            // txtQntPortas
            // 
            txtQntPortas.BackColor = Color.FromArgb(231, 216, 201);
            txtQntPortas.Location = new Point(208, 254);
            txtQntPortas.Name = "txtQntPortas";
            txtQntPortas.Size = new Size(433, 23);
            txtQntPortas.TabIndex = 12;
            // 
            // txtCadAssentos
            // 
            txtCadAssentos.BackColor = Color.FromArgb(231, 216, 201);
            txtCadAssentos.Location = new Point(208, 289);
            txtCadAssentos.Name = "txtCadAssentos";
            txtCadAssentos.Size = new Size(433, 23);
            txtCadAssentos.TabIndex = 13;
            // 
            // txtTipoCombustivel
            // 
            txtTipoCombustivel.BackColor = Color.FromArgb(231, 216, 201);
            txtTipoCombustivel.Location = new Point(208, 318);
            txtTipoCombustivel.Name = "txtTipoCombustivel";
            txtTipoCombustivel.Size = new Size(433, 23);
            txtTipoCombustivel.TabIndex = 14;
            // 
            // btnVisualizarDados
            // 
            btnVisualizarDados.BackColor = Color.FromArgb(153, 216, 201);
            btnVisualizarDados.Font = new Font("Segoe UI", 11F);
            btnVisualizarDados.Location = new Point(447, 371);
            btnVisualizarDados.Name = "btnVisualizarDados";
            btnVisualizarDados.Size = new Size(194, 40);
            btnVisualizarDados.TabIndex = 15;
            btnVisualizarDados.Text = "Visualizar Dados";
            btnVisualizarDados.UseVisualStyleBackColor = false;
            btnVisualizarDados.Click += btnVisualizarDados_Click;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 236, 222);
            BackgroundImage = Properties.Resources.bg_main;
            ClientSize = new Size(666, 450);
            Controls.Add(btnVisualizarDados);
            Controls.Add(txtTipoCombustivel);
            Controls.Add(txtCadAssentos);
            Controls.Add(txtQntPortas);
            Controls.Add(txtPlaca);
            Controls.Add(txtAno);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(lblCadAssentos);
            Controls.Add(lblQntPortas);
            Controls.Add(lblTipoCombustivel);
            Controls.Add(lblPlaca);
            Controls.Add(lblModelo);
            Controls.Add(lblAno);
            Controls.Add(lblMarca);
            Controls.Add(lblCadastroDeCarro);
            Name = "frmCadastro";
            Text = "Formulário de Cadasto de Carro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroDeCarro;
        private Label lblMarca;
        private Label lblAno;
        private Label lblModelo;
        private Label lblPlaca;
        private Label lblTipoCombustivel;
        private Label lblQntPortas;
        private Label lblCadAssentos;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtAno;
        private TextBox txtPlaca;
        private TextBox txtQntPortas;
        private TextBox txtCadAssentos;
        private TextBox txtTipoCombustivel;
        private Button btnVisualizarDados;
    }
}