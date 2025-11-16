namespace AoC_Image_to_Scenario_Converter
{
    partial class V4UI
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V4UI));
            ModeSelect = new TabControl();
            BasicTab = new TabPage();
            label2 = new Label();
            BMselect1box = new GroupBox();
            BMbrowse1 = new Button();
            BMselection1 = new TextBox();
            AdvancedTab = new TabPage();
            AMsettingsbox = new GroupBox();
            FlagsCheckbox = new CheckBox();
            OccupationsCheckbox = new CheckBox();
            AdvancedCitiesCheckbox = new CheckBox();
            CapitalsChackbox = new CheckBox();
            AMselect3box = new GroupBox();
            AMbrowse3 = new Button();
            AMselection3 = new TextBox();
            AMselect2box = new GroupBox();
            AMbrowse2 = new Button();
            AMselection2 = new TextBox();
            label3 = new Label();
            AMselect1box = new GroupBox();
            AMbrowse1 = new Button();
            AMselection1 = new TextBox();
            TerrainSwapTab = new TabPage();
            TSselect2box = new GroupBox();
            TSbrowse2 = new Button();
            TSselection2 = new TextBox();
            label4 = new Label();
            TSselect1box = new GroupBox();
            TSbrowse1 = new Button();
            TSselection1 = new TextBox();
            MapArtTab = new TabPage();
            PosterizationBox = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            PosterizationTrackBar = new TrackBar();
            PosterizationPreviewButton = new Button();
            PosterizationPreviewBox = new PictureBox();
            label5 = new Label();
            MAselect1box = new GroupBox();
            MAbrowse1 = new Button();
            MAselection1 = new TextBox();
            HelpButton = new Button();
            GenerateButton = new Button();
            DestinationInput = new TextBox();
            DestinationBrowse = new Button();
            label1 = new Label();
            ProgressBar = new ProgressBar();
            ProgressLabel = new Label();
            NameSelection = new TextBox();
            label6 = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            ModeSelect.SuspendLayout();
            BasicTab.SuspendLayout();
            BMselect1box.SuspendLayout();
            AdvancedTab.SuspendLayout();
            AMsettingsbox.SuspendLayout();
            AMselect3box.SuspendLayout();
            AMselect2box.SuspendLayout();
            AMselect1box.SuspendLayout();
            TerrainSwapTab.SuspendLayout();
            TSselect2box.SuspendLayout();
            TSselect1box.SuspendLayout();
            MapArtTab.SuspendLayout();
            PosterizationBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PosterizationTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PosterizationPreviewBox).BeginInit();
            MAselect1box.SuspendLayout();
            SuspendLayout();
            // 
            // ModeSelect
            // 
            ModeSelect.Controls.Add(BasicTab);
            ModeSelect.Controls.Add(AdvancedTab);
            ModeSelect.Controls.Add(TerrainSwapTab);
            ModeSelect.Controls.Add(MapArtTab);
            ModeSelect.Font = new Font("Segoe UI", 9.75F);
            ModeSelect.ItemSize = new Size(100, 25);
            ModeSelect.Location = new Point(0, 0);
            ModeSelect.Margin = new Padding(0);
            ModeSelect.Name = "ModeSelect";
            ModeSelect.SelectedIndex = 0;
            ModeSelect.Size = new Size(785, 340);
            ModeSelect.SizeMode = TabSizeMode.Fixed;
            ModeSelect.TabIndex = 0;
            // 
            // BasicTab
            // 
            BasicTab.Controls.Add(label2);
            BasicTab.Controls.Add(BMselect1box);
            BasicTab.Location = new Point(4, 29);
            BasicTab.Margin = new Padding(0);
            BasicTab.Name = "BasicTab";
            BasicTab.Size = new Size(777, 307);
            BasicTab.TabIndex = 0;
            BasicTab.Text = "Basic";
            BasicTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(508, 34);
            label2.TabIndex = 22;
            label2.Text = "Uses single image with default AoC terrain color-coding to create an empty scenario. \r\nMost useful for bypassing map size limit.";
            // 
            // BMselect1box
            // 
            BMselect1box.Controls.Add(BMbrowse1);
            BMselect1box.Controls.Add(BMselection1);
            BMselect1box.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BMselect1box.Location = new Point(10, 70);
            BMselect1box.Margin = new Padding(4, 3, 4, 3);
            BMselect1box.Name = "BMselect1box";
            BMselect1box.Padding = new Padding(4, 3, 4, 3);
            BMselect1box.Size = new Size(500, 60);
            BMselect1box.TabIndex = 21;
            BMselect1box.TabStop = false;
            BMselect1box.Text = "Choose Terrain Map";
            // 
            // BMbrowse1
            // 
            BMbrowse1.Location = new Point(404, 23);
            BMbrowse1.Margin = new Padding(4, 3, 4, 3);
            BMbrowse1.Name = "BMbrowse1";
            BMbrowse1.Size = new Size(88, 27);
            BMbrowse1.TabIndex = 10;
            BMbrowse1.Text = "Browse";
            BMbrowse1.UseVisualStyleBackColor = true;
            // 
            // BMselection1
            // 
            BMselection1.AllowDrop = true;
            BMselection1.BackColor = SystemColors.Window;
            BMselection1.Location = new Point(8, 25);
            BMselection1.Margin = new Padding(4, 3, 4, 3);
            BMselection1.Name = "BMselection1";
            BMselection1.Size = new Size(391, 25);
            BMselection1.TabIndex = 9;
            // 
            // AdvancedTab
            // 
            AdvancedTab.Controls.Add(AMsettingsbox);
            AdvancedTab.Controls.Add(AMselect3box);
            AdvancedTab.Controls.Add(AMselect2box);
            AdvancedTab.Controls.Add(label3);
            AdvancedTab.Controls.Add(AMselect1box);
            AdvancedTab.Location = new Point(4, 29);
            AdvancedTab.Name = "AdvancedTab";
            AdvancedTab.Padding = new Padding(3);
            AdvancedTab.Size = new Size(777, 307);
            AdvancedTab.TabIndex = 1;
            AdvancedTab.Text = "Advanced";
            AdvancedTab.UseVisualStyleBackColor = true;
            // 
            // AMsettingsbox
            // 
            AMsettingsbox.Controls.Add(FlagsCheckbox);
            AMsettingsbox.Controls.Add(OccupationsCheckbox);
            AMsettingsbox.Controls.Add(AdvancedCitiesCheckbox);
            AMsettingsbox.Controls.Add(CapitalsChackbox);
            AMsettingsbox.Location = new Point(530, 70);
            AMsettingsbox.Name = "AMsettingsbox";
            AMsettingsbox.Size = new Size(238, 140);
            AMsettingsbox.TabIndex = 30;
            AMsettingsbox.TabStop = false;
            AMsettingsbox.Text = "Additional Settings";
            // 
            // FlagsCheckbox
            // 
            FlagsCheckbox.AutoSize = true;
            FlagsCheckbox.Location = new Point(6, 104);
            FlagsCheckbox.Name = "FlagsCheckbox";
            FlagsCheckbox.Size = new Size(99, 21);
            FlagsCheckbox.TabIndex = 32;
            FlagsCheckbox.Text = "Create Flags";
            FlagsCheckbox.UseVisualStyleBackColor = true;
            // 
            // OccupationsCheckbox
            // 
            OccupationsCheckbox.AutoSize = true;
            OccupationsCheckbox.Location = new Point(6, 77);
            OccupationsCheckbox.Name = "OccupationsCheckbox";
            OccupationsCheckbox.Size = new Size(99, 21);
            OccupationsCheckbox.TabIndex = 31;
            OccupationsCheckbox.Text = "Occupations";
            OccupationsCheckbox.UseVisualStyleBackColor = true;
            // 
            // AdvancedCitiesCheckbox
            // 
            AdvancedCitiesCheckbox.AutoSize = true;
            AdvancedCitiesCheckbox.Enabled = false;
            AdvancedCitiesCheckbox.Location = new Point(6, 50);
            AdvancedCitiesCheckbox.Name = "AdvancedCitiesCheckbox";
            AdvancedCitiesCheckbox.Size = new Size(95, 21);
            AdvancedCitiesCheckbox.TabIndex = 31;
            AdvancedCitiesCheckbox.Text = "Other Cities";
            AdvancedCitiesCheckbox.UseVisualStyleBackColor = true;
            // 
            // CapitalsChackbox
            // 
            CapitalsChackbox.AutoSize = true;
            CapitalsChackbox.Location = new Point(6, 23);
            CapitalsChackbox.Name = "CapitalsChackbox";
            CapitalsChackbox.Size = new Size(73, 21);
            CapitalsChackbox.TabIndex = 31;
            CapitalsChackbox.Text = "Capitals";
            CapitalsChackbox.UseVisualStyleBackColor = true;
            // 
            // AMselect3box
            // 
            AMselect3box.Controls.Add(AMbrowse3);
            AMselect3box.Controls.Add(AMselection3);
            AMselect3box.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AMselect3box.Location = new Point(10, 230);
            AMselect3box.Margin = new Padding(4, 3, 4, 3);
            AMselect3box.Name = "AMselect3box";
            AMselect3box.Padding = new Padding(4, 3, 4, 3);
            AMselect3box.Size = new Size(500, 60);
            AMselect3box.TabIndex = 29;
            AMselect3box.TabStop = false;
            AMselect3box.Text = "Choose De Jure Political Map";
            AMselect3box.Visible = false;
            // 
            // AMbrowse3
            // 
            AMbrowse3.Location = new Point(404, 23);
            AMbrowse3.Margin = new Padding(4, 3, 4, 3);
            AMbrowse3.Name = "AMbrowse3";
            AMbrowse3.Size = new Size(88, 27);
            AMbrowse3.TabIndex = 10;
            AMbrowse3.Text = "Browse";
            AMbrowse3.UseVisualStyleBackColor = true;
            // 
            // AMselection3
            // 
            AMselection3.AllowDrop = true;
            AMselection3.Location = new Point(8, 25);
            AMselection3.Margin = new Padding(4, 3, 4, 3);
            AMselection3.Name = "AMselection3";
            AMselection3.Size = new Size(391, 25);
            AMselection3.TabIndex = 9;
            // 
            // AMselect2box
            // 
            AMselect2box.Controls.Add(AMbrowse2);
            AMselect2box.Controls.Add(AMselection2);
            AMselect2box.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AMselect2box.Location = new Point(10, 150);
            AMselect2box.Margin = new Padding(4, 3, 4, 3);
            AMselect2box.Name = "AMselect2box";
            AMselect2box.Padding = new Padding(4, 3, 4, 3);
            AMselect2box.Size = new Size(500, 60);
            AMselect2box.TabIndex = 28;
            AMselect2box.TabStop = false;
            AMselect2box.Text = "Choose Political Map";
            // 
            // AMbrowse2
            // 
            AMbrowse2.Location = new Point(404, 23);
            AMbrowse2.Margin = new Padding(4, 3, 4, 3);
            AMbrowse2.Name = "AMbrowse2";
            AMbrowse2.Size = new Size(88, 27);
            AMbrowse2.TabIndex = 10;
            AMbrowse2.Text = "Browse";
            AMbrowse2.UseVisualStyleBackColor = true;
            // 
            // AMselection2
            // 
            AMselection2.AllowDrop = true;
            AMselection2.Location = new Point(8, 25);
            AMselection2.Margin = new Padding(4, 3, 4, 3);
            AMselection2.Name = "AMselection2";
            AMselection2.Size = new Size(391, 25);
            AMselection2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 10);
            label3.Name = "label3";
            label3.Size = new Size(676, 51);
            label3.TabIndex = 27;
            label3.Text = resources.GetString("label3.Text");
            // 
            // AMselect1box
            // 
            AMselect1box.Controls.Add(AMbrowse1);
            AMselect1box.Controls.Add(AMselection1);
            AMselect1box.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AMselect1box.Location = new Point(10, 70);
            AMselect1box.Margin = new Padding(4, 3, 4, 3);
            AMselect1box.Name = "AMselect1box";
            AMselect1box.Padding = new Padding(4, 3, 4, 3);
            AMselect1box.Size = new Size(500, 60);
            AMselect1box.TabIndex = 26;
            AMselect1box.TabStop = false;
            AMselect1box.Text = "Choose Terrain Map";
            // 
            // AMbrowse1
            // 
            AMbrowse1.Location = new Point(404, 23);
            AMbrowse1.Margin = new Padding(4, 3, 4, 3);
            AMbrowse1.Name = "AMbrowse1";
            AMbrowse1.Size = new Size(88, 27);
            AMbrowse1.TabIndex = 10;
            AMbrowse1.Text = "Browse";
            AMbrowse1.UseVisualStyleBackColor = true;
            // 
            // AMselection1
            // 
            AMselection1.AllowDrop = true;
            AMselection1.Location = new Point(8, 25);
            AMselection1.Margin = new Padding(4, 3, 4, 3);
            AMselection1.Name = "AMselection1";
            AMselection1.Size = new Size(391, 25);
            AMselection1.TabIndex = 9;
            // 
            // TerrainSwapTab
            // 
            TerrainSwapTab.Controls.Add(TSselect2box);
            TerrainSwapTab.Controls.Add(label4);
            TerrainSwapTab.Controls.Add(TSselect1box);
            TerrainSwapTab.Location = new Point(4, 29);
            TerrainSwapTab.Name = "TerrainSwapTab";
            TerrainSwapTab.Size = new Size(777, 307);
            TerrainSwapTab.TabIndex = 2;
            TerrainSwapTab.Text = "Terrain Swap";
            TerrainSwapTab.UseVisualStyleBackColor = true;
            // 
            // TSselect2box
            // 
            TSselect2box.Controls.Add(TSbrowse2);
            TSselect2box.Controls.Add(TSselection2);
            TSselect2box.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TSselect2box.Location = new Point(10, 150);
            TSselect2box.Margin = new Padding(4, 3, 4, 3);
            TSselect2box.Name = "TSselect2box";
            TSselect2box.Padding = new Padding(4, 3, 4, 3);
            TSselect2box.Size = new Size(500, 60);
            TSselect2box.TabIndex = 32;
            TSselect2box.TabStop = false;
            TSselect2box.Text = "Choose Target Scenario";
            // 
            // TSbrowse2
            // 
            TSbrowse2.Location = new Point(404, 23);
            TSbrowse2.Margin = new Padding(4, 3, 4, 3);
            TSbrowse2.Name = "TSbrowse2";
            TSbrowse2.Size = new Size(88, 27);
            TSbrowse2.TabIndex = 10;
            TSbrowse2.Text = "Browse";
            TSbrowse2.UseVisualStyleBackColor = true;
            // 
            // TSselection2
            // 
            TSselection2.AllowDrop = true;
            TSselection2.Location = new Point(8, 25);
            TSselection2.Margin = new Padding(4, 3, 4, 3);
            TSselection2.Name = "TSselection2";
            TSselection2.Size = new Size(391, 25);
            TSselection2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 10);
            label4.Name = "label4";
            label4.Size = new Size(396, 34);
            label4.TabIndex = 31;
            label4.Text = "Uses a map image and to change terrain in a preexisting scenario.\r\nMost useful for updating terrain in multiple versions of a scenario.";
            // 
            // TSselect1box
            // 
            TSselect1box.Controls.Add(TSbrowse1);
            TSselect1box.Controls.Add(TSselection1);
            TSselect1box.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TSselect1box.Location = new Point(10, 70);
            TSselect1box.Margin = new Padding(4, 3, 4, 3);
            TSselect1box.Name = "TSselect1box";
            TSselect1box.Padding = new Padding(4, 3, 4, 3);
            TSselect1box.Size = new Size(500, 60);
            TSselect1box.TabIndex = 30;
            TSselect1box.TabStop = false;
            TSselect1box.Text = "Choose New Terrain Map";
            // 
            // TSbrowse1
            // 
            TSbrowse1.Location = new Point(404, 23);
            TSbrowse1.Margin = new Padding(4, 3, 4, 3);
            TSbrowse1.Name = "TSbrowse1";
            TSbrowse1.Size = new Size(88, 27);
            TSbrowse1.TabIndex = 10;
            TSbrowse1.Text = "Browse";
            TSbrowse1.UseVisualStyleBackColor = true;
            // 
            // TSselection1
            // 
            TSselection1.AllowDrop = true;
            TSselection1.Location = new Point(8, 25);
            TSselection1.Margin = new Padding(4, 3, 4, 3);
            TSselection1.Name = "TSselection1";
            TSselection1.Size = new Size(391, 25);
            TSselection1.TabIndex = 9;
            // 
            // MapArtTab
            // 
            MapArtTab.Controls.Add(PosterizationBox);
            MapArtTab.Controls.Add(PosterizationPreviewButton);
            MapArtTab.Controls.Add(PosterizationPreviewBox);
            MapArtTab.Controls.Add(label5);
            MapArtTab.Controls.Add(MAselect1box);
            MapArtTab.Location = new Point(4, 29);
            MapArtTab.Name = "MapArtTab";
            MapArtTab.Size = new Size(777, 307);
            MapArtTab.TabIndex = 3;
            MapArtTab.Text = "Map Art";
            MapArtTab.UseVisualStyleBackColor = true;
            // 
            // PosterizationBox
            // 
            PosterizationBox.Controls.Add(label10);
            PosterizationBox.Controls.Add(label9);
            PosterizationBox.Controls.Add(PosterizationTrackBar);
            PosterizationBox.Location = new Point(10, 150);
            PosterizationBox.Margin = new Padding(4, 3, 4, 3);
            PosterizationBox.Name = "PosterizationBox";
            PosterizationBox.Padding = new Padding(4, 3, 4, 3);
            PosterizationBox.Size = new Size(500, 95);
            PosterizationBox.TabIndex = 35;
            PosterizationBox.TabStop = false;
            PosterizationBox.Text = "Posterization";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(410, 70);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(82, 17);
            label10.TabIndex = 19;
            label10.Text = "Performance";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 70);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(48, 17);
            label9.TabIndex = 18;
            label9.Text = "Quality";
            // 
            // PosterizationTrackBar
            // 
            PosterizationTrackBar.LargeChange = 1;
            PosterizationTrackBar.Location = new Point(5, 22);
            PosterizationTrackBar.Margin = new Padding(4, 3, 4, 3);
            PosterizationTrackBar.Maximum = 7;
            PosterizationTrackBar.Name = "PosterizationTrackBar";
            PosterizationTrackBar.Size = new Size(490, 45);
            PosterizationTrackBar.TabIndex = 16;
            // 
            // PosterizationPreviewButton
            // 
            PosterizationPreviewButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PosterizationPreviewButton.Location = new Point(525, 15);
            PosterizationPreviewButton.Name = "PosterizationPreviewButton";
            PosterizationPreviewButton.Size = new Size(240, 280);
            PosterizationPreviewButton.TabIndex = 34;
            PosterizationPreviewButton.Text = "Generate posterization preview";
            PosterizationPreviewButton.UseVisualStyleBackColor = true;
            PosterizationPreviewButton.Visible = false;
            // 
            // PosterizationPreviewBox
            // 
            PosterizationPreviewBox.InitialImage = null;
            PosterizationPreviewBox.Location = new Point(520, 10);
            PosterizationPreviewBox.Margin = new Padding(4, 3, 4, 3);
            PosterizationPreviewBox.Name = "PosterizationPreviewBox";
            PosterizationPreviewBox.Size = new Size(250, 290);
            PosterizationPreviewBox.SizeMode = PictureBoxSizeMode.Zoom;
            PosterizationPreviewBox.TabIndex = 30;
            PosterizationPreviewBox.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 10);
            label5.Name = "label5";
            label5.Size = new Size(349, 51);
            label5.TabIndex = 33;
            label5.Text = "Recreates any image in game by placing nations \r\nof corresponding colors on a blank map.\r\n...I really can't come up with a good use case for this one...";
            // 
            // MAselect1box
            // 
            MAselect1box.Controls.Add(MAbrowse1);
            MAselect1box.Controls.Add(MAselection1);
            MAselect1box.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            MAselect1box.Location = new Point(10, 70);
            MAselect1box.Margin = new Padding(4, 3, 4, 3);
            MAselect1box.Name = "MAselect1box";
            MAselect1box.Padding = new Padding(4, 3, 4, 3);
            MAselect1box.Size = new Size(500, 60);
            MAselect1box.TabIndex = 32;
            MAselect1box.TabStop = false;
            MAselect1box.Text = "Choose Image";
            // 
            // MAbrowse1
            // 
            MAbrowse1.Location = new Point(404, 23);
            MAbrowse1.Margin = new Padding(4, 3, 4, 3);
            MAbrowse1.Name = "MAbrowse1";
            MAbrowse1.Size = new Size(88, 27);
            MAbrowse1.TabIndex = 10;
            MAbrowse1.Text = "Browse";
            MAbrowse1.UseVisualStyleBackColor = true;
            // 
            // MAselection1
            // 
            MAselection1.AllowDrop = true;
            MAselection1.Location = new Point(8, 25);
            MAselection1.Margin = new Padding(4, 3, 4, 3);
            MAselection1.Name = "MAselection1";
            MAselection1.Size = new Size(391, 25);
            MAselection1.TabIndex = 9;
            // 
            // HelpButton
            // 
            HelpButton.Font = new Font("Segoe UI", 9.75F);
            HelpButton.Location = new Point(672, 395);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(100, 25);
            HelpButton.TabIndex = 1;
            HelpButton.Text = "Help";
            HelpButton.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            GenerateButton.Font = new Font("Segoe UI", 9.75F);
            GenerateButton.Location = new Point(672, 424);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(100, 25);
            GenerateButton.TabIndex = 2;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // DestinationInput
            // 
            DestinationInput.Location = new Point(12, 366);
            DestinationInput.Margin = new Padding(4, 3, 4, 3);
            DestinationInput.Name = "DestinationInput";
            DestinationInput.Size = new Size(401, 23);
            DestinationInput.TabIndex = 7;
            // 
            // DestinationBrowse
            // 
            DestinationBrowse.Font = new Font("Segoe UI", 9.75F);
            DestinationBrowse.Location = new Point(418, 362);
            DestinationBrowse.Margin = new Padding(4, 3, 4, 3);
            DestinationBrowse.Name = "DestinationBrowse";
            DestinationBrowse.Size = new Size(88, 27);
            DestinationBrowse.TabIndex = 12;
            DestinationBrowse.Text = "Browse";
            DestinationBrowse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(14, 346);
            label1.Name = "label1";
            label1.Size = new Size(155, 17);
            label1.TabIndex = 0;
            label1.Text = "Select Output Destiantion";
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(12, 426);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(652, 23);
            ProgressBar.Style = ProgressBarStyle.Continuous;
            ProgressBar.TabIndex = 24;
            ProgressBar.Visible = false;
            // 
            // ProgressLabel
            // 
            ProgressLabel.AutoSize = true;
            ProgressLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ProgressLabel.Location = new Point(12, 406);
            ProgressLabel.Name = "ProgressLabel";
            ProgressLabel.Size = new Size(116, 17);
            ProgressLabel.TabIndex = 25;
            ProgressLabel.Text = "Creating Countries";
            ProgressLabel.Visible = false;
            // 
            // NameSelection
            // 
            NameSelection.Location = new Point(513, 366);
            NameSelection.Name = "NameSelection";
            NameSelection.Size = new Size(259, 23);
            NameSelection.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(513, 347);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 16);
            label6.TabIndex = 29;
            label6.Text = "Scenario Name:";
            // 
            // toolTip1
            // 
            toolTip1.UseAnimation = false;
            toolTip1.UseFading = false;
            // 
            // V4UI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(label6);
            Controls.Add(NameSelection);
            Controls.Add(label1);
            Controls.Add(DestinationBrowse);
            Controls.Add(GenerateButton);
            Controls.Add(DestinationInput);
            Controls.Add(HelpButton);
            Controls.Add(ProgressLabel);
            Controls.Add(ModeSelect);
            Controls.Add(ProgressBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "V4UI";
            Text = "Image to Scenario Converter v4.0.0";
            Load += V4UI_Load;
            ModeSelect.ResumeLayout(false);
            BasicTab.ResumeLayout(false);
            BasicTab.PerformLayout();
            BMselect1box.ResumeLayout(false);
            BMselect1box.PerformLayout();
            AdvancedTab.ResumeLayout(false);
            AdvancedTab.PerformLayout();
            AMsettingsbox.ResumeLayout(false);
            AMsettingsbox.PerformLayout();
            AMselect3box.ResumeLayout(false);
            AMselect3box.PerformLayout();
            AMselect2box.ResumeLayout(false);
            AMselect2box.PerformLayout();
            AMselect1box.ResumeLayout(false);
            AMselect1box.PerformLayout();
            TerrainSwapTab.ResumeLayout(false);
            TerrainSwapTab.PerformLayout();
            TSselect2box.ResumeLayout(false);
            TSselect2box.PerformLayout();
            TSselect1box.ResumeLayout(false);
            TSselect1box.PerformLayout();
            MapArtTab.ResumeLayout(false);
            MapArtTab.PerformLayout();
            PosterizationBox.ResumeLayout(false);
            PosterizationBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PosterizationTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PosterizationPreviewBox).EndInit();
            MAselect1box.ResumeLayout(false);
            MAselect1box.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl ModeSelect;
        private TabPage BasicTab;
        private TabPage AdvancedTab;
        private TabPage TerrainSwapTab;
        private TabPage MapArtTab;
        private Button HelpButton;
        private Button GenerateButton;
        private TextBox DestinationInput;
        private Button DestinationBrowse;
        private Label label1;
        private ProgressBar ProgressBar;
        private Label ProgressLabel;
        private GroupBox BMselect1box;
        private Button BMbrowse1;
        public TextBox BMselection1;
        private Label label2;
        private Label label3;
        private GroupBox AMselect1box;
        private Button AMbrowse1;
        public TextBox AMselection1;
        private GroupBox AMselect3box;
        private Button AMbrowse3;
        public TextBox AMselection3;
        private GroupBox AMselect2box;
        private Button AMbrowse2;
        public TextBox AMselection2;
        private TextBox NameSelection;
        private Label label6;
        private GroupBox AMsettingsbox;
        private CheckBox CapitalsChackbox;
        private CheckBox AdvancedCitiesCheckbox;
        private CheckBox OccupationsCheckbox;
        private CheckBox FlagsCheckbox;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private GroupBox TSselect2box;
        private Button TSbrowse2;
        public TextBox TSselection2;
        private Label label4;
        private GroupBox TSselect1box;
        private Button TSbrowse1;
        public TextBox TSselection1;
        private Label label5;
        private GroupBox MAselect1box;
        private Button MAbrowse1;
        public TextBox MAselection1;
        private PictureBox PosterizationPreviewBox;
        private Button PosterizationPreviewButton;
        private GroupBox PosterizationBox;
        private Label label10;
        private Label label9;
        public TrackBar PosterizationTrackBar;
    }
}