/*
    This file is part of FontPicker

    FontPicker is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    FontPicker is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with FontPicker.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontPicker
{
    public partial class Form1 : Form
    {
        bool hasresults = false;
        bool haschange = false;
        bool needsearch = false;
        Dictionary<string, FontFamily> allfonts = new Dictionary<string, FontFamily>();
        string prevfolder;
        PrivateFontCollection privateFontCollection = new PrivateFontCollection();

        public Form1()
        {
            InitializeComponent();
            grpboxFontSize.Text = "Size: " + trkFontSize.Value.ToString();
            txtSearchPath.Text = prevfolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Fonts);
            RescanDatabase();
        }

        private void RescanDatabase()
        {
            try
            {
                if (txtSearchPath.Text.Trim().ToLowerInvariant() == System.Environment.GetFolderPath(System.Environment.SpecialFolder.Fonts).Trim().ToLowerInvariant())
                {
                    allfonts.Clear();
                    AddFontCollection(new InstalledFontCollection());
                    return;
                }
                else
                {
                    privateFontCollection = new PrivateFontCollection();
                    allfonts.Clear();
                    ScanFolderForFonts(privateFontCollection, txtSearchPath.Text, chkSubfolders.Checked);
                    AddFontCollection(privateFontCollection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while trying to scan for fonts:" + Environment.NewLine + ex.Message);
            }
        }

        private void AddFontCollection(FontCollection c)
        {
            FontFamily[] fontFamilies = c.Families;
            List<string> fonts = new List<string>();
            foreach (FontFamily font in fontFamilies)
            {
                allfonts.Add(font.Name, font);
            }
        }

        private void ScanFolderForFonts(PrivateFontCollection collection, string path, bool recursive)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fis = di.GetFiles();
            foreach (FileInfo f in fis)
            {
                string fn = f.Name.ToLowerInvariant();
                if (fn.EndsWith(".ttf") || fn.EndsWith(".otf"))
                {
                    try
                    {
                        collection.AddFontFile(f.FullName);
                    }
                    catch
                    {

                    }
                }
            }
            if (recursive)
            {
                DirectoryInfo[] subs = di.GetDirectories();
                foreach(DirectoryInfo d in subs)
                {
                    ScanFolderForFonts(collection, d.FullName, true);
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            try
            {
                base.WndProc(ref m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("WndProc Exception: " + ex.ToString());
            }
        }

        private void txtExample_TextChanged(object sender, EventArgs e)
        {
            haschange = true;
        }

        private void txtFontFilter_TextChanged(object sender, EventArgs e)
        {
            haschange = true;
        }

        void RefreshResults(string example, string filter)
        {
            example = example.Trim();
            filter = filter.Trim().ToLowerInvariant();

            txtSearchPath.Text = txtSearchPath.Text.Trim();
            if (txtSearchPath.Text.Length > 0)
            {
                if (txtSearchPath.Text.ToLowerInvariant() != prevfolder.ToLowerInvariant() || needsearch)
                {
                    RescanDatabase();
                    prevfolder = txtSearchPath.Text;
                    needsearch = true;
                }
            }

            Point oldscroll;
            oldscroll = panelContent.AutoScrollPosition;

            panelContent.SuspendLayout();

            while (panelContent.Controls.Count > 0)
            {
                foreach (Control control in panelContent.Controls)
                {
                    panelContent.Controls.Remove(control);
                    control.Dispose();
                }
            }

            SortedDictionary<string, FontFamily> filteredFonts = new SortedDictionary<string, FontFamily>();

            if (filter.Trim().Length > 0)
            {
                string[] commaparts = filter.Split(',', ';', '/', '\\');
                foreach (string commapart in commaparts)
                {
                    string[] spaceparts = commapart.Split(' ');
                    foreach (string key in allfonts.Keys)
                    {
                        bool found = spaceparts.Length > 0;
                        foreach (string spacepart in spaceparts)
                        {
                            if (key.ToLowerInvariant().Contains(spacepart.Trim()) == false)
                            {
                                found = false;
                            }
                        }
                        if (found && filteredFonts.ContainsKey(key) == false)
                        {
                            filteredFonts.Add(key, allfonts[key]);
                        }
                    }

                }
            }
            else
            {
                foreach (KeyValuePair<string, FontFamily> i in allfonts)
                {
                    filteredFonts.Add(i.Key, i.Value);
                }
            }

            int reqwidth = 0;
            foreach (KeyValuePair<string, FontFamily> i in filteredFonts)
            {
                if (i.Key.Length > reqwidth)
                {
                    reqwidth = i.Key.Length;
                }
            }

            int slider = trkFontSize.Value;

            int y = slider;
            int x1 = 10;
            int x2 = panelContent.Size.Width / 2;
            float sz = Convert.ToSingle(slider);
            foreach (KeyValuePair<string, FontFamily> i in filteredFonts)
            {
                Panel canvas = new Panel();
                canvas.Size = new Size(panelContent.Size.Width, Convert.ToInt32(Math.Ceiling(sz)) * 2);
                canvas.Padding = new System.Windows.Forms.Padding(0);
                canvas.Margin = new System.Windows.Forms.Padding(0);

                TextBox leftLabel = new TextBox();
                leftLabel.Enabled = true;
                leftLabel.ReadOnly = true;
                leftLabel.BackColor = Color.White;
                leftLabel.ForeColor = Color.Black;
                leftLabel.Text = i.Key;
                leftLabel.AutoSize = true;
                if (example.Length > 0)
                {
                    x1 = reqwidth * 8;
                    leftLabel.Location = new Point(0, 5);
                    leftLabel.Size = new Size(x1, Convert.ToInt32(Math.Ceiling(sz)) * 2);
                    leftLabel.Font = new Font(FontFamily.GenericMonospace, 10);
                    canvas.Controls.Add(leftLabel);
                    Label rightLabel = new Label();
                    rightLabel.Text = example;
                    rightLabel.Location = new Point(x1 + 3, 0);
                    rightLabel.Font = new Font(i.Value, sz);
                    rightLabel.Size = new Size(panelContent.Size.Width - x1 - 10, Convert.ToInt32(Math.Ceiling(sz)) * 2);
                    rightLabel.AutoSize = true;
                    rightLabel.Click += item_Focus;
                    canvas.Controls.Add(rightLabel);
                }
                else
                {
                    leftLabel.Location = new Point(0, 0);
                    leftLabel.Size = new Size(panelContent.Size.Width, Convert.ToInt32(Math.Ceiling(sz)) * 2);
                    leftLabel.Font = new Font(i.Value, sz);
                    canvas.Controls.Add(leftLabel);
                }
                panelContent.Click += item_Focus;
                panelContent.Controls.Add(canvas);
                y += Convert.ToInt32(Math.Ceiling(sz)) + 1;
                hasresults = true;
            }

            panelContent.ResumeLayout();

            try
            {
                panelContent.AutoScrollPosition = oldscroll;
            }
            catch
            {

            }

            panelContent.Focus();
            haschange = false;
        }

        void item_Focus(object sender, EventArgs e)
        {
            panelContent.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (haschange)
            {
                RefreshResults(txtExample.Text, txtFontFilter.Text);
            }
        }

        private void txtExample_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void txtFontFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void panelContent_Click(object sender, EventArgs e)
        {
            item_Focus(sender, e);
        }

        private void panelContent_MouseDown(object sender, MouseEventArgs e)
        {
            item_Focus(sender, e);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (txtExample.Text.Trim().Length > 0 && txtFontFilter.Text.Trim().Length > 0)
            {
                RefreshResults(txtExample.Text, txtFontFilter.Text);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (txtExample.Text.Trim().Length > 0 && txtFontFilter.Text.Trim().Length > 0)
            {
                RefreshResults(txtExample.Text, txtFontFilter.Text);
            }
        }

        private void btnSearchBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSearchPath.Text = fbd.SelectedPath;
                haschange = true;
            }
        }

        private void txtSearchPath_TextChanged(object sender, EventArgs e)
        {
            haschange = true;
        }

        private void chkSubfolders_CheckedChanged(object sender, EventArgs e)
        {
            haschange = true;
            needsearch = true;
        }

        private void trkFontSize_Scroll(object sender, EventArgs e)
        {
            grpboxFontSize.Text = "Size: " + trkFontSize.Value.ToString();
            if (hasresults)
            {
                timer1.Enabled = true;
                // a stop and start sequence essentially resets the timer back to 0
                timer1.Stop();
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hasresults)
            {
                if (txtExample.Text.Trim().Length > 0 && txtFontFilter.Text.Trim().Length > 0)
                {
                    RefreshResults(txtExample.Text, txtFontFilter.Text);
                }
                timer1.Enabled = false;
                timer1.Stop();
            }
        }
    }
}
