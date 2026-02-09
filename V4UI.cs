using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;
using static AoC_Image_to_Scenario_Converter.ImgUtils;

namespace AoC_Image_to_Scenario_Converter
{
    public partial class V4UI : Form
    {
        Bitmap? Img1, Img2, Img3, Img4;
        Image[]? PosterizedImages;
        string InputScenarioDest, OutputDest, SelectedName;
        bool Flags, Occupations;
        int ColorChannels, CitiesSetting = 0;

        public V4UI()
        {
            InitializeComponent();
        }

        private void V4UI_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; // this prevents broken scenarios when system uses "," as decimal separator
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            SeparateCitiesTooltip.SetToolTip(CitiesButton2, "Cities are in their own image, making it possible to create very small nations.\nCity color has to match its rightful owner, with #FF0000 reserved for capitals");
            PoliticalCitiesTooltip.SetToolTip(CitiesButton1, "Reserve #FF0000 for capitals, #00FF00 for cores \nand #FFFF00 for uncored cities within the political map");
            CreateFlagsTooltip.SetToolTip(FlagsCheckbox, "Create a flagsheet where each nation gets a blank flag of its map color");
            OccupationsTooltip.SetToolTip(OccupationsCheckbox, "Add a second variation of the political map,\nany difference between them will be marked as occupied");
            SecretTooltip.SetToolTip(STlabel, "aww how cute... \nwait, this thing's clickable?"); //oooh secrets!
            if (System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) != "") // this thing gets a hold of the scenario directory, still quite shocked this isn't an access violation
                DestinationInput.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low\\JoySparkGames\\Ages of Conflict\\Custom Scenarios";
        }

        #region Universal Controls

        public async void GenerateButton_Click(object sender, EventArgs e)
        {
            int SelectedMode = ModeSelect.SelectedIndex;

            SelectedName = NameSelection.Text;
            OutputDest = DestinationInput.Text;

            if ((SelectedName == "" || OutputDest == "") && SelectedMode != 4)
            {
                foreach (TextBox t in Controls.Find("txt", true))
                {
                    if (t.Text == "") t.BackColor = Color.LightYellow; // highlighting empty fields, so fancy
                    else t.BackColor = Color.White;
                }
                MessageBox.Show("Please provide a name and output destination");
            }
            else
            {
                foreach (TextBox t in Controls.Find("txt", true))
                {
                    t.BackColor = Color.White;
                }
                GenerateButton.Enabled = false;
                ModeSelect.Enabled = false;

                var progress = new Progress<double>(value =>
                {
                    ProgressBar.Value = (int)value;
                    if (value == 0) ProgressLabel.Text = "Preparing";
                    else if (value < 20) ProgressLabel.Text = "[1 of 5] Creating Countires";
                    else if (value < 40) ProgressLabel.Text = "[2 of 5] Placing Cities";
                    else if (value < 60) ProgressLabel.Text = "[3 of 5] Painting Map";
                    else if (value < 80) ProgressLabel.Text = "[4 of 5] Assigning Ownership";
                    else if (value < 100) ProgressLabel.Text = "[5 of 5] Drawing Occupation Zones";
                    else ProgressLabel.Text = "Complete!";
                });

                switch (SelectedMode)
                {
                    case 0:
                        if (BM1txt.Text == "")
                        {
                            foreach (TextBox t in BasicTab.Controls.Find("txt", true))
                            {
                                if (t.Text == "") t.BackColor = Color.LightYellow;
                                else t.BackColor = Color.White;
                            }
                            MessageBox.Show("Please provide all necessary inputs");
                        }
                        else
                        {
                            Img1 = (Bitmap)Image.FromFile(BM1txt.Text);

                            ProgressBar.Visible = true;
                            ProgressLabel.Visible = true;
                            foreach (TextBox t in BasicTab.Controls.Find("txt", true))
                            {
                                t.BackColor = Color.White;
                            }

                            await Task.Run(() =>
                            {
                                BasicMode.Generate(Img1, OutputDest, SelectedName, progress);
                            });
                        }
                        break;

                    case 1:
                        if (AM1txt.Text == "" ||
                            AM2txt.Text == "" ||
                            (AM3txt.Text == "" && OccupationsCheckbox.Checked) ||
                            (AM4txt.Text == "" && CitiesSetting == 2))
                        {
                            foreach (TextBox t in AdvancedTab.Controls.Find("txt", true))
                            {
                                if (t.Text == "") t.BackColor = Color.LightYellow;
                                else t.BackColor = Color.White;
                            }
                            MessageBox.Show("Please provide all necessary inputs");
                        }
                        else
                        {
                            Occupations = OccupationsCheckbox.Checked;
                            Flags = FlagsCheckbox.Checked;
                            Img1 = (Bitmap)Image.FromFile(AM1txt.Text);
                            Img2 = (Bitmap)Image.FromFile(AM2txt.Text);
                            if (Occupations) Img3 = (Bitmap)Image.FromFile(AM3txt.Text);
                            else Img3 = null;
                            if (CitiesSetting == 2) Img4 = (Bitmap)Image.FromFile(AM4txt.Text);
                            else Img4 = null;

                            ProgressBar.Visible = true;
                            ProgressLabel.Visible = true;
                            foreach (TextBox t in AdvancedTab.Controls.Find("txt", true))
                            {
                                t.BackColor = Color.White;
                            }

                            await Task.Run(() =>
                            {
                                AdvMode.Generate(Img1, Img2, Img3, Img4, OutputDest, SelectedName, CitiesSetting, Flags, progress);
                                // so. many. arguments. I've made a monster
                            });
                        }
                        break;
                    case 2:
                        if (TS1txt.Text == "" || TS2txt.Text == "")
                        {
                            foreach (TextBox t in TerrainSwapTab.Controls.Find("txt", true))
                            {
                                if (t.Text == "") t.BackColor = Color.LightYellow;
                                else t.BackColor = Color.White;
                            }
                            MessageBox.Show("Please provide all necessary inputs");
                        }
                        else
                        {
                            Img1 = (Bitmap)Image.FromFile(TS1txt.Text);
                            InputScenarioDest = TS2txt.Text;

                            ProgressBar.Visible = true;
                            ProgressLabel.Visible = true;
                            foreach (TextBox t in TerrainSwapTab.Controls.Find("txt", true))
                            {
                                t.BackColor = Color.White;
                            }

                            await Task.Run(() =>
                            {
                                TerrainSwapMode.Generate(Img1, InputScenarioDest, OutputDest, SelectedName, progress);
                            });
                        }
                        break;
                    case 3:
                        if (MA1txt.Text == "")
                        {
                            foreach (TextBox t in MapArtTab.Controls.Find("txt", true))
                            {
                                if (t.Text == "") t.BackColor = Color.LightYellow;
                                else t.BackColor = Color.White;
                            }
                            MessageBox.Show("Please provide all necessary inputs");
                        }
                        else
                        {
                            Img1 = (Bitmap)Image.FromFile(MA1txt.Text);
                            ColorChannels = (int)Math.Pow(2, 8 - PosterizationTrackBar.Value);

                            ProgressBar.Visible = true;
                            ProgressLabel.Visible = true;
                            foreach (TextBox t in MapArtTab.Controls.Find("txt", true))
                            {
                                t.BackColor = Color.White;
                            }

                            await Task.Run(() =>
                            {
                                MapArtMode.Generate(Img1, OutputDest, SelectedName, ColorChannels, progress);
                            });
                        }
                        break;
                    case 4:
                        MessageBox.Show("You can't do that here, silly :P");
                        break;
                }
                GenerateButton.Enabled = true;
                ModeSelect.Enabled = true;
                ProgressBar.Visible = false;
                ProgressLabel.Visible = false;
            }
        }

        private void DestinationBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DestinationSelectDialog = new();
            if (System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) != "")
                DestinationSelectDialog.SelectedPath = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low\\JoySparkGames\\Ages of Conflict\\Custom Scenarios";
            if (DestinationSelectDialog.ShowDialog() == DialogResult.OK)
                DestinationInput.Text = DestinationSelectDialog.SelectedPath;
        }

        private void ImgBrowse_Click(object sender, EventArgs e)
        {
            // this whole thing is so scuffed, but arguably, handling each of those buttons separately would be worse
            PosterizationPreviewBox.Image = null;
            Button caller = sender as Button;
            string tb = caller.Name[..3] + "txt";
            Control[] t = new Control[1];
            t = Controls.Find(tb, true);
            OpenFileDialog ImgSelectionDialog = new()
            {
                Filter = "Images|*.png"
            };
            if (ImgSelectionDialog.ShowDialog() == DialogResult.OK && t.Length > 0)
            {
                t[0].Text = ImgSelectionDialog.FileName;
            }
        }

        private void RunGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "steam://rungameid/2186320",
                    UseShellExecute = true
                });
            }
            catch
            {
                RunGameButton.Enabled = false;
                MessageBox.Show("No Steam installation detected");
            }

        }

        private void ReadmeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Corrupted-Matt/AoC-Image-to-Scenario-Converter?tab=readme-ov-file#readme",
                UseShellExecute = true
            });
        }

        private void DiscordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://discord.gg/fv3EExm6KY",
                UseShellExecute = true
            });
        }

        private void STlabel_Click(object sender, EventArgs e)
        {
            STlabel.Text = "Special thanks to:\r\n\r\nJokuPelle for creating a wonderful space in and around this game\r\n\r\nThe AoC community for supporting this silly project over the years\r\n\nTitaniumSteel for independently coming up with the same idea \nand monopolizing the Steam forums with it, so I don't have to deal with *shudders* that";
            SecretTooltip.Active = false;
        }
        #endregion

        #region Advanced Mode Specific Controls

        private void CitySettingButton_Click(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            CitiesSetting = r.Name.Last() - 48; //this is criminal, but it works
            if (CitiesSetting == 2) AMselect4box.Visible = true;
            else AMselect4box.Visible = false;
        }

        private void OccupationsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            AMselect3box.Visible = OccupationsCheckbox.Checked;
        }

        #endregion

        #region Terrain Swap Exclusive Controls

        private void TS2browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ScenarioSelectDialog = new()
            {
                Filter = "AoC Scenario Files|*.aoc"
            };
            if (System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) != "")
                ScenarioSelectDialog.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low\\JoySparkGames\\Ages of Conflict\\Custom Scenarios";
            if (ScenarioSelectDialog.ShowDialog() == DialogResult.OK)
                TS2txt.Text = ScenarioSelectDialog.FileName;
        }

        #endregion

        #region Map Art Exclusive Controls

        async private void PosterizationPreviewButton_Click(object sender, EventArgs e)
        {
            if (MA1txt.Text != "")
            {
                PosterizationTrackBar.Enabled = false;
                ModeSelect.Enabled = false;
                PosterizationPreviewButton.Enabled = false;
                PosterizationPreviewButton.Text = "Generating preview...";
                await Task.Run(() =>
                {
                    PosterizedImages =
                        [
                        PosterizeImage((Bitmap)Image.FromFile(MA1txt.Text), (int)Math.Pow(2, 8)),
                        PosterizeImage((Bitmap)Image.FromFile(MA1txt.Text), (int)Math.Pow(2, 7)),
                        PosterizeImage((Bitmap)Image.FromFile(MA1txt.Text), (int)Math.Pow(2, 6)),
                        PosterizeImage((Bitmap)Image.FromFile(MA1txt.Text), (int)Math.Pow(2, 5)),
                        PosterizeImage((Bitmap)Image.FromFile(MA1txt.Text), (int)Math.Pow(2, 4)),
                        PosterizeImage((Bitmap)Image.FromFile(MA1txt.Text), (int)Math.Pow(2, 3)),
                        PosterizeImage((Bitmap)Image.FromFile(MA1txt.Text), (int)Math.Pow(2, 2)),
                        PosterizeImage((Bitmap)Image.FromFile(MA1txt.Text), (int)Math.Pow(2, 1)),
                        PosterizeImage((Bitmap)Image.FromFile(MA1txt.Text), (int)Math.Pow(2, 0))
                        ]; // there's surely a better way to do this, but whatever
                });
                PosterizationPreviewButton.Enabled = true;
                PosterizationPreviewButton.Text = "Generate preview";
                PosterizationTrackBar.Enabled = true;
                ModeSelect.Enabled = true;
                PosterizationPreviewBox.Image = PosterizedImages[PosterizationTrackBar.Value];
                PosterizationPreviewButton.Visible = false;
            }
            else
            {
                MessageBox.Show("Select an image first");
            }
        }

        private void PosterizationTrackBar_Scroll(object sender, EventArgs e)
        {
            if (PosterizedImages != null)
                PosterizationPreviewBox.Image = PosterizedImages[PosterizationTrackBar.Value];
        }

        private void MA1_TextChanged(object sender, EventArgs e)
        {
            PosterizedImages = null;
            PosterizationPreviewButton.Visible = true;
        }

        #endregion
    }
}
