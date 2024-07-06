namespace Iznajmljivanje_Vozila.Forms
{
    partial class FrmCustomerSupport
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
            this.btnRefresh = new MaterialSkin.Controls.MaterialButton();
            this.btnSort = new MaterialSkin.Controls.MaterialButton();
            this.btnAsnwerQuestion = new MaterialSkin.Controls.MaterialButton();
            this.btnAddNewQuestion = new MaterialSkin.Controls.MaterialButton();
            this.btnRemoveQuestion = new MaterialSkin.Controls.MaterialButton();
            this.dgvCustomerSupport = new System.Windows.Forms.DataGridView();
            this.lblSortBy = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCategoryBy = new System.Windows.Forms.ComboBox();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerSupport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.HighEmphasis = true;
            this.btnRefresh.Icon = null;
            this.btnRefresh.Location = new System.Drawing.Point(30, 85);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRefresh.Size = new System.Drawing.Size(134, 36);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Osvježi prikaz";
            this.btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefresh.UseAccentColor = false;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSort
            // 
            this.btnSort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSort.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSort.Depth = 0;
            this.btnSort.HighEmphasis = true;
            this.btnSort.Icon = null;
            this.btnSort.Location = new System.Drawing.Point(680, 85);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSort.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSort.Name = "btnSort";
            this.btnSort.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSort.Size = new System.Drawing.Size(90, 36);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sortiraj";
            this.btnSort.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSort.UseAccentColor = false;
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnAsnwerQuestion
            // 
            this.btnAsnwerQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAsnwerQuestion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAsnwerQuestion.Depth = 0;
            this.btnAsnwerQuestion.HighEmphasis = true;
            this.btnAsnwerQuestion.Icon = null;
            this.btnAsnwerQuestion.Location = new System.Drawing.Point(589, 399);
            this.btnAsnwerQuestion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAsnwerQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsnwerQuestion.Name = "btnAsnwerQuestion";
            this.btnAsnwerQuestion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAsnwerQuestion.Size = new System.Drawing.Size(181, 36);
            this.btnAsnwerQuestion.TabIndex = 2;
            this.btnAsnwerQuestion.Text = "Odgovori na pitanje";
            this.btnAsnwerQuestion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAsnwerQuestion.UseAccentColor = false;
            this.btnAsnwerQuestion.UseVisualStyleBackColor = true;
            this.btnAsnwerQuestion.Click += new System.EventHandler(this.btnAsnwerQuestion_Click);
            // 
            // btnAddNewQuestion
            // 
            this.btnAddNewQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNewQuestion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddNewQuestion.Depth = 0;
            this.btnAddNewQuestion.HighEmphasis = true;
            this.btnAddNewQuestion.Icon = null;
            this.btnAddNewQuestion.Location = new System.Drawing.Point(405, 399);
            this.btnAddNewQuestion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddNewQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddNewQuestion.Name = "btnAddNewQuestion";
            this.btnAddNewQuestion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddNewQuestion.Size = new System.Drawing.Size(176, 36);
            this.btnAddNewQuestion.TabIndex = 3;
            this.btnAddNewQuestion.Text = "Dodaj novo pitanje";
            this.btnAddNewQuestion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddNewQuestion.UseAccentColor = false;
            this.btnAddNewQuestion.UseVisualStyleBackColor = true;
            this.btnAddNewQuestion.Click += new System.EventHandler(this.btnAddNewQuestion_Click);
            // 
            // btnRemoveQuestion
            // 
            this.btnRemoveQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveQuestion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemoveQuestion.Depth = 0;
            this.btnRemoveQuestion.HighEmphasis = true;
            this.btnRemoveQuestion.Icon = null;
            this.btnRemoveQuestion.Location = new System.Drawing.Point(261, 399);
            this.btnRemoveQuestion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoveQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveQuestion.Name = "btnRemoveQuestion";
            this.btnRemoveQuestion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemoveQuestion.Size = new System.Drawing.Size(136, 36);
            this.btnRemoveQuestion.TabIndex = 4;
            this.btnRemoveQuestion.Text = "Ukloni pitanje";
            this.btnRemoveQuestion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemoveQuestion.UseAccentColor = false;
            this.btnRemoveQuestion.UseVisualStyleBackColor = true;
            this.btnRemoveQuestion.Click += new System.EventHandler(this.btnRemoveQuestion_Click);
            // 
            // dgvCustomerSupport
            // 
            this.dgvCustomerSupport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerSupport.Location = new System.Drawing.Point(30, 130);
            this.dgvCustomerSupport.Name = "dgvCustomerSupport";
            this.dgvCustomerSupport.Size = new System.Drawing.Size(740, 260);
            this.dgvCustomerSupport.TabIndex = 5;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Depth = 0;
            this.lblSortBy.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSortBy.Location = new System.Drawing.Point(314, 94);
            this.lblSortBy.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(105, 19);
            this.lblSortBy.TabIndex = 6;
            this.lblSortBy.Text = "Sortiraj prema:";
            // 
            // cmbCategoryBy
            // 
            this.cmbCategoryBy.FormattingEnabled = true;
            this.cmbCategoryBy.Location = new System.Drawing.Point(425, 94);
            this.cmbCategoryBy.Name = "cmbCategoryBy";
            this.cmbCategoryBy.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoryBy.TabIndex = 7;
            this.cmbCategoryBy.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryBy_SelectedIndexChanged);
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbSortBy.Enabled = false;
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Location = new System.Drawing.Point(552, 94);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(121, 21);
            this.cmbSortBy.TabIndex = 8;
            // 
            // frmCustomerSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbSortBy);
            this.Controls.Add(this.cmbCategoryBy);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.dgvCustomerSupport);
            this.Controls.Add(this.btnRemoveQuestion);
            this.Controls.Add(this.btnAddNewQuestion);
            this.Controls.Add(this.btnAsnwerQuestion);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRefresh);
            this.Name = "frmCustomerSupport";
            this.Text = "Korisnička podrška";
            this.Load += new System.EventHandler(this.frmCustomerSupport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerSupport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnRefresh;
        private MaterialSkin.Controls.MaterialButton btnSort;
        private MaterialSkin.Controls.MaterialButton btnAsnwerQuestion;
        private MaterialSkin.Controls.MaterialButton btnAddNewQuestion;
        private MaterialSkin.Controls.MaterialButton btnRemoveQuestion;
        private System.Windows.Forms.DataGridView dgvCustomerSupport;
        private MaterialSkin.Controls.MaterialLabel lblSortBy;
        private System.Windows.Forms.ComboBox cmbCategoryBy;
        private System.Windows.Forms.ComboBox cmbSortBy;
    }
}