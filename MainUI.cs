﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AoC_Image_to_Scenario_Converter.ImgUtils;
using static AoC_Image_to_Scenario_Converter.BasicMode;
using static AoC_Image_to_Scenario_Converter.MapArtMode;
using System.Diagnostics;
using System.Resources;
using AoC_Image_to_Scenario_Converter.Properties;
using System.Reflection;


namespace AoC_Image_to_Scenario_Converter
{
    public partial class MainUI : Form
    {
        //readonly Image BMschem = Resources.BasicMode;
        //readonly Image AMschem = Resources.AdvancedMode;

        public MainUI()
        {
            InitializeComponent();
        }
        public void MainUI_Load(object sender, EventArgs e)
        {
            PosterizationBox.Visible = false;
            PosterizationBox.Location = new Point(13, 310);
            File1SelectBox.Visible = false;
            File2SelectBox.Visible = false;
        }
        Image[] PosterizedImages = [];
        public void ModeSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ModeSelectComboBox.SelectedIndex)
            {
                case 0:
                    GenButton.Enabled = true;
                    label3.Text = "Uses single image with default AoC terrain color-coding to create an empty scenario. \nMost useful for bypassing map size limit.";
                    //pictureBox1.Image = BMschem;
                    File2SelectBox.Visible = false;
                    PosterizationBox.Visible = false;
                    File1SelectBox.Text = "Choose Image:";
                    File1SelectBox.Visible = true;
                    break;
                case 1:
                    GenButton.Enabled = true;
                    label3.Text = "Uses two images to create a scenario with countires.\nTerrain image should use standard AoC color-coding.\nCountries can be painted on top of the terrain image using \none unique color per nation to create the coutries image.\nMost useful if you want to paint countries in your image \neditor of choice instead of the one provided by the game.";
                    //pictureBox1.Image = AMschem;
                    PosterizationBox.Visible = false;
                    File1SelectBox.Text = "Choose Terrain Image:";
                    File1SelectBox.Visible = true;
                    File2SelectBox.Text = "Choose Countries Image:";
                    File2SelectBox.Visible = true;
                    break;
                case 2:
                    GenButton.Enabled = true;
                    label3.Text = "Recreates any image in game by placing nations in corresponding colors on a blank map.\n...I really can't come up with a good use case for this one...";
                    if (Image1Selection.Text != "")
                        pictureBox1.Image = PosterizeImage((Bitmap)Image.FromFile(Image1Selection.Text), (int)Math.Pow(2, 8 - PosterizationTrackBar.Value));
                    else
                        pictureBox1.Image= null;
                    File2SelectBox.Visible = false;
                    File1SelectBox.Text = "Choose Image:";
                    File1SelectBox.Visible = true;
                    PosterizationBox.Visible = true;
                    break;

            }
        }

        private void Image1SelectionBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog Image1SelectionDialog = new()
            {
                Filter = "Images|*.png"
            };
            if (Image1SelectionDialog.ShowDialog() == DialogResult.OK)
            {
                Image1Selection.Text = Image1SelectionDialog.FileName;
                if (Image1Selection.Text != "" && ModeSelectComboBox.SelectedIndex == 2)
                {
                    PosterizedImages =
                        [
                        PosterizeImage((Bitmap)Image.FromFile(Image1Selection.Text), (int)Math.Pow(2, 8)),
                        PosterizeImage((Bitmap)Image.FromFile(Image1Selection.Text), (int)Math.Pow(2, 7)),
                        PosterizeImage((Bitmap)Image.FromFile(Image1Selection.Text), (int)Math.Pow(2, 6)),
                        PosterizeImage((Bitmap)Image.FromFile(Image1Selection.Text), (int)Math.Pow(2, 5)),
                        PosterizeImage((Bitmap)Image.FromFile(Image1Selection.Text), (int)Math.Pow(2, 4)),
                        PosterizeImage((Bitmap)Image.FromFile(Image1Selection.Text), (int)Math.Pow(2, 3)),
                        PosterizeImage((Bitmap)Image.FromFile(Image1Selection.Text), (int)Math.Pow(2, 2)),
                        PosterizeImage((Bitmap)Image.FromFile(Image1Selection.Text), (int)Math.Pow(2, 1)),
                        PosterizeImage((Bitmap)Image.FromFile(Image1Selection.Text), (int)Math.Pow(2, 0))
                        ];
                    pictureBox1.Image = PosterizedImages[PosterizationTrackBar.Value];
                }
            }
                
        }

        private void Image2SelectionBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog Image2SelectionDialog = new()
            {
                Filter = "Images|*.png"
            };
            if (Image2SelectionDialog.ShowDialog() == DialogResult.OK)
                Image2Selection.Text = Image2SelectionDialog.FileName;
        }

        private void OutputDestinationBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DestinationSelectDialog = new();
            if (System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) != "")
                DestinationSelectDialog.SelectedPath = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low\\JoySparkGames\\Ages of Conflict\\Custom Scenarios";
            if (DestinationSelectDialog.ShowDialog() == DialogResult.OK)
                OutputDestination.Text = DestinationSelectDialog.SelectedPath;
        }

        private void PosterizationTrackBar_Scroll(object sender, EventArgs e)
        {
            if (Image1Selection.Text != "")
                pictureBox1.Image = PosterizedImages[PosterizationTrackBar.Value];
        }

        public async void GenButton_Click(object sender, EventArgs e)
        {
            var progress = new Progress<double>(value =>
                {
                    progressBar1.Value = (int)value;
                    if (value == 0) label5.Text = "Preparing";
                    else if (value < 25) label5.Text = "(1 of 4) Creating Countires";
                    else if (value < 50) label5.Text = "(2 of 4) Creating Cities";
                    else if (value < 75) label5.Text = "(3 of 4) Creating Map";
                    else if (value < 100) label5.Text = "(4 of 4) Assigning Ownership";
                    else label5.Text = "Complete!";
                });
            switch (ModeSelectComboBox.SelectedIndex)
            {
                case 0:
                    if (Image1Selection.Text != "" && OutputDestination.Text != "" && NameSelection.Text !="")
                    {
                        try
                        {
                            GenButton.Enabled = false;
                            ModeSelectComboBox.Enabled = false;
                            progressBar1.Visible = true;
                            label5.Visible = true;
                            await Task.Run(() =>
                            {
                                BasicMode.Generate((Bitmap)Image.FromFile(Image1Selection.Text), OutputDestination.Text, NameSelection.Text, progress);
                            });
                            MessageBox.Show("Your scenario has been generated");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "An Exception occured:");
                        }
                    }
                    else
                        MessageBox.Show("Please provide a name and input/output directories");
                    break;
                case 1:
                    if (Image1Selection.Text != "" && Image2Selection.Text != "" && OutputDestination.Text != "" && NameSelection.Text != "")
                    {
                        GenButton.Enabled = false;
                        ModeSelectComboBox.Enabled = false;
                        progressBar1.Visible = true;
                        label5.Visible = true;
                        await Task.Run(() =>
                        {
                            AdvMode.Generate((Bitmap)Image.FromFile(Image1Selection.Text), (Bitmap)Image.FromFile(Image2Selection.Text), OutputDestination.Text, NameSelection.Text, AdvancedCitiesCheckbox.Checked, progress);
                        });
                        MessageBox.Show("Your scenario has been generated");
                    }
                    else
                        MessageBox.Show("Please provide a name and input/output directories");
                    break;
                case 2:
                    if (Image1Selection.Text != "" && OutputDestination.Text != "" && NameSelection.Text != "")
                    {
                        try
                        {
                            GenButton.Enabled = false;
                            ModeSelectComboBox.Enabled = false;
                            progressBar1.Visible = true;
                            label5.Visible = true;
                            int ColorChannels = (int)Math.Pow(2, 8 - PosterizationTrackBar.Value);
                            await Task.Run(() =>
                            {
                                MapArtMode.Generate((Bitmap)Image.FromFile(Image1Selection.Text), OutputDestination.Text, NameSelection.Text, ColorChannels, progress);
                            });
                            MessageBox.Show("Your scenario has been generated");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "An Exception occured:");
                        }
                    }
                    else
                        MessageBox.Show("Please provide a name and input/output directories");
                    break;
                default:
                    MessageBox.Show("Please choose operating mode");
                    break;
            }
            GenButton.Enabled = true;
            ModeSelectComboBox.Enabled = true;
        }
    }
}