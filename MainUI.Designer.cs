﻿namespace AoC_Image_to_Scenario_Converter
{
    partial class MainUI
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
            label1 = new Label();
            ModeSelectComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            GenButton = new Button();
            OutputDestination = new TextBox();
            Image2Selection = new TextBox();
            Image1Selection = new TextBox();
            Image1SelectionBrowse = new Button();
            Image2SelectionBrowse = new Button();
            OutputDestinationBrowse = new Button();
            PosterizationTrackBar = new TrackBar();
            label9 = new Label();
            label10 = new Label();
            File1SelectBox = new GroupBox();
            File2SelectBox = new GroupBox();
            AdvancedCitiesCheckbox = new CheckBox();
            PosterizationBox = new GroupBox();
            OutputDestinationBox = new GroupBox();
            progressBar1 = new ProgressBar();
            label5 = new Label();
            label6 = new Label();
            NameSelection = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PosterizationTrackBar).BeginInit();
            File1SelectBox.SuspendLayout();
            File2SelectBox.SuspendLayout();
            PosterizationBox.SuspendLayout();
            OutputDestinationBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(13, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Choose Mode: ";
            // 
            // ModeSelectComboBox
            // 
            ModeSelectComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ModeSelectComboBox.FormattingEnabled = true;
            ModeSelectComboBox.Items.AddRange(new object[] { "Basic", "Advanced", "Map Art" });
            ModeSelectComboBox.Location = new Point(150, 57);
            ModeSelectComboBox.Margin = new Padding(4, 3, 4, 3);
            ModeSelectComboBox.Name = "ModeSelectComboBox";
            ModeSelectComboBox.Size = new Size(140, 29);
            ModeSelectComboBox.TabIndex = 1;
            ModeSelectComboBox.SelectedIndexChanged += ModeSelectComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(14, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 16);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 111);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 3;
            label3.Text = " ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(18, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(352, 16);
            label4.TabIndex = 4;
            label4.Text = "Welcome to Corrupted Matt's Image to Scenario Converter";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(525, 15);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 584);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // GenButton
            // 
            GenButton.Enabled = false;
            GenButton.Location = new Point(13, 576);
            GenButton.Margin = new Padding(4, 3, 4, 3);
            GenButton.Name = "GenButton";
            GenButton.Size = new Size(88, 27);
            GenButton.TabIndex = 6;
            GenButton.Text = "Generate";
            GenButton.UseVisualStyleBackColor = true;
            GenButton.Click += GenButton_Click;
            // 
            // OutputDestination
            // 
            OutputDestination.AllowDrop = true;
            OutputDestination.Location = new Point(8, 22);
            OutputDestination.Margin = new Padding(4, 3, 4, 3);
            OutputDestination.Name = "OutputDestination";
            OutputDestination.Size = new Size(393, 23);
            OutputDestination.TabIndex = 7;
            // 
            // Image2Selection
            // 
            Image2Selection.AllowDrop = true;
            Image2Selection.Location = new Point(7, 22);
            Image2Selection.Margin = new Padding(4, 3, 4, 3);
            Image2Selection.Name = "Image2Selection";
            Image2Selection.Size = new Size(394, 23);
            Image2Selection.TabIndex = 8;
            // 
            // Image1Selection
            // 
            Image1Selection.AllowDrop = true;
            Image1Selection.Location = new Point(7, 22);
            Image1Selection.Margin = new Padding(4, 3, 4, 3);
            Image1Selection.Name = "Image1Selection";
            Image1Selection.Size = new Size(394, 23);
            Image1Selection.TabIndex = 9;
            // 
            // Image1SelectionBrowse
            // 
            Image1SelectionBrowse.Location = new Point(409, 22);
            Image1SelectionBrowse.Margin = new Padding(4, 3, 4, 3);
            Image1SelectionBrowse.Name = "Image1SelectionBrowse";
            Image1SelectionBrowse.Size = new Size(88, 27);
            Image1SelectionBrowse.TabIndex = 10;
            Image1SelectionBrowse.Text = "Browse";
            Image1SelectionBrowse.UseVisualStyleBackColor = true;
            Image1SelectionBrowse.Click += Image1SelectionBrowse_Click;
            // 
            // Image2SelectionBrowse
            // 
            Image2SelectionBrowse.Location = new Point(408, 22);
            Image2SelectionBrowse.Margin = new Padding(4, 3, 4, 3);
            Image2SelectionBrowse.Name = "Image2SelectionBrowse";
            Image2SelectionBrowse.Size = new Size(88, 27);
            Image2SelectionBrowse.TabIndex = 11;
            Image2SelectionBrowse.Text = "Browse";
            Image2SelectionBrowse.UseVisualStyleBackColor = true;
            Image2SelectionBrowse.Click += Image2SelectionBrowse_Click;
            // 
            // OutputDestinationBrowse
            // 
            OutputDestinationBrowse.Location = new Point(408, 22);
            OutputDestinationBrowse.Margin = new Padding(4, 3, 4, 3);
            OutputDestinationBrowse.Name = "OutputDestinationBrowse";
            OutputDestinationBrowse.Size = new Size(88, 27);
            OutputDestinationBrowse.TabIndex = 12;
            OutputDestinationBrowse.Text = "Browse";
            OutputDestinationBrowse.UseVisualStyleBackColor = true;
            OutputDestinationBrowse.Click += OutputDestinationBrowse_Click;
            // 
            // PosterizationTrackBar
            // 
            PosterizationTrackBar.LargeChange = 1;
            PosterizationTrackBar.Location = new Point(8, 15);
            PosterizationTrackBar.Margin = new Padding(4, 3, 4, 3);
            PosterizationTrackBar.Maximum = 7;
            PosterizationTrackBar.Name = "PosterizationTrackBar";
            PosterizationTrackBar.Size = new Size(492, 45);
            PosterizationTrackBar.TabIndex = 16;
            PosterizationTrackBar.Scroll += PosterizationTrackBar_Scroll;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 51);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 18;
            label9.Text = "Quality";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(422, 51);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 19;
            label10.Text = "Performance";
            // 
            // File1SelectBox
            // 
            File1SelectBox.Controls.Add(Image1SelectionBrowse);
            File1SelectBox.Controls.Add(Image1Selection);
            File1SelectBox.Location = new Point(13, 220);
            File1SelectBox.Margin = new Padding(4, 3, 4, 3);
            File1SelectBox.Name = "File1SelectBox";
            File1SelectBox.Padding = new Padding(4, 3, 4, 3);
            File1SelectBox.Size = new Size(504, 70);
            File1SelectBox.TabIndex = 20;
            File1SelectBox.TabStop = false;
            File1SelectBox.Text = "Choose File1";
            // 
            // File2SelectBox
            // 
            File2SelectBox.Controls.Add(AdvancedCitiesCheckbox);
            File2SelectBox.Controls.Add(Image2SelectionBrowse);
            File2SelectBox.Controls.Add(Image2Selection);
            File2SelectBox.Location = new Point(13, 310);
            File2SelectBox.Margin = new Padding(4, 3, 4, 3);
            File2SelectBox.Name = "File2SelectBox";
            File2SelectBox.Padding = new Padding(4, 3, 4, 3);
            File2SelectBox.Size = new Size(504, 90);
            File2SelectBox.TabIndex = 21;
            File2SelectBox.TabStop = false;
            File2SelectBox.Text = "Choose File2";
            // 
            // AdvancedCitiesCheckbox
            // 
            AdvancedCitiesCheckbox.AutoSize = true;
            AdvancedCitiesCheckbox.Location = new Point(7, 65);
            AdvancedCitiesCheckbox.Name = "AdvancedCitiesCheckbox";
            AdvancedCitiesCheckbox.Size = new Size(397, 19);
            AdvancedCitiesCheckbox.TabIndex = 28;
            AdvancedCitiesCheckbox.Text = "Reserve #FF0000 and #FFFF00 for cored and uncored cities respectively";
            AdvancedCitiesCheckbox.UseVisualStyleBackColor = true;
            // 
            // PosterizationBox
            // 
            PosterizationBox.Controls.Add(label10);
            PosterizationBox.Controls.Add(label9);
            PosterizationBox.Controls.Add(PosterizationTrackBar);
            PosterizationBox.Location = new Point(13, 129);
            PosterizationBox.Margin = new Padding(4, 3, 4, 3);
            PosterizationBox.Name = "PosterizationBox";
            PosterizationBox.Padding = new Padding(4, 3, 4, 3);
            PosterizationBox.Size = new Size(504, 69);
            PosterizationBox.TabIndex = 22;
            PosterizationBox.TabStop = false;
            PosterizationBox.Text = "Posterization";
            // 
            // OutputDestinationBox
            // 
            OutputDestinationBox.Controls.Add(OutputDestinationBrowse);
            OutputDestinationBox.Controls.Add(OutputDestination);
            OutputDestinationBox.Location = new Point(13, 420);
            OutputDestinationBox.Margin = new Padding(4, 3, 4, 3);
            OutputDestinationBox.Name = "OutputDestinationBox";
            OutputDestinationBox.Padding = new Padding(4, 3, 4, 3);
            OutputDestinationBox.Size = new Size(504, 69);
            OutputDestinationBox.TabIndex = 23;
            OutputDestinationBox.TabStop = false;
            OutputDestinationBox.Text = "Select Output Destiantion";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(108, 576);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(410, 23);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 24;
            progressBar1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 558);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 25;
            label5.Text = "Creating Countries";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(11, 510);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 16);
            label6.TabIndex = 26;
            label6.Text = "Senario Name:";
            // 
            // NameSelection
            // 
            NameSelection.Location = new Point(115, 503);
            NameSelection.Name = "NameSelection";
            NameSelection.Size = new Size(299, 23);
            NameSelection.TabIndex = 27;
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 611);
            Controls.Add(NameSelection);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(progressBar1);
            Controls.Add(OutputDestinationBox);
            Controls.Add(PosterizationBox);
            Controls.Add(File2SelectBox);
            Controls.Add(File1SelectBox);
            Controls.Add(GenButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ModeSelectComboBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MainUI";
            Text = "Image to Scenario Converter";
            Load += MainUI_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PosterizationTrackBar).EndInit();
            File1SelectBox.ResumeLayout(false);
            File1SelectBox.PerformLayout();
            File2SelectBox.ResumeLayout(false);
            File2SelectBox.PerformLayout();
            PosterizationBox.ResumeLayout(false);
            PosterizationBox.PerformLayout();
            OutputDestinationBox.ResumeLayout(false);
            OutputDestinationBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GenButton;
        public System.Windows.Forms.ComboBox ModeSelectComboBox;
        public System.Windows.Forms.TextBox OutputDestination;
        private System.Windows.Forms.Button Image1SelectionBrowse;
        private System.Windows.Forms.Button Image2SelectionBrowse;
        private System.Windows.Forms.Button OutputDestinationBrowse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox File1SelectBox;
        private System.Windows.Forms.GroupBox File2SelectBox;
        private System.Windows.Forms.GroupBox PosterizationBox;
        private System.Windows.Forms.GroupBox OutputDestinationBox;
        private ProgressBar progressBar1;
        private Label label5;
        public TextBox Image1Selection;
        public TrackBar PosterizationTrackBar;
        public TextBox Image2Selection;
        private Label label6;
        private TextBox NameSelection;
        private CheckBox AdvancedCitiesCheckbox;
    }
}
