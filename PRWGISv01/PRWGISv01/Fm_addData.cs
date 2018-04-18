using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;

namespace PRWGISv01
{
    public partial class Fm_addData : Form
    {
        IWorkspaceFactory workspaceFactory;
        List<string> nameFeatureClass;
        string gdbPath;
        public Fm_addData()
        {
            InitializeComponent();
            nameFeatureClass = new List<string>();
            Type factoryType = Type.GetTypeFromProgID("esriDataSourcesGDB.FileGDBWorkspaceFactory");
            workspaceFactory = (IWorkspaceFactory)Activator.CreateInstance(factoryType);
            gdbPath = PRWGIS_Config.FileGDBLocation;
            populateDictionary();
        }
        private void populateDictionary()
        {
            //IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspaceFactory.OpenFromFile(@"C:\PFWGISBeta\PFWGIS.gdb", 0);
            IEnumDataset fcEnum = workspaceFactory.OpenFromFile(gdbPath, 0).Datasets[esriDatasetType.esriDTFeatureClass];
            IDataset fcTemp;
            while ((fcTemp = fcEnum.Next()) != null)
            {
                nameFeatureClass.Add(fcTemp.BrowseName);

            }
            setFcList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            IFeatureWorkspace featureWorkspace = (IFeatureWorkspace)workspaceFactory.OpenFromFile(gdbPath, 0);
            // Create a FeatureLayer and assign a shapefile to it.
            IFeatureLayer featureLayer = new FeatureLayer();

            string fcName = fcList.Items[fcList.SelectedIndex].ToString();
            featureLayer.FeatureClass = featureWorkspace.OpenFeatureClass(fcName);
            ILayer layer = (ILayer)featureLayer;
            layer.Name = featureLayer.FeatureClass.AliasName;


            ESRI.ArcGIS.ArcMapUI.IMxDocument mxDocument = (ESRI.ArcGIS.ArcMapUI.IMxDocument)
                (ArcMap.Application.Document);
            IMap map = mxDocument.FocusMap;
            map.AddLayer(layer);
        }
        public void setGDBPath(string path)
        {
            gdbPath = path;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void fcList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Fm_addData_Load(object sender, EventArgs e)
        {

        }
    }
}
