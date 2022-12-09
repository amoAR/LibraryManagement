namespace library
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.pnlUserBorder = new System.Windows.Forms.Panel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.pnlPassBorder = new System.Windows.Forms.Panel();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            this.SuspendLayout();
            // 
            // picTitle
            // 
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(125, 42);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(85, 85);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // pnlUserBorder
            // 
            this.pnlUserBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.pnlUserBorder.Location = new System.Drawing.Point(49, 227);
            this.pnlUserBorder.Name = "pnlUserBorder";
            this.pnlUserBorder.Size = new System.Drawing.Size(236, 1);
            this.pnlUserBorder.TabIndex = 1;
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(260, 196);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(25, 25);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 2;
            this.picUser.TabStop = false;
            // 
            // pnlPassBorder
            // 
            this.pnlPassBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.pnlPassBorder.Location = new System.Drawing.Point(49, 293);
            this.pnlPassBorder.Name = "pnlPassBorder";
            this.pnlPassBorder.Size = new System.Drawing.Size(236, 1);
            this.pnlPassBorder.TabIndex = 1;
            // 
            // picPass
            // 
            this.picPass.Image = ((System.Drawing.Image)(resources.GetObject("picPass.Image")));
            this.picPass.Location = new System.Drawing.Point(260, 262);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(25, 25);
            this.picPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPass.TabIndex = 2;
            this.picPass.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Yekan Bakh Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(49, 327);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(236, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "ورود";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 401);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picPass);
            this.Controls.Add(this.pnlPassBorder);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.pnlUserBorder);
            this.Controls.Add(this.picTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Panel pnlUserBorder;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Panel pnlPassBorder;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.Button btnLogin;
    }
}