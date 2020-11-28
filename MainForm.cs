using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalBuilder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Заполняет pictureBox белым
        /// </summary>
        private void FillPictureBox()
        {
            var bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = bitmap;
            g = Graphics.FromImage(bitmap);
            g.FillRectangle(Brushes.White, 0, 0, pictureBox.Width, pictureBox.Height);
        }

        private void DrawButtonClick(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem == comboBox.Items[0])
            {
                FillPictureBox();
                DrawFractalTree(pictureBox.Width / 2, 0, trackLength.Value, trackAngle.Value);
            }
            else if (comboBox.SelectedItem == comboBox.Items[1])
            {
                FillPictureBox();
                DrawBarnsleysFern(pictureBox.Width / 2, pictureBox.Height, trackLength.Value, Math.PI / 2);
            }
            else if (comboBox.SelectedItem == comboBox.Items[2])
            {
                FillPictureBox();
                int dir = 1;
                if (closedCheckBox.Checked) { dir = 6; }
                DrawQuasiCloverFractal(pictureBox.Width / 2, 3 * pictureBox.Height / 5, trackLength.Value, dir, trackLengthDivider.Value);
            }
        }

        private void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem == comboBox.Items[0])
            {
                trackLength.Minimum = 40;
                trackLength.Maximum = 300;
                trackLength.Value = 200;
                labelInitialLength.Text = "Initial length";
                trackLengthDivider.Minimum = 140;
                trackLengthDivider.Maximum = 240;
                trackLengthDivider.Value = 150;
                labelLengthDivider.Text = "Length divider";
                trackAngle.Minimum = -75;
                trackAngle.Maximum = 75;
                trackAngle.Value = 0;
                closedCheckBox.Enabled = false;
                assymetricalCheckBox.Enabled = true;
                trackAngle.Enabled = true;
            }
            else if (comboBox.SelectedItem == comboBox.Items[1])
            {
                trackLength.Minimum = 40;
                trackLength.Maximum = 300;
                trackLength.Value = 100;
                labelInitialLength.Text = "Initial length";
                trackLengthDivider.Minimum = 50;
                trackLengthDivider.Maximum = 200;
                trackLengthDivider.Value = 100;
                labelLengthDivider.Text = "Length divider";
                trackAngle.Minimum = 4;
                trackAngle.Maximum = 15;
                trackAngle.Value = 14;
                assymetricalCheckBox.Enabled = false;
                closedCheckBox.Enabled = false;
                trackAngle.Enabled = true;
            }
            else if (comboBox.SelectedItem == comboBox.Items[2])
            {
                trackLength.Minimum = 20;
                trackLength.Maximum = 300;
                trackLength.Value = 50;
                labelInitialLength.Text = "Radius";
                trackLengthDivider.Minimum = 1;
                trackLengthDivider.Maximum = 8;
                trackLengthDivider.Value = 5;
                labelLengthDivider.Text = "Depth";
                assymetricalCheckBox.Enabled = false;
                closedCheckBox.Enabled = true;
                trackAngle.Enabled = false;
            }
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save image as...";
                sfd.OverwritePrompt = true;
                sfd.CheckPathExists = true;
                sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                sfd.ShowHelp = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Unable to save image", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}