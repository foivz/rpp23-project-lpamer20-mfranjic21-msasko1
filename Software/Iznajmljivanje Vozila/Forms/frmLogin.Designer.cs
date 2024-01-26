using System.Drawing;
using System.Windows.Forms;

namespace Iznajmljivanje_Vozila
{
    partial class FrmLogin
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnTurnOnCamera = new System.Windows.Forms.Button();
            this.btnTakePicture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(30, 110);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(30, 180);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(40, 244);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Prijava";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(40, 297);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Obriši";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(205, 96);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(115, 107);
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // btnTurnOnCamera
            // 
            this.btnTurnOnCamera.Location = new System.Drawing.Point(225, 232);
            this.btnTurnOnCamera.Name = "btnTurnOnCamera";
            this.btnTurnOnCamera.Size = new System.Drawing.Size(75, 47);
            this.btnTurnOnCamera.TabIndex = 5;
            this.btnTurnOnCamera.Text = "Uključi kameru:";
            this.btnTurnOnCamera.UseVisualStyleBackColor = true;
            // 
            // btnTakePicture
            // 
            this.btnTakePicture.Location = new System.Drawing.Point(225, 297);
            this.btnTakePicture.Name = "btnTakePicture";
            this.btnTakePicture.Size = new System.Drawing.Size(75, 23);
            this.btnTakePicture.TabIndex = 6;
            this.btnTakePicture.Text = "Poslikaj";
            this.btnTakePicture.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lozinka:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTakePicture);
            this.Controls.Add(this.btnTurnOnCamera);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "FrmLogin";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnClear;
        private PictureBox pbImage;
        private Button btnTurnOnCamera;
        private Button btnTakePicture;
        private Label label1;
        private Label label2;
    }
}

