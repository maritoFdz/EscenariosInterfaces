namespace Escenario3
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
            components = new System.ComponentModel.Container();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblInfo = new Label();
            btnRegistrar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 25);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(88, 22);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(399, 26);
            txtUsuario.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(88, 67);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(399, 26);
            txtCorreo.TabIndex = 3;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(12, 70);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(54, 20);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "Correo";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(88, 115);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(399, 26);
            txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 118);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(88, 213);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(15, 20);
            lblInfo.TabIndex = 6;
            lblInfo.Text = "-";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(153, 168);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(200, 42);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 242);
            Controls.Add(btnRegistrar);
            Controls.Add(lblInfo);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblInfo;
        private Button btnRegistrar;
        private ErrorProvider errorProvider1;
    }
}
