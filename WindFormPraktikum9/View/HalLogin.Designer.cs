namespace WindFormPraktikum9
{
    partial class HalLogin
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
            label4 = new Label();
            BtnRegister = new Button();
            label3 = new Label();
            TBPasswordLog = new TextBox();
            label2 = new Label();
            TBUsernameLog = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(402, 358);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 13;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnRegister
            // 
            BtnRegister.Anchor = AnchorStyles.Top;
            BtnRegister.BackColor = SystemColors.Highlight;
            BtnRegister.Location = new Point(338, 290);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(128, 50);
            BtnRegister.TabIndex = 12;
            BtnRegister.Text = "Login";
            BtnRegister.UseVisualStyleBackColor = false;
            BtnRegister.Click += BtnLogin_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(185, 213);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // TBPassword
            // 
            TBPasswordLog.Anchor = AnchorStyles.Top;
            TBPasswordLog.Location = new Point(185, 236);
            TBPasswordLog.Name = "TBPassword";
            TBPasswordLog.Size = new Size(431, 27);
            TBPasswordLog.TabIndex = 10;
            TBPasswordLog.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(184, 137);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 9;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TBUsername
            // 
            TBUsernameLog.Anchor = AnchorStyles.Top;
            TBUsernameLog.Location = new Point(184, 160);
            TBUsernameLog.Name = "TBUsername";
            TBUsernameLog.Size = new Size(431, 27);
            TBUsernameLog.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 72);
            label1.Name = "label1";
            label1.Size = new Size(207, 40);
            label1.TabIndex = 7;
            label1.Text = "Halaman Login";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(BtnRegister);
            Controls.Add(label3);
            Controls.Add(TBPasswordLog);
            Controls.Add(label2);
            Controls.Add(TBUsernameLog);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button BtnRegister;
        private Label label3;
        private TextBox TBPasswordLog;
        private Label label2;
        private TextBox TBUsernameLog;
        private Label label1;
    }
}