using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RegionMapping;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace GUI {
    public partial class SelectWorldForm : Form {
        private Map Map = new Map();
        private List<RegionIndex> RegionIndexes = new List<RegionIndex>();
        private MapRange MapRange = new MapRange();

        public SelectWorldForm()
        {
            InitializeComponent();
        }

        //Controls
        private void BrowseWorldButton_Click(object sender, EventArgs e)
        {
            BrowserDialog.ShowDialog();
            if (BrowserDialog.SelectedPath == "") {
                return;
            }

            WorldPathTextBox.Text = BrowserDialog.SelectedPath;

            if (!TryLoadingIndexes()) {
                return;
            }

            SetAllRegionRangeTextBox();
            AllRegionsCheckBox.Checked = true;
        }
        private void AllRegionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AllRegionsCheckBox.Checked) {
                SetAllRegionRangeTextBox();
            }
        }

        private void CreateMapButton_Click(object sender, EventArgs e)
        {
            Range range;

            if (!IsSafeToGetMap(out range)) {
                return;
            }

            try {
                Map.GetWorldMap(WorldPathTextBox.Text, range);
            } catch {
                ShowErrorMessage("There was a problem creating the map.");

                return;
            }

            if (SaveTextBox.Text != "") {
                if (Directory.Exists(Path.GetDirectoryName(SaveTextBox.Text))) {
                    Tools.SaveImage(Map.Image, SaveTextBox.Text);
                }
            }

            ImageViewer imageViewer = new ImageViewer(Map.Image);
            imageViewer.ShowDialog();
        }

        private void ShowErrorMessage(string message) {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Scripts
        private bool TryLoadingIndexes() {
            if (!Directory.Exists(WorldPathTextBox.Text + @"\region")) {
                ShowErrorMessage("Couldn't find the region folder.");

                return false;
            }

            try {
                RegionIndexes = RegionIndex.GetAllIndexes(WorldPathTextBox.Text + @"\region");
            } catch{
                ShowErrorMessage("There was a problem getting all region indexes.");

                return false;
            }

            MapRange = MapRange.GetRange(RegionIndexes);

            return true;
        }
        private void SetAllRegionRangeTextBox() {
            RegionRangeTextBox.Text = MapRange.XStart + ", " + MapRange.ZStart + "; " + MapRange.XEnd + ", " + MapRange.ZEnd;
        }

        private bool IsSafeToGetMap(out Range range) {
            if (!Directory.Exists(WorldPathTextBox.Text + @"\region")) {
                range = new Range();

                ShowErrorMessage("Couldn't find the region folder.");

                return false;
            }

            try {
                range = Range.FromString(RegionRangeTextBox.Text);
            } catch{
                range = new Range();

                ShowErrorMessage("Region range isn't in the correct format.");

                return false;
            }

            return true;
        }

        private void BrowseSaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog.ShowDialog();
            if (SaveFileDialog.FileName == "") {
                return;
            }

            if (!Directory.Exists(Path.GetDirectoryName(SaveFileDialog.FileName))) {
                ShowErrorMessage("Path is incorrect");

                return;
            }

            SaveTextBox.Text = SaveFileDialog.FileName;
        }
    }
}
