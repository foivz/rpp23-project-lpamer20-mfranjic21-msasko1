namespace Iznajmljivanje_Vozila.Forms
{
    partial class FrmAddNewQuestion
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
            this.btnAddNewQuestion = new MaterialSkin.Controls.MaterialButton();
            this.mltQuestionInput = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.cmbUserList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAddNewQuestion
            // 
            this.btnAddNewQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNewQuestion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddNewQuestion.Depth = 0;
            this.btnAddNewQuestion.HighEmphasis = true;
            this.btnAddNewQuestion.Icon = null;
            this.btnAddNewQuestion.Location = new System.Drawing.Point(134, 210);
            this.btnAddNewQuestion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddNewQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddNewQuestion.Name = "btnAddNewQuestion";
            this.btnAddNewQuestion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddNewQuestion.Size = new System.Drawing.Size(132, 36);
            this.btnAddNewQuestion.TabIndex = 0;
            this.btnAddNewQuestion.Text = "Dodaj pitanje";
            this.btnAddNewQuestion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddNewQuestion.UseAccentColor = false;
            this.btnAddNewQuestion.UseVisualStyleBackColor = true;
            this.btnAddNewQuestion.Click += new System.EventHandler(this.btnAddNewQuestion_Click);
            // 
            // mltQuestionInput
            // 
            this.mltQuestionInput.AnimateReadOnly = false;
            this.mltQuestionInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mltQuestionInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mltQuestionInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mltQuestionInput.Depth = 0;
            this.mltQuestionInput.HideSelection = true;
            this.mltQuestionInput.Location = new System.Drawing.Point(10, 100);
            this.mltQuestionInput.MaxLength = 32767;
            this.mltQuestionInput.MouseState = MaterialSkin.MouseState.OUT;
            this.mltQuestionInput.Name = "mltQuestionInput";
            this.mltQuestionInput.PasswordChar = '\0';
            this.mltQuestionInput.ReadOnly = false;
            this.mltQuestionInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mltQuestionInput.SelectedText = "";
            this.mltQuestionInput.SelectionLength = 0;
            this.mltQuestionInput.SelectionStart = 0;
            this.mltQuestionInput.ShortcutsEnabled = true;
            this.mltQuestionInput.Size = new System.Drawing.Size(380, 100);
            this.mltQuestionInput.TabIndex = 3;
            this.mltQuestionInput.TabStop = false;
            this.mltQuestionInput.Text = "Unesite pitanje...";
            this.mltQuestionInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mltQuestionInput.UseSystemPasswordChar = false;
            // 
            // cmbUserList
            // 
            this.cmbUserList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserList.FormattingEnabled = true;
            this.cmbUserList.Location = new System.Drawing.Point(269, 73);
            this.cmbUserList.Name = "cmbUserList";
            this.cmbUserList.Size = new System.Drawing.Size(121, 21);
            this.cmbUserList.TabIndex = 4;
            // 
            // frmAddNewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.cmbUserList);
            this.Controls.Add(this.mltQuestionInput);
            this.Controls.Add(this.btnAddNewQuestion);
            this.Name = "frmAddNewQuestion";
            this.Text = "Dodavanje novog pitanja";
            this.Load += new System.EventHandler(this.FrmAddNewQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnAddNewQuestion;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 mltQuestionInput;
        private System.Windows.Forms.ComboBox cmbUserList;
    }
}