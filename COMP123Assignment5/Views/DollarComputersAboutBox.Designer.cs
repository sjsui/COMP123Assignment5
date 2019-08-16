﻿namespace COMP123Assignment5.Views
{
    partial class DollarComputersAboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DollarComputersAboutBox));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.ProgrammerNameLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.WebsiteLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.ProgrammerNameLabel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.VersionLabel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.WebsiteLabel, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.ContactLabel, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 11);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(556, 326);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(4, 4);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(175, 318);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // ProgrammerNameLabel
            // 
            this.ProgrammerNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgrammerNameLabel.Location = new System.Drawing.Point(191, 0);
            this.ProgrammerNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.ProgrammerNameLabel.MaximumSize = new System.Drawing.Size(0, 21);
            this.ProgrammerNameLabel.Name = "ProgrammerNameLabel";
            this.ProgrammerNameLabel.Size = new System.Drawing.Size(361, 21);
            this.ProgrammerNameLabel.TabIndex = 19;
            this.ProgrammerNameLabel.Text = "Programmer Name: Shijun Sui";
            this.ProgrammerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VersionLabel
            // 
            this.VersionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VersionLabel.Location = new System.Drawing.Point(191, 32);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.VersionLabel.MaximumSize = new System.Drawing.Size(0, 21);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(361, 21);
            this.VersionLabel.TabIndex = 0;
            this.VersionLabel.Text = "Version: 1.0";
            this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WebsiteLabel
            // 
            this.WebsiteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebsiteLabel.Location = new System.Drawing.Point(191, 64);
            this.WebsiteLabel.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.WebsiteLabel.MaximumSize = new System.Drawing.Size(0, 21);
            this.WebsiteLabel.Name = "WebsiteLabel";
            this.WebsiteLabel.Size = new System.Drawing.Size(361, 21);
            this.WebsiteLabel.TabIndex = 21;
            this.WebsiteLabel.Text = "Website: https://github.com/sjsui/COMP123Assignment5";
            this.WebsiteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactLabel
            // 
            this.ContactLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactLabel.Location = new System.Drawing.Point(191, 96);
            this.ContactLabel.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.ContactLabel.MaximumSize = new System.Drawing.Size(0, 21);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(361, 21);
            this.ContactLabel.TabIndex = 22;
            this.ContactLabel.Text = "Contact: 6478747859";
            this.ContactLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(452, 295);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 27);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            // 
            // DollarComputersAboutBox
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 348);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DollarComputersAboutBox";
            this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About \"Dollar Computers\"";
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label ProgrammerNameLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label WebsiteLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Button okButton;
    }
}
