namespace WindFormPraktikum9
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
            label1 = new Label();
            TBUsername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TBPassword = new TextBox();
            BtnRegister = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 60);
            label1.Name = "label1";
            label1.Size = new Size(243, 40);
            label1.TabIndex = 0;
            label1.Text = "Halaman Register";
            // 
            // TBUsername
            // 
            TBUsername.Anchor = AnchorStyles.Top;
            TBUsername.Location = new Point(184, 147);
            TBUsername.Name = "TBUsername";
            TBUsername.Size = new Size(431, 27);
            TBUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(184, 124);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(185, 200);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // TBPassword
            // 
            TBPassword.Anchor = AnchorStyles.Top;
            TBPassword.Location = new Point(185, 223);
            TBPassword.Name = "TBPassword";
            TBPassword.Size = new Size(431, 27);
            TBPassword.TabIndex = 3;
            TBPassword.UseSystemPasswordChar = true;
            // 
            // BtnRegister
            // 
            BtnRegister.Anchor = AnchorStyles.Top;
            BtnRegister.BackColor = SystemColors.Highlight;
            BtnRegister.Location = new Point(338, 277);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(128, 50);
            BtnRegister.TabIndex = 5;
            BtnRegister.Text = "Register";
            BtnRegister.UseVisualStyleBackColor = false;
            BtnRegister.Click += BtnRegister_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(402, 345);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 6;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(BtnRegister);
            Controls.Add(label3);
            Controls.Add(TBPassword);
            Controls.Add(label2);
            Controls.Add(TBUsername);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBUsername;
        private Label label2;
        private Label label3;
        private TextBox TBPassword;
        private Button BtnRegister;
        private Label label4;
    }
}
