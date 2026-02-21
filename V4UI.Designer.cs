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
            BM1browse = new Button();
            BM1txt = new TextBox();
            AdvancedTab = new TabPage();
            AMselect4box = new GroupBox();
            AM4browse = new Button();
            AM4txt = new TextBox();
            AMsettingsbox = new GroupBox();
            CitySettingsGroupBox = new GroupBox();
            CitiesButton0 = new RadioButton();
            CitiesButton2 = new RadioButton();
            CitiesButton1 = new RadioButton();
            FlagsCheckbox = new CheckBox();
            OccupationsCheckbox = new CheckBox();
            AMselect3box = new GroupBox();
            AM3browse = new Button();
            AM3txt = new TextBox();
            AMselect2box = new GroupBox();
            AM2browse = new Button();
            AM2txt = new TextBox();
            label3 = new Label();
            AMselect1box = new GroupBox();
            AM1browse = new Button();
            AM1txt = new TextBox();
            TerrainSwapTab = new TabPage();
            OffsetText = new Label();
            Yoffset = new NumericUpDown();
            Xoffset = new NumericUpDown();
            MSOtext = new Label();
            MSOcheckbox = new CheckBox();
            TSselect2box = new GroupBox();
            TS2browse = new Button();
            TS2txt = new TextBox();
            label4 = new Label();
            TSselect1box = new GroupBox();
            TS1browse = new Button();
            TS1txt = new TextBox();
            MapArtTab = new TabPage();
            PosterizationPreviewButton = new Button();
            PosterizationPreviewBox = new PictureBox();
            PosterizationBox = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            PosterizationTrackBar = new TrackBar();
            label5 = new Label();
            MAselect1box = new GroupBox();
            MA1browse = new Button();
            MA1txt = new TextBox();
            InfoTab = new TabPage();
            groupBox2 = new GroupBox();
            STlabel = new Label();
            label11 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            DiscordLink = new LinkLabel();
            ReadmeLink = new LinkLabel();
            label7 = new Label();
            GenerateButton = new Button();
            DestinationInput = new TextBox();
            DestinationBrowse = new Button();
            label1 = new Label();
            ProgressBar = new ProgressBar();
            ProgressLabel = new Label();
            NameSelection = new TextBox();
            label6 = new Label();
            PoliticalCitiesTooltip = new ToolTip(components);
            CreateFlagsTooltip = new ToolTip(components);
            SeparateCitiesTooltip = new ToolTip(components);
            OccupationsTooltip = new ToolTip(components);
            SecretTooltip = new ToolTip(components);
            RunGameButton = new Button();
            ModeSelect.SuspendLayout();
            BasicTab.SuspendLayout();
            BMselect1box.SuspendLayout();
            AdvancedTab.SuspendLayout();
            AMselect4box.SuspendLayout();
            AMsettingsbox.SuspendLayout();
            CitySettingsGroupBox.SuspendLayout();
            AMselect3box.SuspendLayout();
            AMselect2box.SuspendLayout();
            AMselect1box.SuspendLayout();
            TerrainSwapTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Yoffset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Xoffset).BeginInit();
            TSselect2box.SuspendLayout();
            TSselect1box.SuspendLayout();
            MapArtTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PosterizationPreviewBox).BeginInit();
            PosterizationBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PosterizationTrackBar).BeginInit();
            MAselect1box.SuspendLayout();
            InfoTab.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ModeSelect
            // 
            ModeSelect.Controls.Add(BasicTab);
            ModeSelect.Controls.Add(AdvancedTab);
            ModeSelect.Controls.Add(TerrainSwapTab);
            ModeSelect.Controls.Add(MapArtTab);
            ModeSelect.Controls.Add(InfoTab);
            ModeSelect.Dock = DockStyle.Top;
            ModeSelect.Font = new Font("Segoe UI", 9.75F);
            ModeSelect.HotTrack = true;
            ModeSelect.ItemSize = new Size(100, 25);
            ModeSelect.Location = new Point(0, 0);
            ModeSelect.Margin = new Padding(0);
            ModeSelect.Multiline = true;
            ModeSelect.Name = "ModeSelect";
            ModeSelect.RightToLeft = RightToLeft.No;
            ModeSelect.SelectedIndex = 0;
            ModeSelect.Size = new Size(884, 440);
            ModeSelect.SizeMode = TabSizeMode.Fixed;
            ModeSelect.TabIndex = 0;
            // 
            // BasicTab
            // 
            BasicTab.BackColor = Color.Ivory;
            BasicTab.Controls.Add(label2);
            BasicTab.Controls.Add(BMselect1box);
            BasicTab.Location = new Point(4, 29);
            BasicTab.Margin = new Padding(0);
            BasicTab.Name = "BasicTab";
            BasicTab.Size = new Size(876, 407);
            BasicTab.TabIndex = 0;
            BasicTab.Text = "Basic";
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
            BMselect1box.Controls.Add(BM1browse);
            BMselect1box.Controls.Add(BM1txt);
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
            // BM1browse
            // 
            BM1browse.Location = new Point(404, 23);
            BM1browse.Margin = new Padding(4, 3, 4, 3);
            BM1browse.Name = "BM1browse";
            BM1browse.Size = new Size(88, 27);
            BM1browse.TabIndex = 10;
            BM1browse.Text = "Browse";
            BM1browse.UseVisualStyleBackColor = true;
            BM1browse.Click += ImgBrowse_Click;
            // 
            // BM1txt
            // 
            BM1txt.AllowDrop = true;
            BM1txt.BackColor = SystemColors.Window;
            BM1txt.Location = new Point(8, 25);
            BM1txt.Margin = new Padding(4, 3, 4, 3);
            BM1txt.Name = "BM1txt";
            BM1txt.Size = new Size(391, 25);
            BM1txt.TabIndex = 9;
            // 
            // AdvancedTab
            // 
            AdvancedTab.BackColor = Color.FromArgb(255, 240, 240);
            AdvancedTab.Controls.Add(AMselect4box);
            AdvancedTab.Controls.Add(AMsettingsbox);
            AdvancedTab.Controls.Add(AMselect3box);
            AdvancedTab.Controls.Add(AMselect2box);
            AdvancedTab.Controls.Add(label3);
            AdvancedTab.Controls.Add(AMselect1box);
            AdvancedTab.Location = new Point(4, 29);
            AdvancedTab.Name = "AdvancedTab";
            AdvancedTab.Padding = new Padding(3);
            AdvancedTab.Size = new Size(876, 407);
            AdvancedTab.TabIndex = 1;
            AdvancedTab.Text = "Advanced";
            // 
            // AMselect4box
            // 
            AMselect4box.Controls.Add(AM4browse);
            AMselect4box.Controls.Add(AM4txt);
            AMselect4box.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AMselect4box.Location = new Point(10, 310);
            AMselect4box.Margin = new Padding(4, 3, 4, 3);
            AMselect4box.Name = "AMselect4box";
            AMselect4box.Padding = new Padding(4, 3, 4, 3);
            AMselect4box.Size = new Size(500, 60);
            AMselect4box.TabIndex = 30;
            AMselect4box.TabStop = false;
            AMselect4box.Text = "Choose Cities Map";
            AMselect4box.Visible = false;
            // 
            // AM4browse
            // 
            AM4browse.Location = new Point(404, 23);
            AM4browse.Margin = new Padding(4, 3, 4, 3);
            AM4browse.Name = "AM4browse";
            AM4browse.Size = new Size(88, 27);
            AM4browse.TabIndex = 10;
            AM4browse.Text = "Browse";
            AM4browse.UseVisualStyleBackColor = true;
            AM4browse.Click += ImgBrowse_Click;
            // 
            // AM4txt
            // 
            AM4txt.AllowDrop = true;
            AM4txt.Location = new Point(8, 25);
            AM4txt.Margin = new Padding(4, 3, 4, 3);
            AM4txt.Name = "AM4txt";
            AM4txt.Size = new Size(391, 25);
            AM4txt.TabIndex = 9;
            // 
            // AMsettingsbox
            // 
            AMsettingsbox.Controls.Add(CitySettingsGroupBox);
            AMsettingsbox.Controls.Add(FlagsCheckbox);
            AMsettingsbox.Controls.Add(OccupationsCheckbox);
            AMsettingsbox.Location = new Point(520, 70);
            AMsettingsbox.Name = "AMsettingsbox";
            AMsettingsbox.Size = new Size(348, 331);
            AMsettingsbox.TabIndex = 30;
            AMsettingsbox.TabStop = false;
            AMsettingsbox.Text = "Additional Settings";
            // 
            // CitySettingsGroupBox
            // 
            CitySettingsGroupBox.Controls.Add(CitiesButton0);
            CitySettingsGroupBox.Controls.Add(CitiesButton2);
            CitySettingsGroupBox.Controls.Add(CitiesButton1);
            CitySettingsGroupBox.Location = new Point(10, 100);
            CitySettingsGroupBox.Name = "CitySettingsGroupBox";
            CitySettingsGroupBox.Size = new Size(170, 120);
            CitySettingsGroupBox.TabIndex = 38;
            CitySettingsGroupBox.TabStop = false;
            CitySettingsGroupBox.Text = "Cities";
            // 
            // CitiesButton0
            // 
            CitiesButton0.AutoSize = true;
            CitiesButton0.Checked = true;
            CitiesButton0.Location = new Point(17, 24);
            CitiesButton0.Name = "CitiesButton0";
            CitiesButton0.Size = new Size(58, 21);
            CitiesButton0.TabIndex = 33;
            CitiesButton0.TabStop = true;
            CitiesButton0.Text = "None";
            CitiesButton0.UseVisualStyleBackColor = true;
            CitiesButton0.Click += CitySettingButton_Click;
            // 
            // CitiesButton2
            // 
            CitiesButton2.AutoSize = true;
            CitiesButton2.Location = new Point(17, 84);
            CitiesButton2.Name = "CitiesButton2";
            CitiesButton2.Size = new Size(99, 21);
            CitiesButton2.TabIndex = 37;
            CitiesButton2.Text = "Separate file";
            CitiesButton2.UseVisualStyleBackColor = true;
            CitiesButton2.Click += CitySettingButton_Click;
            // 
            // CitiesButton1
            // 
            CitiesButton1.AutoSize = true;
            CitiesButton1.Location = new Point(17, 54);
            CitiesButton1.Name = "CitiesButton1";
            CitiesButton1.Size = new Size(141, 21);
            CitiesButton1.TabIndex = 34;
            CitiesButton1.Text = "Within political map";
            CitiesButton1.UseVisualStyleBackColor = true;
            CitiesButton1.Click += CitySettingButton_Click;
            // 
            // FlagsCheckbox
            // 
            FlagsCheckbox.AutoSize = true;
            FlagsCheckbox.Location = new Point(25, 70);
            FlagsCheckbox.Name = "FlagsCheckbox";
            FlagsCheckbox.Size = new Size(99, 21);
            FlagsCheckbox.TabIndex = 32;
            FlagsCheckbox.Text = "Create Flags";
            FlagsCheckbox.UseVisualStyleBackColor = true;
            // 
            // OccupationsCheckbox
            // 
            OccupationsCheckbox.AutoSize = true;
            OccupationsCheckbox.Location = new Point(25, 40);
            OccupationsCheckbox.Name = "OccupationsCheckbox";
            OccupationsCheckbox.Size = new Size(99, 21);
            OccupationsCheckbox.TabIndex = 31;
            OccupationsCheckbox.Text = "Occupations";
            OccupationsCheckbox.UseVisualStyleBackColor = true;
            OccupationsCheckbox.CheckedChanged += OccupationsCheckbox_CheckedChanged;
            // 
            // AMselect3box
            // 
            AMselect3box.Controls.Add(AM3browse);
            AMselect3box.Controls.Add(AM3txt);
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
            // AM3browse
            // 
            AM3browse.Location = new Point(404, 23);
            AM3browse.Margin = new Padding(4, 3, 4, 3);
            AM3browse.Name = "AM3browse";
            AM3browse.Size = new Size(88, 27);
            AM3browse.TabIndex = 10;
            AM3browse.Text = "Browse";
            AM3browse.UseVisualStyleBackColor = true;
            AM3browse.Click += ImgBrowse_Click;
            // 
            // AM3txt
            // 
            AM3txt.AllowDrop = true;
            AM3txt.Location = new Point(8, 25);
            AM3txt.Margin = new Padding(4, 3, 4, 3);
            AM3txt.Name = "AM3txt";
            AM3txt.Size = new Size(391, 25);
            AM3txt.TabIndex = 9;
            // 
            // AMselect2box
            // 
            AMselect2box.Controls.Add(AM2browse);
            AMselect2box.Controls.Add(AM2txt);
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
            // AM2browse
            // 
            AM2browse.Location = new Point(404, 23);
            AM2browse.Margin = new Padding(4, 3, 4, 3);
            AM2browse.Name = "AM2browse";
            AM2browse.Size = new Size(88, 27);
            AM2browse.TabIndex = 10;
            AM2browse.Text = "Browse";
            AM2browse.UseVisualStyleBackColor = true;
            AM2browse.Click += ImgBrowse_Click;
            // 
            // AM2txt
            // 
            AM2txt.AllowDrop = true;
            AM2txt.Location = new Point(8, 25);
            AM2txt.Margin = new Padding(4, 3, 4, 3);
            AM2txt.Name = "AM2txt";
            AM2txt.Size = new Size(391, 25);
            AM2txt.TabIndex = 9;
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
            AMselect1box.Controls.Add(AM1browse);
            AMselect1box.Controls.Add(AM1txt);
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
            // AM1browse
            // 
            AM1browse.Location = new Point(404, 23);
            AM1browse.Margin = new Padding(4, 3, 4, 3);
            AM1browse.Name = "AM1browse";
            AM1browse.Size = new Size(88, 27);
            AM1browse.TabIndex = 10;
            AM1browse.Text = "Browse";
            AM1browse.UseVisualStyleBackColor = true;
            AM1browse.Click += ImgBrowse_Click;
            // 
            // AM1txt
            // 
            AM1txt.AllowDrop = true;
            AM1txt.Location = new Point(8, 25);
            AM1txt.Margin = new Padding(4, 3, 4, 3);
            AM1txt.Name = "AM1txt";
            AM1txt.Size = new Size(391, 25);
            AM1txt.TabIndex = 9;
            // 
            // TerrainSwapTab
            // 
            TerrainSwapTab.BackColor = Color.Honeydew;
            TerrainSwapTab.Controls.Add(OffsetText);
            TerrainSwapTab.Controls.Add(Yoffset);
            TerrainSwapTab.Controls.Add(Xoffset);
            TerrainSwapTab.Controls.Add(MSOtext);
            TerrainSwapTab.Controls.Add(MSOcheckbox);
            TerrainSwapTab.Controls.Add(TSselect2box);
            TerrainSwapTab.Controls.Add(label4);
            TerrainSwapTab.Controls.Add(TSselect1box);
            TerrainSwapTab.Location = new Point(4, 29);
            TerrainSwapTab.Name = "TerrainSwapTab";
            TerrainSwapTab.Size = new Size(876, 407);
            TerrainSwapTab.TabIndex = 2;
            TerrainSwapTab.Text = "Terrain Swap";
            // 
            // OffsetText
            // 
            OffsetText.AutoSize = true;
            OffsetText.Location = new Point(10, 310);
            OffsetText.Name = "OffsetText";
            OffsetText.Size = new Size(74, 85);
            OffsetText.TabIndex = 37;
            OffsetText.Text = "x offset:\r\n(horizontal)\r\n\r\ny offset:\r\n(vertical)";
            OffsetText.Visible = false;
            // 
            // Yoffset
            // 
            Yoffset.Location = new Point(90, 365);
            Yoffset.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            Yoffset.Name = "Yoffset";
            Yoffset.Size = new Size(60, 25);
            Yoffset.TabIndex = 36;
            Yoffset.Visible = false;
            // 
            // Xoffset
            // 
            Xoffset.Location = new Point(90, 315);
            Xoffset.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            Xoffset.Name = "Xoffset";
            Xoffset.Size = new Size(60, 25);
            Xoffset.TabIndex = 35;
            Xoffset.Visible = false;
            // 
            // MSOtext
            // 
            MSOtext.AutoSize = true;
            MSOtext.Location = new Point(10, 250);
            MSOtext.Name = "MSOtext";
            MSOtext.Size = new Size(553, 51);
            MSOtext.TabIndex = 34;
            MSOtext.Text = resources.GetString("MSOtext.Text");
            MSOtext.Visible = false;
            // 
            // MSOcheckbox
            // 
            MSOcheckbox.AutoSize = true;
            MSOcheckbox.Location = new Point(10, 225);
            MSOcheckbox.Name = "MSOcheckbox";
            MSOcheckbox.Size = new Size(133, 21);
            MSOcheckbox.TabIndex = 33;
            MSOcheckbox.Text = "Map size override";
            MSOcheckbox.UseVisualStyleBackColor = true;
            MSOcheckbox.CheckedChanged += MSOcheckbox_CheckedChanged;
            // 
            // TSselect2box
            // 
            TSselect2box.Controls.Add(TS2browse);
            TSselect2box.Controls.Add(TS2txt);
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
            // TS2browse
            // 
            TS2browse.Location = new Point(404, 23);
            TS2browse.Margin = new Padding(4, 3, 4, 3);
            TS2browse.Name = "TS2browse";
            TS2browse.Size = new Size(88, 27);
            TS2browse.TabIndex = 10;
            TS2browse.Text = "Browse";
            TS2browse.UseVisualStyleBackColor = true;
            TS2browse.Click += TS2browse_Click;
            // 
            // TS2txt
            // 
            TS2txt.AllowDrop = true;
            TS2txt.Location = new Point(8, 25);
            TS2txt.Margin = new Padding(4, 3, 4, 3);
            TS2txt.Name = "TS2txt";
            TS2txt.Size = new Size(391, 25);
            TS2txt.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 10);
            label4.Name = "label4";
            label4.Size = new Size(394, 34);
            label4.TabIndex = 31;
            label4.Text = "Uses a map image to change terrain in a preexisting scenario.\r\nMost useful for updating terrain in multiple versions of a scenario.";
            // 
            // TSselect1box
            // 
            TSselect1box.Controls.Add(TS1browse);
            TSselect1box.Controls.Add(TS1txt);
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
            // TS1browse
            // 
            TS1browse.Location = new Point(404, 23);
            TS1browse.Margin = new Padding(4, 3, 4, 3);
            TS1browse.Name = "TS1browse";
            TS1browse.Size = new Size(88, 27);
            TS1browse.TabIndex = 10;
            TS1browse.Text = "Browse";
            TS1browse.UseVisualStyleBackColor = true;
            TS1browse.Click += ImgBrowse_Click;
            // 
            // TS1txt
            // 
            TS1txt.AllowDrop = true;
            TS1txt.Location = new Point(8, 25);
            TS1txt.Margin = new Padding(4, 3, 4, 3);
            TS1txt.Name = "TS1txt";
            TS1txt.Size = new Size(391, 25);
            TS1txt.TabIndex = 9;
            // 
            // MapArtTab
            // 
            MapArtTab.BackColor = Color.FromArgb(255, 240, 255);
            MapArtTab.Controls.Add(PosterizationPreviewButton);
            MapArtTab.Controls.Add(PosterizationPreviewBox);
            MapArtTab.Controls.Add(PosterizationBox);
            MapArtTab.Controls.Add(label5);
            MapArtTab.Controls.Add(MAselect1box);
            MapArtTab.Location = new Point(4, 29);
            MapArtTab.Name = "MapArtTab";
            MapArtTab.Size = new Size(876, 407);
            MapArtTab.TabIndex = 3;
            MapArtTab.Text = "Map Art";
            // 
            // PosterizationPreviewButton
            // 
            PosterizationPreviewButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PosterizationPreviewButton.Location = new Point(620, 180);
            PosterizationPreviewButton.Name = "PosterizationPreviewButton";
            PosterizationPreviewButton.Size = new Size(159, 60);
            PosterizationPreviewButton.TabIndex = 34;
            PosterizationPreviewButton.Text = "Generate posterization preview";
            PosterizationPreviewButton.UseVisualStyleBackColor = true;
            PosterizationPreviewButton.Click += PosterizationPreviewButton_Click;
            // 
            // PosterizationPreviewBox
            // 
            PosterizationPreviewBox.InitialImage = null;
            PosterizationPreviewBox.Location = new Point(520, 3);
            PosterizationPreviewBox.Margin = new Padding(4, 3, 4, 3);
            PosterizationPreviewBox.Name = "PosterizationPreviewBox";
            PosterizationPreviewBox.Size = new Size(353, 401);
            PosterizationPreviewBox.SizeMode = PictureBoxSizeMode.Zoom;
            PosterizationPreviewBox.TabIndex = 30;
            PosterizationPreviewBox.TabStop = false;
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
            PosterizationTrackBar.Scroll += PosterizationTrackBar_Scroll;
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
            MAselect1box.Controls.Add(MA1browse);
            MAselect1box.Controls.Add(MA1txt);
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
            // MA1browse
            // 
            MA1browse.Location = new Point(404, 23);
            MA1browse.Margin = new Padding(4, 3, 4, 3);
            MA1browse.Name = "MA1browse";
            MA1browse.Size = new Size(88, 27);
            MA1browse.TabIndex = 10;
            MA1browse.Text = "Browse";
            MA1browse.UseVisualStyleBackColor = true;
            MA1browse.Click += ImgBrowse_Click;
            // 
            // MA1txt
            // 
            MA1txt.AllowDrop = true;
            MA1txt.Location = new Point(8, 25);
            MA1txt.Margin = new Padding(4, 3, 4, 3);
            MA1txt.Name = "MA1txt";
            MA1txt.Size = new Size(391, 25);
            MA1txt.TabIndex = 9;
            MA1txt.TextChanged += MA1_TextChanged;
            // 
            // InfoTab
            // 
            InfoTab.Controls.Add(groupBox2);
            InfoTab.Controls.Add(groupBox1);
            InfoTab.Location = new Point(4, 29);
            InfoTab.Name = "InfoTab";
            InfoTab.Padding = new Padding(3);
            InfoTab.Size = new Size(876, 407);
            InfoTab.TabIndex = 4;
            InfoTab.Text = "Help & Info  ";
            InfoTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(STlabel);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(6, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(865, 239);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "About";
            // 
            // STlabel
            // 
            STlabel.AutoSize = true;
            STlabel.ForeColor = SystemColors.ControlText;
            STlabel.Location = new Point(6, 92);
            STlabel.Name = "STlabel";
            STlabel.Size = new Size(394, 85);
            STlabel.TabIndex = 2;
            STlabel.Text = "Special thanks to:\r\n\r\nJokuPelle for creating a wonderful space in and around this game\r\n\r\nThe AoC community for supporting this silly project over the years\r\n";
            STlabel.Click += STlabel_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label11.Location = new Point(90, 25);
            label11.Name = "label11";
            label11.Size = new Size(37, 17);
            label11.TabIndex = 1;
            label11.Text = "4.0.0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 25);
            label8.Name = "label8";
            label8.Size = new Size(205, 51);
            label8.TabIndex = 0;
            label8.Text = "App verison: \r\n\r\nLead developer:   Corrupted Matt";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DiscordLink);
            groupBox1.Controls.Add(ReadmeLink);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(865, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Help";
            // 
            // DiscordLink
            // 
            DiscordLink.AutoSize = true;
            DiscordLink.Location = new Point(433, 81);
            DiscordLink.Name = "DiscordLink";
            DiscordLink.Size = new Size(53, 17);
            DiscordLink.TabIndex = 2;
            DiscordLink.TabStop = true;
            DiscordLink.Text = "Discord";
            DiscordLink.LinkClicked += DiscordLink_LinkClicked;
            // 
            // ReadmeLink
            // 
            ReadmeLink.AutoSize = true;
            ReadmeLink.Location = new Point(249, 30);
            ReadmeLink.Name = "ReadmeLink";
            ReadmeLink.Size = new Size(48, 17);
            ReadmeLink.TabIndex = 1;
            ReadmeLink.TabStop = true;
            ReadmeLink.Text = "GitHub";
            ReadmeLink.LinkClicked += ReadmeLink_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(6, 30);
            label7.Name = "label7";
            label7.Size = new Size(421, 68);
            label7.TabIndex = 0;
            label7.Text = "In depth guide to all coverter functions:\r\n\r\nFor bug reporting, feature requests and general questions\r\nreach out to me @corruptedmatt on the game's official discord server:";
            // 
            // GenerateButton
            // 
            GenerateButton.Font = new Font("Segoe UI", 9.75F);
            GenerateButton.Location = new Point(772, 498);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(100, 50);
            GenerateButton.TabIndex = 2;
            GenerateButton.Text = "Generate scenario";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // DestinationInput
            // 
            DestinationInput.Location = new Point(14, 466);
            DestinationInput.Margin = new Padding(4, 3, 4, 3);
            DestinationInput.Name = "DestinationInput";
            DestinationInput.Size = new Size(401, 23);
            DestinationInput.TabIndex = 7;
            // 
            // DestinationBrowse
            // 
            DestinationBrowse.Font = new Font("Segoe UI", 9.75F);
            DestinationBrowse.Location = new Point(418, 462);
            DestinationBrowse.Margin = new Padding(4, 3, 4, 3);
            DestinationBrowse.Name = "DestinationBrowse";
            DestinationBrowse.Size = new Size(88, 27);
            DestinationBrowse.TabIndex = 12;
            DestinationBrowse.Text = "Browse";
            DestinationBrowse.UseVisualStyleBackColor = true;
            DestinationBrowse.Click += DestinationBrowse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(14, 446);
            label1.Name = "label1";
            label1.Size = new Size(155, 17);
            label1.TabIndex = 0;
            label1.Text = "Select Output Destiantion";
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(14, 524);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(640, 25);
            ProgressBar.Style = ProgressBarStyle.Continuous;
            ProgressBar.TabIndex = 24;
            ProgressBar.Visible = false;
            // 
            // ProgressLabel
            // 
            ProgressLabel.AutoSize = true;
            ProgressLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ProgressLabel.Location = new Point(14, 504);
            ProgressLabel.MaximumSize = new Size(250, 20);
            ProgressLabel.Name = "ProgressLabel";
            ProgressLabel.Size = new Size(65, 17);
            ProgressLabel.TabIndex = 25;
            ProgressLabel.Text = "Preparing";
            ProgressLabel.Visible = false;
            // 
            // NameSelection
            // 
            NameSelection.Location = new Point(524, 466);
            NameSelection.Name = "NameSelection";
            NameSelection.Size = new Size(348, 23);
            NameSelection.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(524, 447);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 16);
            label6.TabIndex = 29;
            label6.Text = "Scenario Name:";
            // 
            // PoliticalCitiesTooltip
            // 
            PoliticalCitiesTooltip.UseAnimation = false;
            PoliticalCitiesTooltip.UseFading = false;
            // 
            // RunGameButton
            // 
            RunGameButton.Location = new Point(666, 499);
            RunGameButton.Name = "RunGameButton";
            RunGameButton.Size = new Size(100, 50);
            RunGameButton.TabIndex = 30;
            RunGameButton.Text = "Run AoC \r\nvia Steam";
            RunGameButton.UseVisualStyleBackColor = true;
            RunGameButton.Click += RunGameButton_Click;
            // 
            // V4UI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(RunGameButton);
            Controls.Add(label6);
            Controls.Add(NameSelection);
            Controls.Add(label1);
            Controls.Add(DestinationBrowse);
            Controls.Add(GenerateButton);
            Controls.Add(DestinationInput);
            Controls.Add(ProgressLabel);
            Controls.Add(ModeSelect);
            Controls.Add(ProgressBar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "V4UI";
            Text = "Image to Scenario Converter";
            Load += V4UI_Load;
            ModeSelect.ResumeLayout(false);
            BasicTab.ResumeLayout(false);
            BasicTab.PerformLayout();
            BMselect1box.ResumeLayout(false);
            BMselect1box.PerformLayout();
            AdvancedTab.ResumeLayout(false);
            AdvancedTab.PerformLayout();
            AMselect4box.ResumeLayout(false);
            AMselect4box.PerformLayout();
            AMsettingsbox.ResumeLayout(false);
            AMsettingsbox.PerformLayout();
            CitySettingsGroupBox.ResumeLayout(false);
            CitySettingsGroupBox.PerformLayout();
            AMselect3box.ResumeLayout(false);
            AMselect3box.PerformLayout();
            AMselect2box.ResumeLayout(false);
            AMselect2box.PerformLayout();
            AMselect1box.ResumeLayout(false);
            AMselect1box.PerformLayout();
            TerrainSwapTab.ResumeLayout(false);
            TerrainSwapTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Yoffset).EndInit();
            ((System.ComponentModel.ISupportInitialize)Xoffset).EndInit();
            TSselect2box.ResumeLayout(false);
            TSselect2box.PerformLayout();
            TSselect1box.ResumeLayout(false);
            TSselect1box.PerformLayout();
            MapArtTab.ResumeLayout(false);
            MapArtTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PosterizationPreviewBox).EndInit();
            PosterizationBox.ResumeLayout(false);
            PosterizationBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PosterizationTrackBar).EndInit();
            MAselect1box.ResumeLayout(false);
            MAselect1box.PerformLayout();
            InfoTab.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl ModeSelect;
        private TabPage BasicTab;
        private TabPage AdvancedTab;
        private TabPage TerrainSwapTab;
        private TabPage MapArtTab;
        private Button GenerateButton;
        private TextBox DestinationInput;
        private Button DestinationBrowse;
        private Label label1;
        private ProgressBar ProgressBar;
        private Label ProgressLabel;
        private GroupBox BMselect1box;
        private Button BM1browse;
        public TextBox BM1txt;
        private Label label2;
        private Label label3;
        private GroupBox AMselect1box;
        private Button AM1browse;
        public TextBox AM1txt;
        private GroupBox AMselect3box;
        private Button AM3browse;
        public TextBox AM3txt;
        private GroupBox AMselect2box;
        private Button AM2browse;
        public TextBox AM2txt;
        private TextBox NameSelection;
        private Label label6;
        private GroupBox AMsettingsbox;
        private CheckBox OccupationsCheckbox;
        private CheckBox FlagsCheckbox;
        private ToolTip PoliticalCitiesTooltip;
        private ToolTip CreateFlagsTooltip;
        private GroupBox TSselect2box;
        private Button TS2browse;
        public TextBox TS2txt;
        private Label label4;
        private GroupBox TSselect1box;
        private Button TS1browse;
        public TextBox TS1txt;
        private Label label5;
        private GroupBox MAselect1box;
        private Button MA1browse;
        public TextBox MA1txt;
        private PictureBox PosterizationPreviewBox;
        private Button PosterizationPreviewButton;
        private GroupBox PosterizationBox;
        private Label label10;
        private Label label9;
        public TrackBar PosterizationTrackBar;
        private RadioButton CitiesButton1;
        private RadioButton CitiesButton0;
        private GroupBox AMselect4box;
        private Button AM4browse;
        public TextBox AM4txt;
        private RadioButton CitiesButton2;
        private GroupBox CitySettingsGroupBox;
        private ToolTip SeparateCitiesTooltip;
        private ToolTip OccupationsTooltip;
        private TabPage InfoTab;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label7;
        private LinkLabel ReadmeLink;
        private Label label11;
        private Label label8;
        private LinkLabel DiscordLink;
        private Label STlabel;
        private ToolTip SecretTooltip;
        private Button RunGameButton;
        private Label MSOtext;
        private CheckBox MSOcheckbox;
        private NumericUpDown Yoffset;
        private NumericUpDown Xoffset;
        private Label OffsetText;
    }
}