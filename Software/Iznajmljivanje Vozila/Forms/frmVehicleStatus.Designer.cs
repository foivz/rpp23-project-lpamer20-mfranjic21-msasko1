using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace Iznajmljivanje_Vozila.Forms
{
    partial class FrmVehicleStatus
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
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.cboFilterType = new System.Windows.Forms.ComboBox();
            this.btnFilter = new MaterialSkin.Controls.MaterialButton();
            this.btnShowAll = new MaterialSkin.Controls.MaterialButton();
            this.dgvReservationHistory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetHistory = new MaterialSkin.Controls.MaterialButton();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Location = new System.Drawing.Point(16, 150);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.RowTemplate.Height = 25;
            this.dgvVehicles.Size = new System.Drawing.Size(744, 145);
            this.dgvVehicles.TabIndex = 0;
            // 
            // cboFilterType
            // 
            this.cboFilterType.FormattingEnabled = true;
            this.cboFilterType.Location = new System.Drawing.Point(75, 87);
            this.cboFilterType.Name = "cboFilterType";
            this.cboFilterType.Size = new System.Drawing.Size(104, 21);
            this.cboFilterType.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFilter.Depth = 0;
            this.btnFilter.HighEmphasis = true;
            this.btnFilter.Icon = null;
            this.btnFilter.Location = new System.Drawing.Point(378, 78);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFilter.Size = new System.Drawing.Size(91, 36);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filtriraj";
            this.btnFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFilter.UseAccentColor = false;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnShowAll.Depth = 0;
            this.btnShowAll.HighEmphasis = true;
            this.btnShowAll.Icon = null;
            this.btnShowAll.Location = new System.Drawing.Point(501, 78);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShowAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnShowAll.Size = new System.Drawing.Size(106, 36);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "Prikaži sve";
            this.btnShowAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnShowAll.UseAccentColor = false;
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgvReservationHistory
            // 
            this.dgvReservationHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservationHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationHistory.Location = new System.Drawing.Point(16, 371);
            this.dgvReservationHistory.Name = "dgvReservationHistory";
            this.dgvReservationHistory.RowTemplate.Height = 25;
            this.dgvReservationHistory.Size = new System.Drawing.Size(1044, 140);
            this.dgvReservationHistory.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtriraj po:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Povijest rezervacija:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vozila:";
            // 
            // btnGetHistory
            // 
            this.btnGetHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetHistory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGetHistory.Depth = 0;
            this.btnGetHistory.HighEmphasis = true;
            this.btnGetHistory.Icon = null;
            this.btnGetHistory.Location = new System.Drawing.Point(640, 78);
            this.btnGetHistory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGetHistory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGetHistory.Name = "btnGetHistory";
            this.btnGetHistory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGetHistory.Size = new System.Drawing.Size(120, 36);
            this.btnGetHistory.TabIndex = 8;
            this.btnGetHistory.Text = "Daj povijest";
            this.btnGetHistory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGetHistory.UseAccentColor = false;
            this.btnGetHistory.UseVisualStyleBackColor = true;
            this.btnGetHistory.Click += new System.EventHandler(this.btnGetHistory_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(258, 87);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(86, 20);
            this.txtFilter.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Filter:";
            // 
            // FrmVehicleStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 539);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnGetHistory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReservationHistory);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cboFilterType);
            this.Controls.Add(this.dgvVehicles);
            this.Name = "FrmVehicleStatus";
            this.Padding = new System.Windows.Forms.Padding(3, 55, 3, 3);
            this.Text = "Status vozila";
            this.Load += new System.EventHandler(this.FrmVehicleStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvVehicles;
        private ComboBox cboFilterType;
        private MaterialButton btnFilter;
        private MaterialButton btnShowAll;
        private DataGridView dgvReservationHistory;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaterialButton btnGetHistory;
        private TextBox txtFilter;
        private Label label4;
    }
}