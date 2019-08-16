namespace COMP123Assignment5.Views

{
    partial class StartForm
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
            this.StartFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LoadSavedOrderButton = new System.Windows.Forms.Button();
            this.StartFormPictureBox = new System.Windows.Forms.PictureBox();
            this.StartNewOrderButton = new System.Windows.Forms.Button();
            this.StartFormExitButton = new System.Windows.Forms.Button();
            this.StartFormTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartFormTableLayoutPanel
            // 
            this.StartFormTableLayoutPanel.ColumnCount = 2;
            this.StartFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StartFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StartFormTableLayoutPanel.Controls.Add(this.LoadSavedOrderButton, 1, 1);
            this.StartFormTableLayoutPanel.Controls.Add(this.StartFormPictureBox, 0, 0);
            this.StartFormTableLayoutPanel.Controls.Add(this.StartNewOrderButton, 0, 1);
            this.StartFormTableLayoutPanel.Controls.Add(this.StartFormExitButton, 1, 2);
            this.StartFormTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.StartFormTableLayoutPanel.Name = "StartFormTableLayoutPanel";
            this.StartFormTableLayoutPanel.RowCount = 3;
            this.StartFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.StartFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.StartFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.StartFormTableLayoutPanel.Size = new System.Drawing.Size(438, 529);
            this.StartFormTableLayoutPanel.TabIndex = 0;
            // 
            // LoadSavedOrderButton
            // 
            this.LoadSavedOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoadSavedOrderButton.Location = new System.Drawing.Point(222, 320);
            this.LoadSavedOrderButton.Name = "LoadSavedOrderButton";
            this.LoadSavedOrderButton.Size = new System.Drawing.Size(213, 99);
            this.LoadSavedOrderButton.TabIndex = 2;
            this.LoadSavedOrderButton.Text = "Load saved order";
            this.LoadSavedOrderButton.UseVisualStyleBackColor = true;
            this.LoadSavedOrderButton.Click += new System.EventHandler(this.LoadSavedOrderButton_Click);
            // 
            // StartFormPictureBox
            // 
            this.StartFormPictureBox.BackgroundImage = global::COMP123Assignment5.Properties.Resources.startformpic;
            this.StartFormPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartFormTableLayoutPanel.SetColumnSpan(this.StartFormPictureBox, 2);
            this.StartFormPictureBox.Location = new System.Drawing.Point(3, 3);
            this.StartFormPictureBox.Name = "StartFormPictureBox";
            this.StartFormPictureBox.Size = new System.Drawing.Size(432, 311);
            this.StartFormPictureBox.TabIndex = 0;
            this.StartFormPictureBox.TabStop = false;
            // 
            // StartNewOrderButton
            // 
            this.StartNewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartNewOrderButton.Location = new System.Drawing.Point(3, 320);
            this.StartNewOrderButton.Name = "StartNewOrderButton";
            this.StartNewOrderButton.Size = new System.Drawing.Size(213, 99);
            this.StartNewOrderButton.TabIndex = 1;
            this.StartNewOrderButton.Text = "Start new order";
            this.StartNewOrderButton.UseVisualStyleBackColor = true;
            this.StartNewOrderButton.Click += new System.EventHandler(this.StartNewOrderButton_Click);
            // 
            // StartFormExitButton
            // 
            this.StartFormExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartFormExitButton.Location = new System.Drawing.Point(222, 425);
            this.StartFormExitButton.Name = "StartFormExitButton";
            this.StartFormExitButton.Size = new System.Drawing.Size(213, 99);
            this.StartFormExitButton.TabIndex = 3;
            this.StartFormExitButton.Text = "Exit";
            this.StartFormExitButton.UseVisualStyleBackColor = true;
            this.StartFormExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 553);
            this.ControlBox = false;
            this.Controls.Add(this.StartFormTableLayoutPanel);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.StartFormTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StartFormPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel StartFormTableLayoutPanel;
        private System.Windows.Forms.PictureBox StartFormPictureBox;
        private System.Windows.Forms.Button LoadSavedOrderButton;
        private System.Windows.Forms.Button StartNewOrderButton;
        private System.Windows.Forms.Button StartFormExitButton;
    }
}

