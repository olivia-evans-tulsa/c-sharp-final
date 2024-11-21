namespace oliviaEvansC_Final
{
    partial class Form1
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
            this.westCheckBox = new System.Windows.Forms.CheckBox();
            this.neCheckBox = new System.Windows.Forms.CheckBox();
            this.seCheckBox = new System.Windows.Forms.CheckBox();
            this.metroCheckBox = new System.Windows.Forms.CheckBox();
            this.campusGroupBox = new System.Windows.Forms.GroupBox();
            this.campusLabel = new System.Windows.Forms.Label();
            this.clearReportButton = new System.Windows.Forms.Button();
            this.offenseSelectCheckBox = new System.Windows.Forms.GroupBox();
            this.reportLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.year23CheckBox = new System.Windows.Forms.CheckBox();
            this.year21CheckBox = new System.Windows.Forms.CheckBox();
            this.year22CheckBox = new System.Windows.Forms.CheckBox();
            this.amtGroupBox = new System.Windows.Forms.GroupBox();
            this.clearAmtButton = new System.Windows.Forms.Button();
            this.amtLabel = new System.Windows.Forms.Label();
            this.equalRadio = new System.Windows.Forms.RadioButton();
            this.greaterThanRadio = new System.Windows.Forms.RadioButton();
            this.lessThanRadio = new System.Windows.Forms.RadioButton();
            this.amtTextbox = new System.Windows.Forms.TextBox();
            this.offenseListBox = new System.Windows.Forms.CheckedListBox();
            this.campusGroupBox.SuspendLayout();
            this.offenseSelectCheckBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.amtGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // westCheckBox
            // 
            this.westCheckBox.Location = new System.Drawing.Point(461, 36);
            this.westCheckBox.Name = "westCheckBox";
            this.westCheckBox.Size = new System.Drawing.Size(104, 53);
            this.westCheckBox.TabIndex = 6;
            this.westCheckBox.Text = "West";
            this.westCheckBox.UseVisualStyleBackColor = true;
            // 
            // neCheckBox
            // 
            this.neCheckBox.Location = new System.Drawing.Point(154, 36);
            this.neCheckBox.Name = "neCheckBox";
            this.neCheckBox.Size = new System.Drawing.Size(141, 53);
            this.neCheckBox.TabIndex = 7;
            this.neCheckBox.Text = "Northeast";
            this.neCheckBox.UseVisualStyleBackColor = true;
            // 
            // seCheckBox
            // 
            this.seCheckBox.Location = new System.Drawing.Point(308, 36);
            this.seCheckBox.Name = "seCheckBox";
            this.seCheckBox.Size = new System.Drawing.Size(129, 53);
            this.seCheckBox.TabIndex = 8;
            this.seCheckBox.Text = "Southeast";
            this.seCheckBox.UseVisualStyleBackColor = true;
            // 
            // metroCheckBox
            // 
            this.metroCheckBox.Location = new System.Drawing.Point(33, 36);
            this.metroCheckBox.Name = "metroCheckBox";
            this.metroCheckBox.Size = new System.Drawing.Size(79, 53);
            this.metroCheckBox.TabIndex = 9;
            this.metroCheckBox.Text = "Metro";
            this.metroCheckBox.UseVisualStyleBackColor = true;
            // 
            // campusGroupBox
            // 
            this.campusGroupBox.Controls.Add(this.campusLabel);
            this.campusGroupBox.Controls.Add(this.seCheckBox);
            this.campusGroupBox.Controls.Add(this.metroCheckBox);
            this.campusGroupBox.Controls.Add(this.westCheckBox);
            this.campusGroupBox.Controls.Add(this.neCheckBox);
            this.campusGroupBox.Location = new System.Drawing.Point(12, 274);
            this.campusGroupBox.Name = "campusGroupBox";
            this.campusGroupBox.Size = new System.Drawing.Size(571, 93);
            this.campusGroupBox.TabIndex = 10;
            this.campusGroupBox.TabStop = false;
            this.campusGroupBox.Text = "Campus";
            // 
            // campusLabel
            // 
            this.campusLabel.Location = new System.Drawing.Point(22, 22);
            this.campusLabel.Name = "campusLabel";
            this.campusLabel.Size = new System.Drawing.Size(363, 23);
            this.campusLabel.TabIndex = 11;
            this.campusLabel.Text = "Select at least one campus to search in.";
            // 
            // clearReportButton
            // 
            this.clearReportButton.Location = new System.Drawing.Point(221, 207);
            this.clearReportButton.Name = "clearReportButton";
            this.clearReportButton.Size = new System.Drawing.Size(152, 31);
            this.clearReportButton.TabIndex = 11;
            this.clearReportButton.Text = "Clear";
            this.clearReportButton.UseVisualStyleBackColor = true;
            this.clearReportButton.Click += new System.EventHandler(this.clearReportButton_Click);
            // 
            // offenseSelectCheckBox
            // 
            this.offenseSelectCheckBox.Controls.Add(this.offenseListBox);
            this.offenseSelectCheckBox.Controls.Add(this.reportLabel);
            this.offenseSelectCheckBox.Location = new System.Drawing.Point(12, 12);
            this.offenseSelectCheckBox.Name = "offenseSelectCheckBox";
            this.offenseSelectCheckBox.Size = new System.Drawing.Size(571, 237);
            this.offenseSelectCheckBox.TabIndex = 12;
            this.offenseSelectCheckBox.TabStop = false;
            this.offenseSelectCheckBox.Text = "Report Type";
            // 
            // reportLabel
            // 
            this.reportLabel.Location = new System.Drawing.Point(22, 22);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(378, 23);
            this.reportLabel.TabIndex = 12;
            this.reportLabel.Text = "Select at least one report type to search by.";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 683);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(152, 31);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // goButton
            // 
            this.goButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.goButton.Location = new System.Drawing.Point(222, 683);
            this.goButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(152, 31);
            this.goButton.TabIndex = 14;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(431, 683);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(152, 31);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yearLabel);
            this.groupBox1.Controls.Add(this.year23CheckBox);
            this.groupBox1.Controls.Add(this.year21CheckBox);
            this.groupBox1.Controls.Add(this.year22CheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 93);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Year";
            // 
            // yearLabel
            // 
            this.yearLabel.Location = new System.Drawing.Point(22, 17);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(406, 23);
            this.yearLabel.TabIndex = 10;
            this.yearLabel.Text = "Select at least one year to search in.";
            // 
            // year23CheckBox
            // 
            this.year23CheckBox.Checked = true;
            this.year23CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.year23CheckBox.Location = new System.Drawing.Point(377, 31);
            this.year23CheckBox.Name = "year23CheckBox";
            this.year23CheckBox.Size = new System.Drawing.Size(79, 53);
            this.year23CheckBox.TabIndex = 8;
            this.year23CheckBox.Text = "2023";
            this.year23CheckBox.UseVisualStyleBackColor = true;
            // 
            // year21CheckBox
            // 
            this.year21CheckBox.Checked = true;
            this.year21CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.year21CheckBox.Location = new System.Drawing.Point(109, 31);
            this.year21CheckBox.Name = "year21CheckBox";
            this.year21CheckBox.Size = new System.Drawing.Size(79, 53);
            this.year21CheckBox.TabIndex = 9;
            this.year21CheckBox.Text = "2021";
            this.year21CheckBox.UseVisualStyleBackColor = true;
            // 
            // year22CheckBox
            // 
            this.year22CheckBox.Checked = true;
            this.year22CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.year22CheckBox.Location = new System.Drawing.Point(246, 31);
            this.year22CheckBox.Name = "year22CheckBox";
            this.year22CheckBox.Size = new System.Drawing.Size(79, 53);
            this.year22CheckBox.TabIndex = 7;
            this.year22CheckBox.Text = "2022";
            this.year22CheckBox.UseVisualStyleBackColor = true;
            // 
            // amtGroupBox
            // 
            this.amtGroupBox.Controls.Add(this.clearAmtButton);
            this.amtGroupBox.Controls.Add(this.amtLabel);
            this.amtGroupBox.Controls.Add(this.equalRadio);
            this.amtGroupBox.Controls.Add(this.greaterThanRadio);
            this.amtGroupBox.Controls.Add(this.lessThanRadio);
            this.amtGroupBox.Controls.Add(this.amtTextbox);
            this.amtGroupBox.Location = new System.Drawing.Point(12, 506);
            this.amtGroupBox.Name = "amtGroupBox";
            this.amtGroupBox.Size = new System.Drawing.Size(571, 158);
            this.amtGroupBox.TabIndex = 16;
            this.amtGroupBox.TabStop = false;
            this.amtGroupBox.Text = "Amount";
            // 
            // clearAmtButton
            // 
            this.clearAmtButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearAmtButton.Location = new System.Drawing.Point(209, 115);
            this.clearAmtButton.Name = "clearAmtButton";
            this.clearAmtButton.Size = new System.Drawing.Size(152, 31);
            this.clearAmtButton.TabIndex = 12;
            this.clearAmtButton.Text = "Clear";
            this.clearAmtButton.UseVisualStyleBackColor = true;
            this.clearAmtButton.Click += new System.EventHandler(this.clearAmtButton_Click);
            // 
            // amtLabel
            // 
            this.amtLabel.Location = new System.Drawing.Point(22, 22);
            this.amtLabel.Name = "amtLabel";
            this.amtLabel.Size = new System.Drawing.Size(527, 49);
            this.amtLabel.TabIndex = 4;
            this.amtLabel.Text = "Optionally, select a symbol and enter a number to filter by amount of offenses re" +
    "corded.";
            // 
            // equalRadio
            // 
            this.equalRadio.AutoSize = true;
            this.equalRadio.Location = new System.Drawing.Point(241, 78);
            this.equalRadio.Name = "equalRadio";
            this.equalRadio.Size = new System.Drawing.Size(43, 24);
            this.equalRadio.TabIndex = 3;
            this.equalRadio.TabStop = true;
            this.equalRadio.Text = "=";
            this.equalRadio.UseVisualStyleBackColor = true;
            this.equalRadio.CheckedChanged += new System.EventHandler(this.equalRadio_CheckedChanged);
            // 
            // greaterThanRadio
            // 
            this.greaterThanRadio.AutoSize = true;
            this.greaterThanRadio.Location = new System.Drawing.Point(176, 78);
            this.greaterThanRadio.Name = "greaterThanRadio";
            this.greaterThanRadio.Size = new System.Drawing.Size(43, 24);
            this.greaterThanRadio.TabIndex = 2;
            this.greaterThanRadio.TabStop = true;
            this.greaterThanRadio.Text = ">";
            this.greaterThanRadio.UseVisualStyleBackColor = true;
            this.greaterThanRadio.CheckedChanged += new System.EventHandler(this.greaterThanRadio_CheckedChanged);
            // 
            // lessThanRadio
            // 
            this.lessThanRadio.AutoSize = true;
            this.lessThanRadio.Location = new System.Drawing.Point(107, 78);
            this.lessThanRadio.Name = "lessThanRadio";
            this.lessThanRadio.Size = new System.Drawing.Size(43, 24);
            this.lessThanRadio.TabIndex = 1;
            this.lessThanRadio.TabStop = true;
            this.lessThanRadio.Text = "<";
            this.lessThanRadio.UseVisualStyleBackColor = true;
            this.lessThanRadio.CheckedChanged += new System.EventHandler(this.lessThanRadio_CheckedChanged);
            // 
            // amtTextbox
            // 
            this.amtTextbox.Location = new System.Drawing.Point(315, 76);
            this.amtTextbox.Name = "amtTextbox";
            this.amtTextbox.Size = new System.Drawing.Size(153, 26);
            this.amtTextbox.TabIndex = 0;
            // 
            // offenseListBox
            // 
            this.offenseListBox.FormattingEnabled = true;
            this.offenseListBox.Items.AddRange(new object[] {
            "All",
            "Arson",
            "Robbery",
            "Motor Vehicle Theft",
            "Weapons Law Violation: Arrest",
            "(THESE ARE ALL SAMPLE VALUES)"});
            this.offenseListBox.Location = new System.Drawing.Point(67, 60);
            this.offenseListBox.Name = "offenseListBox";
            this.offenseListBox.Size = new System.Drawing.Size(437, 119);
            this.offenseListBox.TabIndex = 13;
            this.offenseListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.offenseListBox_ItemCheck);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(603, 739);
            this.Controls.Add(this.amtGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearReportButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.offenseSelectCheckBox);
            this.Controls.Add(this.campusGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "2023 TCC Police Report Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.campusGroupBox.ResumeLayout(false);
            this.offenseSelectCheckBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.amtGroupBox.ResumeLayout(false);
            this.amtGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox westCheckBox;
        private System.Windows.Forms.CheckBox neCheckBox;
        private System.Windows.Forms.CheckBox seCheckBox;
        private System.Windows.Forms.CheckBox metroCheckBox;
        private System.Windows.Forms.GroupBox campusGroupBox;
        private System.Windows.Forms.Button clearReportButton;
        private System.Windows.Forms.GroupBox offenseSelectCheckBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox year23CheckBox;
        private System.Windows.Forms.CheckBox year21CheckBox;
        private System.Windows.Forms.CheckBox year22CheckBox;
        private System.Windows.Forms.GroupBox amtGroupBox;
        private System.Windows.Forms.TextBox amtTextbox;
        private System.Windows.Forms.RadioButton equalRadio;
        private System.Windows.Forms.RadioButton greaterThanRadio;
        private System.Windows.Forms.RadioButton lessThanRadio;
        private System.Windows.Forms.Label amtLabel;
        private System.Windows.Forms.Label campusLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.Button clearAmtButton;
        private System.Windows.Forms.CheckedListBox offenseListBox;
    }
}

