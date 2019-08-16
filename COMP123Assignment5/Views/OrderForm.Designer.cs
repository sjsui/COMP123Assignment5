namespace COMP123Assignment5.Views
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderFormTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OrderFormBasicInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderFormMemoryInfoLabel = new System.Windows.Forms.Label();
            this.OrderFormMemoryLabel = new System.Windows.Forms.Label();
            this.OrderFormOSInfoLabel = new System.Windows.Forms.Label();
            this.OrderFormOSLabel = new System.Windows.Forms.Label();
            this.OrderFormLCDSizeInfoLabel = new System.Windows.Forms.Label();
            this.OrderFormLCDSizeLabel = new System.Windows.Forms.Label();
            this.OrderFormModelInfoLabel = new System.Windows.Forms.Label();
            this.OrderFormModelLabel = new System.Windows.Forms.Label();
            this.OrderFormManufacturerInfoLabel = new System.Windows.Forms.Label();
            this.OrderFormManufacturerLabel = new System.Windows.Forms.Label();
            this.OrderFormPlatformInfoLabel = new System.Windows.Forms.Label();
            this.OrderFormPlatformLabel = new System.Windows.Forms.Label();
            this.OrderFormConditionInfoLabel = new System.Windows.Forms.Label();
            this.OrderFormConditionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrderFormPricingGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderFormFinishButton = new System.Windows.Forms.Button();
            this.OrderFormBackButton = new System.Windows.Forms.Button();
            this.OrderFormCancelButton = new System.Windows.Forms.Button();
            this.OrderFormTotalCostInfoLabel = new System.Windows.Forms.Label();
            this.OrderFormTotalCostLabel = new System.Windows.Forms.Label();
            this.OrderFormTaxInfoLabel = new System.Windows.Forms.Label();
            this.OrderFormTaxLabel = new System.Windows.Forms.Label();
            this.OrderFormCostInfoLabel = new System.Windows.Forms.Label();
            this.OrderFormCostLabel = new System.Windows.Forms.Label();
            this.OrderFormMenuStrip.SuspendLayout();
            this.OrderFormTableLayoutPanel.SuspendLayout();
            this.OrderFormBasicInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.OrderFormPricingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(800, 26);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitOrderForm);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(45, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.OrderFormBack);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // OrderFormTableLayoutPanel
            // 
            this.OrderFormTableLayoutPanel.ColumnCount = 2;
            this.OrderFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderFormTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderFormTableLayoutPanel.Controls.Add(this.OrderFormBasicInfoGroupBox, 0, 0);
            this.OrderFormTableLayoutPanel.Controls.Add(this.pictureBox1, 1, 0);
            this.OrderFormTableLayoutPanel.Controls.Add(this.OrderFormPricingGroupBox, 1, 1);
            this.OrderFormTableLayoutPanel.Location = new System.Drawing.Point(12, 31);
            this.OrderFormTableLayoutPanel.Name = "OrderFormTableLayoutPanel";
            this.OrderFormTableLayoutPanel.RowCount = 2;
            this.OrderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderFormTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OrderFormTableLayoutPanel.Size = new System.Drawing.Size(776, 407);
            this.OrderFormTableLayoutPanel.TabIndex = 1;
            // 
            // OrderFormBasicInfoGroupBox
            // 
            this.OrderFormBasicInfoGroupBox.Controls.Add(this.OrderFormMemoryInfoLabel);
            this.OrderFormBasicInfoGroupBox.Controls.Add(this.OrderFormMemoryLabel);
            this.OrderFormBasicInfoGroupBox.Controls.Add(this.OrderFormOSInfoLabel);
            this.OrderFormBasicInfoGroupBox.Controls.Add(this.OrderFormOSLabel);
            this.OrderFormBasicInfoGroupBox.Controls.Add(this.OrderFormLCDSizeInfoLabel);
            this.OrderFormBasicInfoGroupBox.Controls.Add(this.OrderFormLCDSizeLabel);
            this.OrderFormBasicInfoGroupBox.Controls.Add(this.OrderFormModelInfoLabel);
            this.OrderFormBasicInfoGroupBox.Controls.Add(this.OrderFormModelLabel);
            this.OrderFormBasicInfoGroupBox.Controls.Add(this.OrderFormManufacturerInfoLabel);
            this.OrderFormBasicInfoGroupBox.Controls.Add(this.OrderFormManufacturerLabel);
            this.OrderFormBasicInfoGroupBox.Controls.Add(this.OrderFormPlatformInfoLabel);
            this.OrderFormBasicInfoGroupBox.Controls.Add(this.OrderFormPlatformLabel);
            this.OrderFormBasicInfoGroupBox.Controls.Add(this.OrderFormConditionInfoLabel);
            this.OrderFormBasicInfoGroupBox.Controls.Add(this.OrderFormConditionLabel);
            this.OrderFormBasicInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormBasicInfoGroupBox.Location = new System.Drawing.Point(3, 3);
            this.OrderFormBasicInfoGroupBox.Name = "OrderFormBasicInfoGroupBox";
            this.OrderFormTableLayoutPanel.SetRowSpan(this.OrderFormBasicInfoGroupBox, 2);
            this.OrderFormBasicInfoGroupBox.Size = new System.Drawing.Size(382, 401);
            this.OrderFormBasicInfoGroupBox.TabIndex = 0;
            this.OrderFormBasicInfoGroupBox.TabStop = false;
            this.OrderFormBasicInfoGroupBox.Text = "Hardware Information";
            // 
            // OrderFormMemoryInfoLabel
            // 
            this.OrderFormMemoryInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormMemoryInfoLabel.Location = new System.Drawing.Point(123, 308);
            this.OrderFormMemoryInfoLabel.Name = "OrderFormMemoryInfoLabel";
            this.OrderFormMemoryInfoLabel.Size = new System.Drawing.Size(253, 51);
            this.OrderFormMemoryInfoLabel.TabIndex = 14;
            this.OrderFormMemoryInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderFormMemoryLabel
            // 
            this.OrderFormMemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormMemoryLabel.Location = new System.Drawing.Point(6, 308);
            this.OrderFormMemoryLabel.Name = "OrderFormMemoryLabel";
            this.OrderFormMemoryLabel.Size = new System.Drawing.Size(102, 51);
            this.OrderFormMemoryLabel.TabIndex = 13;
            this.OrderFormMemoryLabel.Text = "Memory: ";
            this.OrderFormMemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderFormOSInfoLabel
            // 
            this.OrderFormOSInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormOSInfoLabel.Location = new System.Drawing.Point(123, 264);
            this.OrderFormOSInfoLabel.Name = "OrderFormOSInfoLabel";
            this.OrderFormOSInfoLabel.Size = new System.Drawing.Size(253, 44);
            this.OrderFormOSInfoLabel.TabIndex = 12;
            this.OrderFormOSInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderFormOSLabel
            // 
            this.OrderFormOSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormOSLabel.Location = new System.Drawing.Point(6, 264);
            this.OrderFormOSLabel.Name = "OrderFormOSLabel";
            this.OrderFormOSLabel.Size = new System.Drawing.Size(102, 44);
            this.OrderFormOSLabel.TabIndex = 11;
            this.OrderFormOSLabel.Text = "OS: ";
            this.OrderFormOSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderFormLCDSizeInfoLabel
            // 
            this.OrderFormLCDSizeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormLCDSizeInfoLabel.Location = new System.Drawing.Point(123, 220);
            this.OrderFormLCDSizeInfoLabel.Name = "OrderFormLCDSizeInfoLabel";
            this.OrderFormLCDSizeInfoLabel.Size = new System.Drawing.Size(253, 44);
            this.OrderFormLCDSizeInfoLabel.TabIndex = 10;
            this.OrderFormLCDSizeInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderFormLCDSizeLabel
            // 
            this.OrderFormLCDSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormLCDSizeLabel.Location = new System.Drawing.Point(6, 220);
            this.OrderFormLCDSizeLabel.Name = "OrderFormLCDSizeLabel";
            this.OrderFormLCDSizeLabel.Size = new System.Drawing.Size(102, 44);
            this.OrderFormLCDSizeLabel.TabIndex = 9;
            this.OrderFormLCDSizeLabel.Text = "LCD Size: ";
            this.OrderFormLCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderFormModelInfoLabel
            // 
            this.OrderFormModelInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormModelInfoLabel.Location = new System.Drawing.Point(114, 176);
            this.OrderFormModelInfoLabel.Name = "OrderFormModelInfoLabel";
            this.OrderFormModelInfoLabel.Size = new System.Drawing.Size(262, 44);
            this.OrderFormModelInfoLabel.TabIndex = 8;
            this.OrderFormModelInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderFormModelLabel
            // 
            this.OrderFormModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormModelLabel.Location = new System.Drawing.Point(6, 176);
            this.OrderFormModelLabel.Name = "OrderFormModelLabel";
            this.OrderFormModelLabel.Size = new System.Drawing.Size(102, 44);
            this.OrderFormModelLabel.TabIndex = 7;
            this.OrderFormModelLabel.Text = "Model: ";
            this.OrderFormModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderFormManufacturerInfoLabel
            // 
            this.OrderFormManufacturerInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormManufacturerInfoLabel.Location = new System.Drawing.Point(123, 125);
            this.OrderFormManufacturerInfoLabel.Name = "OrderFormManufacturerInfoLabel";
            this.OrderFormManufacturerInfoLabel.Size = new System.Drawing.Size(253, 51);
            this.OrderFormManufacturerInfoLabel.TabIndex = 6;
            this.OrderFormManufacturerInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderFormManufacturerLabel
            // 
            this.OrderFormManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormManufacturerLabel.Location = new System.Drawing.Point(6, 125);
            this.OrderFormManufacturerLabel.Name = "OrderFormManufacturerLabel";
            this.OrderFormManufacturerLabel.Size = new System.Drawing.Size(102, 51);
            this.OrderFormManufacturerLabel.TabIndex = 5;
            this.OrderFormManufacturerLabel.Text = "Manufacturer: ";
            this.OrderFormManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderFormPlatformInfoLabel
            // 
            this.OrderFormPlatformInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormPlatformInfoLabel.Location = new System.Drawing.Point(114, 74);
            this.OrderFormPlatformInfoLabel.Name = "OrderFormPlatformInfoLabel";
            this.OrderFormPlatformInfoLabel.Size = new System.Drawing.Size(262, 51);
            this.OrderFormPlatformInfoLabel.TabIndex = 4;
            this.OrderFormPlatformInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OrderFormPlatformInfoLabel.UseWaitCursor = true;
            // 
            // OrderFormPlatformLabel
            // 
            this.OrderFormPlatformLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormPlatformLabel.Location = new System.Drawing.Point(6, 74);
            this.OrderFormPlatformLabel.Name = "OrderFormPlatformLabel";
            this.OrderFormPlatformLabel.Size = new System.Drawing.Size(102, 51);
            this.OrderFormPlatformLabel.TabIndex = 3;
            this.OrderFormPlatformLabel.Text = "Platform";
            this.OrderFormPlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OrderFormPlatformLabel.UseWaitCursor = true;
            // 
            // OrderFormConditionInfoLabel
            // 
            this.OrderFormConditionInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormConditionInfoLabel.Location = new System.Drawing.Point(114, 30);
            this.OrderFormConditionInfoLabel.Name = "OrderFormConditionInfoLabel";
            this.OrderFormConditionInfoLabel.Size = new System.Drawing.Size(262, 44);
            this.OrderFormConditionInfoLabel.TabIndex = 2;
            this.OrderFormConditionInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderFormConditionLabel
            // 
            this.OrderFormConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormConditionLabel.Location = new System.Drawing.Point(6, 30);
            this.OrderFormConditionLabel.Name = "OrderFormConditionLabel";
            this.OrderFormConditionLabel.Size = new System.Drawing.Size(102, 44);
            this.OrderFormConditionLabel.TabIndex = 1;
            this.OrderFormConditionLabel.Text = "Condition: ";
            this.OrderFormConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::COMP123Assignment5.Properties.Resources.computerpicture;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(391, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 197);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // OrderFormPricingGroupBox
            // 
            this.OrderFormPricingGroupBox.Controls.Add(this.OrderFormFinishButton);
            this.OrderFormPricingGroupBox.Controls.Add(this.OrderFormBackButton);
            this.OrderFormPricingGroupBox.Controls.Add(this.OrderFormCancelButton);
            this.OrderFormPricingGroupBox.Controls.Add(this.OrderFormTotalCostInfoLabel);
            this.OrderFormPricingGroupBox.Controls.Add(this.OrderFormTotalCostLabel);
            this.OrderFormPricingGroupBox.Controls.Add(this.OrderFormTaxInfoLabel);
            this.OrderFormPricingGroupBox.Controls.Add(this.OrderFormTaxLabel);
            this.OrderFormPricingGroupBox.Controls.Add(this.OrderFormCostInfoLabel);
            this.OrderFormPricingGroupBox.Controls.Add(this.OrderFormCostLabel);
            this.OrderFormPricingGroupBox.Location = new System.Drawing.Point(391, 206);
            this.OrderFormPricingGroupBox.Name = "OrderFormPricingGroupBox";
            this.OrderFormPricingGroupBox.Size = new System.Drawing.Size(382, 198);
            this.OrderFormPricingGroupBox.TabIndex = 2;
            this.OrderFormPricingGroupBox.TabStop = false;
            this.OrderFormPricingGroupBox.Text = "Pricing";
            // 
            // OrderFormFinishButton
            // 
            this.OrderFormFinishButton.BackColor = System.Drawing.Color.Aqua;
            this.OrderFormFinishButton.Location = new System.Drawing.Point(278, 43);
            this.OrderFormFinishButton.Name = "OrderFormFinishButton";
            this.OrderFormFinishButton.Size = new System.Drawing.Size(104, 41);
            this.OrderFormFinishButton.TabIndex = 14;
            this.OrderFormFinishButton.Text = "Finish";
            this.OrderFormFinishButton.UseVisualStyleBackColor = false;
            this.OrderFormFinishButton.Click += new System.EventHandler(this.OrderFormFinishButton_Click);
            // 
            // OrderFormBackButton
            // 
            this.OrderFormBackButton.Location = new System.Drawing.Point(278, 94);
            this.OrderFormBackButton.Name = "OrderFormBackButton";
            this.OrderFormBackButton.Size = new System.Drawing.Size(104, 41);
            this.OrderFormBackButton.TabIndex = 13;
            this.OrderFormBackButton.Text = "Back";
            this.OrderFormBackButton.UseVisualStyleBackColor = true;
            this.OrderFormBackButton.Click += new System.EventHandler(this.OrderFormBack);
            // 
            // OrderFormCancelButton
            // 
            this.OrderFormCancelButton.Location = new System.Drawing.Point(278, 151);
            this.OrderFormCancelButton.Name = "OrderFormCancelButton";
            this.OrderFormCancelButton.Size = new System.Drawing.Size(104, 41);
            this.OrderFormCancelButton.TabIndex = 12;
            this.OrderFormCancelButton.Text = "Cancel";
            this.OrderFormCancelButton.UseVisualStyleBackColor = true;
            this.OrderFormCancelButton.Click += new System.EventHandler(this.ExitOrderForm);
            // 
            // OrderFormTotalCostInfoLabel
            // 
            this.OrderFormTotalCostInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormTotalCostInfoLabel.Location = new System.Drawing.Point(113, 144);
            this.OrderFormTotalCostInfoLabel.Name = "OrderFormTotalCostInfoLabel";
            this.OrderFormTotalCostInfoLabel.Size = new System.Drawing.Size(102, 51);
            this.OrderFormTotalCostInfoLabel.TabIndex = 11;
            this.OrderFormTotalCostInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderFormTotalCostLabel
            // 
            this.OrderFormTotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormTotalCostLabel.Location = new System.Drawing.Point(6, 144);
            this.OrderFormTotalCostLabel.Name = "OrderFormTotalCostLabel";
            this.OrderFormTotalCostLabel.Size = new System.Drawing.Size(102, 51);
            this.OrderFormTotalCostLabel.TabIndex = 10;
            this.OrderFormTotalCostLabel.Text = "Total cost: ";
            this.OrderFormTotalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderFormTaxInfoLabel
            // 
            this.OrderFormTaxInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormTaxInfoLabel.Location = new System.Drawing.Point(114, 84);
            this.OrderFormTaxInfoLabel.Name = "OrderFormTaxInfoLabel";
            this.OrderFormTaxInfoLabel.Size = new System.Drawing.Size(102, 51);
            this.OrderFormTaxInfoLabel.TabIndex = 9;
            this.OrderFormTaxInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderFormTaxLabel
            // 
            this.OrderFormTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormTaxLabel.Location = new System.Drawing.Point(6, 84);
            this.OrderFormTaxLabel.Name = "OrderFormTaxLabel";
            this.OrderFormTaxLabel.Size = new System.Drawing.Size(102, 51);
            this.OrderFormTaxLabel.TabIndex = 8;
            this.OrderFormTaxLabel.Text = "Tax(13%): ";
            this.OrderFormTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderFormCostInfoLabel
            // 
            this.OrderFormCostInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormCostInfoLabel.Location = new System.Drawing.Point(113, 33);
            this.OrderFormCostInfoLabel.Name = "OrderFormCostInfoLabel";
            this.OrderFormCostInfoLabel.Size = new System.Drawing.Size(102, 51);
            this.OrderFormCostInfoLabel.TabIndex = 7;
            this.OrderFormCostInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderFormCostLabel
            // 
            this.OrderFormCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderFormCostLabel.Location = new System.Drawing.Point(6, 33);
            this.OrderFormCostLabel.Name = "OrderFormCostLabel";
            this.OrderFormCostLabel.Size = new System.Drawing.Size(102, 51);
            this.OrderFormCostLabel.TabIndex = 6;
            this.OrderFormCostLabel.Text = "Cost: ";
            this.OrderFormCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.OrderFormTableLayoutPanel);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.OrderFormTableLayoutPanel.ResumeLayout(false);
            this.OrderFormBasicInfoGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.OrderFormPricingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel OrderFormTableLayoutPanel;
        private System.Windows.Forms.GroupBox OrderFormBasicInfoGroupBox;
        private System.Windows.Forms.Label OrderFormConditionInfoLabel;
        private System.Windows.Forms.Label OrderFormConditionLabel;
        private System.Windows.Forms.Label OrderFormPlatformInfoLabel;
        private System.Windows.Forms.Label OrderFormPlatformLabel;
        private System.Windows.Forms.Label OrderFormManufacturerInfoLabel;
        private System.Windows.Forms.Label OrderFormManufacturerLabel;
        private System.Windows.Forms.Label OrderFormModelInfoLabel;
        private System.Windows.Forms.Label OrderFormModelLabel;
        private System.Windows.Forms.Label OrderFormLCDSizeInfoLabel;
        private System.Windows.Forms.Label OrderFormLCDSizeLabel;
        private System.Windows.Forms.Label OrderFormOSInfoLabel;
        private System.Windows.Forms.Label OrderFormOSLabel;
        private System.Windows.Forms.Label OrderFormMemoryInfoLabel;
        private System.Windows.Forms.Label OrderFormMemoryLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox OrderFormPricingGroupBox;
        private System.Windows.Forms.Label OrderFormTotalCostInfoLabel;
        private System.Windows.Forms.Label OrderFormTotalCostLabel;
        private System.Windows.Forms.Label OrderFormTaxInfoLabel;
        private System.Windows.Forms.Label OrderFormTaxLabel;
        private System.Windows.Forms.Label OrderFormCostInfoLabel;
        private System.Windows.Forms.Label OrderFormCostLabel;
        private System.Windows.Forms.Button OrderFormCancelButton;
        private System.Windows.Forms.Button OrderFormFinishButton;
        private System.Windows.Forms.Button OrderFormBackButton;
    }
}