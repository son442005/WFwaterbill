namespace WFWaterBill
{
    partial class Login
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
            btnLogin = new Button();
            btnExit = new Button();
            txbUsername = new TextBox();
            txbPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 192, 255);
            btnLogin.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(64, 64, 64);
            btnLogin.Location = new Point(379, 571);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(162, 47);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 192, 255);
            btnExit.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(64, 64, 64);
            btnExit.Location = new Point(658, 571);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(162, 47);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // txbUsername
            // 
            txbUsername.BackColor = Color.FromArgb(192, 192, 255);
            txbUsername.Location = new Point(288, 346);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(569, 40);
            txbUsername.TabIndex = 2;
            // 
            // txbPass
            // 
            txbPass.BackColor = Color.FromArgb(192, 192, 255);
            txbPass.Location = new Point(288, 458);
            txbPass.Name = "txbPass";
            txbPass.PasswordChar = '*';
            txbPass.Size = new Size(569, 40);
            txbPass.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(100, 349);
            label1.Name = "label1";
            label1.Size = new Size(153, 39);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(100, 461);
            label2.Name = "label2";
            label2.Size = new Size(144, 39);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(390, 71);
            label3.Name = "label3";
            label3.Size = new Size(498, 77);
            label3.TabIndex = 6;
            label3.Text = "Water Billing Program";
            label3.Click += label3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(14F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1260, 798);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbPass);
            Controls.Add(txbUsername);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Font = new Font("Calibri", 10.125F, FontStyle.Bold);
            ForeColor = Color.FromArgb(64, 64, 64);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnExit;
        private TextBox txbUsername;
        private TextBox txbPass;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
