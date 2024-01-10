namespace WFPSignIn
{
    partial class RegisterUserView
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
            this.txtRegUName = new System.Windows.Forms.TextBox();
            this.txtRegPWord = new System.Windows.Forms.TextBox();
            this.txtRegPWord2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRegUName
            // 
            this.txtRegUName.Location = new System.Drawing.Point(350, 132);
            this.txtRegUName.Name = "txtRegUName";
            this.txtRegUName.Size = new System.Drawing.Size(100, 20);
            this.txtRegUName.TabIndex = 0;
            // 
            // txtRegPWord
            // 
            this.txtRegPWord.Location = new System.Drawing.Point(350, 184);
            this.txtRegPWord.Name = "txtRegPWord";
            this.txtRegPWord.Size = new System.Drawing.Size(100, 20);
            this.txtRegPWord.TabIndex = 1;
            // 
            // txtRegPWord2
            // 
            this.txtRegPWord2.Location = new System.Drawing.Point(350, 242);
            this.txtRegPWord2.Name = "txtRegPWord2";
            this.txtRegPWord2.Size = new System.Drawing.Size(100, 20);
            this.txtRegPWord2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter password again:";
            // 
            // btnRegUser
            // 
            this.btnRegUser.Location = new System.Drawing.Point(365, 279);
            this.btnRegUser.Name = "btnRegUser";
            this.btnRegUser.Size = new System.Drawing.Size(75, 23);
            this.btnRegUser.TabIndex = 6;
            this.btnRegUser.Text = "Register";
            this.btnRegUser.UseVisualStyleBackColor = true;
            this.btnRegUser.Click += new System.EventHandler(this.btnRegUser_Click);
            // 
            // RegisterUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegPWord2);
            this.Controls.Add(this.txtRegPWord);
            this.Controls.Add(this.txtRegUName);
            this.Name = "RegisterUserView";
            this.Text = "Register user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegUName;
        private System.Windows.Forms.TextBox txtRegPWord;
        private System.Windows.Forms.TextBox txtRegPWord2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegUser;
    }
}