
namespace AddressScraper
{
    partial class AddressScraperForm
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
            this.scrapeBtn = new System.Windows.Forms.Button();
            this.deliveryDropdown = new System.Windows.Forms.ComboBox();
            this.scrapeOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.stateDropdown = new System.Windows.Forms.ComboBox();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.keywordLabel = new System.Windows.Forms.Label();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.scrapeOptionsGroupBox.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrapeBtn
            // 
            this.scrapeBtn.Location = new System.Drawing.Point(331, 344);
            this.scrapeBtn.Name = "scrapeBtn";
            this.scrapeBtn.Size = new System.Drawing.Size(111, 36);
            this.scrapeBtn.TabIndex = 0;
            this.scrapeBtn.Text = "Scrape";
            this.scrapeBtn.UseVisualStyleBackColor = true;
            this.scrapeBtn.Click += new System.EventHandler(this.OnScrapeButtonClicked);
            // 
            // deliveryDropdown
            // 
            this.deliveryDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryDropdown.FormattingEnabled = true;
            this.deliveryDropdown.Items.AddRange(new object[] {
            "Global",
            "By State"});
            this.deliveryDropdown.Location = new System.Drawing.Point(89, 19);
            this.deliveryDropdown.Name = "deliveryDropdown";
            this.deliveryDropdown.Size = new System.Drawing.Size(121, 21);
            this.deliveryDropdown.TabIndex = 5;
            this.deliveryDropdown.SelectedValueChanged += new System.EventHandler(this.OnSelectedValueChanged);
            // 
            // scrapeOptionsGroupBox
            // 
            this.scrapeOptionsGroupBox.Controls.Add(this.stateLabel);
            this.scrapeOptionsGroupBox.Controls.Add(this.deliveryLabel);
            this.scrapeOptionsGroupBox.Controls.Add(this.stateDropdown);
            this.scrapeOptionsGroupBox.Controls.Add(this.deliveryDropdown);
            this.scrapeOptionsGroupBox.Location = new System.Drawing.Point(27, 29);
            this.scrapeOptionsGroupBox.Name = "scrapeOptionsGroupBox";
            this.scrapeOptionsGroupBox.Size = new System.Drawing.Size(227, 128);
            this.scrapeOptionsGroupBox.TabIndex = 6;
            this.scrapeOptionsGroupBox.TabStop = false;
            this.scrapeOptionsGroupBox.Text = "Scrape Options";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(17, 64);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(32, 13);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "State";
            this.stateLabel.Visible = false;
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Location = new System.Drawing.Point(17, 27);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(45, 13);
            this.deliveryLabel.TabIndex = 7;
            this.deliveryLabel.Text = "Delivery";
            // 
            // stateDropdown
            // 
            this.stateDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateDropdown.FormattingEnabled = true;
            this.stateDropdown.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.stateDropdown.Location = new System.Drawing.Point(89, 56);
            this.stateDropdown.Name = "stateDropdown";
            this.stateDropdown.Size = new System.Drawing.Size(121, 21);
            this.stateDropdown.TabIndex = 6;
            this.stateDropdown.Visible = false;
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Location = new System.Drawing.Point(151, 308);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(489, 20);
            this.keywordTextBox.TabIndex = 9;
            // 
            // keywordLabel
            // 
            this.keywordLabel.AutoSize = true;
            this.keywordLabel.Location = new System.Drawing.Point(148, 292);
            this.keywordLabel.Name = "keywordLabel";
            this.keywordLabel.Size = new System.Drawing.Size(132, 13);
            this.keywordLabel.TabIndex = 10;
            this.keywordLabel.Text = "Enter keywords or phrases";
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.resultsTextBox);
            this.resultsGroupBox.Location = new System.Drawing.Point(315, 29);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(459, 218);
            this.resultsGroupBox.TabIndex = 12;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(6, 19);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsTextBox.Size = new System.Drawing.Size(447, 193);
            this.resultsTextBox.TabIndex = 12;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(151, 344);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(489, 20);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 13;
            this.progressBar.Visible = false;
            // 
            // AddressScraperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 413);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.keywordLabel);
            this.Controls.Add(this.keywordTextBox);
            this.Controls.Add(this.scrapeOptionsGroupBox);
            this.Controls.Add(this.scrapeBtn);
            this.Name = "AddressScraperForm";
            this.Text = "Address Scraper";
            this.Load += new System.EventHandler(this.AddressScraperForm_Load);
            this.scrapeOptionsGroupBox.ResumeLayout(false);
            this.scrapeOptionsGroupBox.PerformLayout();
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scrapeBtn;
        private System.Windows.Forms.ComboBox deliveryDropdown;
        private System.Windows.Forms.GroupBox scrapeOptionsGroupBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.ComboBox stateDropdown;
        private System.Windows.Forms.TextBox keywordTextBox;
        private System.Windows.Forms.Label keywordLabel;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

