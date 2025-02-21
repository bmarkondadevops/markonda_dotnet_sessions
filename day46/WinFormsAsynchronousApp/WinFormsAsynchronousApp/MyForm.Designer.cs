namespace WinFormsAsynchronousApp
{
    partial class MyForm
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
            btnLogin = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Username = new Label();
            Password = new Label();
            Clear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(98, 142);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(317, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(33, 90);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 5;
            Username.Text = "Username";
            Username.Click += label1_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(239, 88);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 6;
            Password.Text = "Password";
            Password.Click += Password_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(220, 142);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 23);
            Clear.TabIndex = 7;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 37);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 8;
            label1.Text = "User Authentication";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 450);
            Controls.Add(label1);
            Controls.Add(Clear);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnLogin);
            Name = "MyForm";
            Padding = new Padding(1);
            Text = "MyForm";
            Load += MyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Username;
        private Label Password;
        private Button Clear;
        protected Label label1;
    }
}