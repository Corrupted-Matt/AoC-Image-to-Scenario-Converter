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
using TextBox = System.Windows.Forms.TextBox;

namespace AoC_Image_to_Scenario_Converter
{
    public partial class V4UI : Form
    {
        public V4UI()
        {
            InitializeComponent();
        }

        private void V4UI_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            toolTip1.SetToolTip(AdvancedCitiesCheckbox, "Reserve #00FF00 and #FFFF00 for cored and uncored cities respectively");
            toolTip2.SetToolTip(CapitalsChackbox, "Reserve #FF0000 for capitals, if selected all countries need to have one");
            toolTip3.SetToolTip(FlagsCheckbox, "Create a flagsheet where each nation gets a blank flag of its map color");
        }

        #region Universal Controls

        public async void GenerateButton_Click(object sender, EventArgs e)
        {
            Bitmap Img1, Img2, Img3;
            string InputScenarioDest, OutputDest, SelectedName;
            bool Capitals, AdvCities, Flags, Occupations;
            int ColorChannels;
            int SelectedMode = ModeSelect.SelectedIndex;

            SelectedName = NameSelection.Text;
            OutputDest = DestinationInput.Text;

            if (SelectedName == "" || OutputDest == "")
            {
                foreach (TextBox t in Controls)
                {
                    if (t.Text == "") t.BackColor = Color.LightYellow;
                    else t.BackColor = Color.White;
                }
                MessageBox.Show("Please provide a name and output destination");
            }
            else
            {
                foreach (TextBox t in Controls)
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
                        if (BMselection1.Text == "")
                        {
                            foreach (TextBox t in BasicTab.Controls)
                            {
                                if (t.Text == "") t.BackColor = Color.LightYellow;
                                else t.BackColor = Color.White;
                            }
                            MessageBox.Show("Please provide all necessary inputs");
                        }
                        else
                        {
                            Img1 = (Bitmap)Image.FromFile(BMselection1.Text);

                            ProgressBar.Visible = true;
                            ProgressLabel.Visible = true;
                            foreach (TextBox t in BasicTab.Controls)
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
                        if (AMselection1.Text == "" ||
                            AMselection2.Text == "" ||
                            (AMselection3.Text == "" && OccupationsCheckbox.Checked))
                        {
                            foreach (TextBox t in AdvancedTab.Controls)
                            {
                                if (t.Text == "") t.BackColor = Color.LightYellow;
                                else t.BackColor = Color.White;
                            }
                            MessageBox.Show("Please provide all necessary inputs");
                        }
                        else
                        {
                            Capitals = CapitalsChackbox.Checked;
                            AdvCities = AdvancedCitiesCheckbox.Checked;
                            Occupations = OccupationsCheckbox.Checked;
                            Flags = FlagsCheckbox.Checked;

                            Img1 = (Bitmap)Image.FromFile(AMselection1.Text);
                            Img2 = (Bitmap)Image.FromFile(AMselection2.Text);
                            if (Occupations) Img3 = (Bitmap)Image.FromFile(AMselection3.Text);
                            else Img3 = null;

                            ProgressBar.Visible = true;
                            ProgressLabel.Visible = true;
                            foreach (TextBox t in AdvancedTab.Controls)
                            {
                                t.BackColor = Color.White;
                            }

                            await Task.Run(() =>
                            {
                                AdvMode.Generate(Img1, Img2, Img3, OutputDest, SelectedName, Capitals, AdvCities, Flags, progress);
                            });
                        }
                        break;
                    case 2:
                        if (TSselection1.Text == "" || TSselection2.Text == "")
                        {
                            foreach (TextBox t in TerrainSwapTab.Controls)
                            {
                                if (t.Text == "") t.BackColor = Color.LightYellow;
                                else t.BackColor = Color.White;
                            }
                            MessageBox.Show("Please provide all necessary inputs");
                        }
                        else
                        {
                            Img1 = (Bitmap)Image.FromFile(TSselection1.Text);
                            InputScenarioDest = TSselection2.Text;

                            ProgressBar.Visible = true;
                            ProgressLabel.Visible = true;
                            foreach (TextBox t in TerrainSwapTab.Controls)
                            {
                                t.BackColor = Color.White;
                            }

                            await Task.Run(() =>
                            {
                                
                            });
                        }
                        break;
                    case 3:
                        if (MAselection1.Text == "")
                        {
                            foreach (TextBox t in MapArtTab.Controls)
                            {
                                if (t.Text == "") t.BackColor = Color.LightYellow;
                                else t.BackColor = Color.White;
                            }
                            MessageBox.Show("Please provide all necessary inputs");
                        }
                        else
                        {
                            Img1 = (Bitmap)Image.FromFile(MAselection1.Text);
                            ColorChannels = (int)Math.Pow(2, 8 - PosterizationTrackBar.Value);

                            ProgressBar.Visible = true;
                            ProgressLabel.Visible = true;
                            foreach (TextBox t in MapArtTab.Controls)
                            {
                                t.BackColor = Color.White;
                            }

                            await Task.Run(() =>
                            {
                                MapArtMode.Generate(Img1, OutputDest, SelectedName, ColorChannels, progress);
                            });
                        }
                        break;
                }
                GenerateButton.Enabled = true;
                ModeSelect.Enabled = true;
                ProgressBar.Visible = false;
                ProgressLabel.Visible = false;
            }
        }

        #endregion
    }
}
