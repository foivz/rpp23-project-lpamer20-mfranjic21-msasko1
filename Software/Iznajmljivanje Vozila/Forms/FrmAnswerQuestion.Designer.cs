namespace Iznajmljivanje_Vozila
{
    partial class FrmAnswerQuestion
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
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtMessageDate = new System.Windows.Forms.TextBox();
            this.mltAnswer = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnSaveAnswer = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(10, 77);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(120, 20);
            this.txtCustomer.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(136, 78);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(255, 45);
            this.txtMessage.TabIndex = 1;
            // 
            // txtMessageDate
            // 
            this.txtMessageDate.Location = new System.Drawing.Point(10, 103);
            this.txtMessageDate.Name = "txtMessageDate";
            this.txtMessageDate.ReadOnly = true;
            this.txtMessageDate.Size = new System.Drawing.Size(120, 20);
            this.txtMessageDate.TabIndex = 2;
            // 
            // mltAnswer
            // 
            this.mltAnswer.AnimateReadOnly = false;
            this.mltAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mltAnswer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mltAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mltAnswer.Depth = 0;
            this.mltAnswer.HideSelection = true;
            this.mltAnswer.Location = new System.Drawing.Point(10, 129);
            this.mltAnswer.MaxLength = 32767;
            this.mltAnswer.MouseState = MaterialSkin.MouseState.OUT;
            this.mltAnswer.Name = "mltAnswer";
            this.mltAnswer.PasswordChar = '\0';
            this.mltAnswer.ReadOnly = false;
            this.mltAnswer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mltAnswer.SelectedText = "";
            this.mltAnswer.SelectionLength = 0;
            this.mltAnswer.SelectionStart = 0;
            this.mltAnswer.ShortcutsEnabled = true;
            this.mltAnswer.Size = new System.Drawing.Size(380, 100);
            this.mltAnswer.TabIndex = 3;
            this.mltAnswer.TabStop = false;
            this.mltAnswer.Text = "Odgovori na pitanje...";
            this.mltAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mltAnswer.UseSystemPasswordChar = false;
            // 
            // btnSaveAnswer
            // 
            this.btnSaveAnswer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveAnswer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveAnswer.Depth = 0;
            this.btnSaveAnswer.HighEmphasis = true;
            this.btnSaveAnswer.Icon = null;
            this.btnSaveAnswer.Location = new System.Drawing.Point(126, 240);
            this.btnSaveAnswer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveAnswer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveAnswer.Name = "btnSaveAnswer";
            this.btnSaveAnswer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveAnswer.Size = new System.Drawing.Size(147, 36);
            this.btnSaveAnswer.TabIndex = 4;
            this.btnSaveAnswer.Text = "Spremi odgovor";
            this.btnSaveAnswer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveAnswer.UseAccentColor = false;
            this.btnSaveAnswer.UseVisualStyleBackColor = true;
            this.btnSaveAnswer.Click += new System.EventHandler(this.btnSaveAnswer_Click);
            // 
            // frmAnswerQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnSaveAnswer);
            this.Controls.Add(this.mltAnswer);
            this.Controls.Add(this.txtMessageDate);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtCustomer);
            this.Name = "frmAnswerQuestion";
            this.Text = "Odgovori na pitanje";
            this.Load += new System.EventHandler(this.FrmAnswerQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtMessageDate;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 mltAnswer;
        private MaterialSkin.Controls.MaterialButton btnSaveAnswer;
    }
}