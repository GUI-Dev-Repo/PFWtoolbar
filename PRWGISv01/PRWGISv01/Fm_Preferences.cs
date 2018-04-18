using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRWGISv01
{
    public partial class Fm_Preferences : Form
    {
        private Fm_addData frmAD;
        public Fm_Preferences()
        {
            InitializeComponent();
        }
        public string fdb1Location;
        private void Fm_Preferences_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseDb_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb1 = new FolderBrowserDialog();
            fdb1.ShowNewFolderButton = true;

            // Show the FolderBrowserDialog.
            DialogResult result = fdb1.ShowDialog();

            if (result == DialogResult.OK)

            {

                textLocationDb.Text = fdb1.SelectedPath;
                fdb1Location = fdb1.SelectedPath;
                PRWGIS_Config.FileGDBLocation = fdb1Location;
                Environment.SpecialFolder root = fdb1.RootFolder;
                //Fm_addData.setGDBPath(fdb1Location);

            }
        }

        private void btnBrowseTable_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb2 = new FolderBrowserDialog();
            fdb2.ShowNewFolderButton = true;

            // Show the FolderBrowserDialog.

            DialogResult result = fdb2.ShowDialog();

            if (result == DialogResult.OK)

            {

                textLocationTable.Text = fdb2.SelectedPath;

                Environment.SpecialFolder root = fdb2.RootFolder;

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
