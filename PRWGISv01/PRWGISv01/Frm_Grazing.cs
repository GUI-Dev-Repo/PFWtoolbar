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
    public partial class Frm_Grazing : Form
    {
        public Frm_Grazing()
        {
            InitializeComponent();
        }

        private void textLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            object item = ArcMap.Document.SelectedItem;
            IFeatureLayer featureLayer = item as FeatureLayer;
            IFeatureSelection featureSelection = featureLayer as IFeatureSelection;
            ISelectionSet selectionSet = featureSelection.SelectionSet;
            IFeatureClass featureClass = featureLayer.FeatureClass;
            ICursor cursor = null;

            selectionSet.Search(null, true, out cursor);
            IRow row = cursor.NextRow();
            //Queries
            int fieldStatus = featureLayer.FeatureClass.FindField("STATUS");
            int fieldYearComplete = featureLayer.FeatureClass.FindField("YEAR_COMPLETED");
            int fieldStart = featureLayer.FeatureClass.FindField("START_DATE");
            int fieldExp = featureLayer.FeatureClass.FindField("EXP_DATE");
            int fieldWEA = featureLayer.FeatureClass.FindField("RECORD_NO");
            int fieldFeature = featureLayer.FeatureClass.FindField("FEATURE");
            int fieldCreator = featureLayer.FeatureClass.FindField("DATAORIGIN");
            int fieldFirstName = featureLayer.FeatureClass.FindField("FIRST_NAME");
            int fieldLastName = featureLayer.FeatureClass.FindField("LAST_NAME");
            int fieldCounty = featureLayer.FeatureClass.FindField("COUNTY");
            int fieldState = featureLayer.FeatureClass.FindField("STATE");
            int fieldAcres = featureLayer.FeatureClass.FindField("Acres");
            int fieldComments = featureLayer.FeatureClass.FindField("COMMENTS");

            //Saves
            string statusSave = comboStatus.Text;
            string yearCompleteSave = comboYear.Text;
            string startDateSave = dateStart.Text;
            string expDateSave = dateExp.Text;
            string weaSave = textWEA.Text;
            string creatorSave = textCreator.Text;
            string firstNameSave = textFirstName.Text;
            string lastNameSave = textLastName.Text;
            string countySave = comboCounty.Text;
            string stateSave = comboState.Text;
            string acresSave = textAcres.Text;
            string commentsSave = richComments.Text;
            //Update row
            row.set_Value(fieldStatus, statusSave);
            row.set_Value(fieldYearComplete, yearCompleteSave);
            row.set_Value(fieldStart, startDateSave);
            row.set_Value(fieldExp, expDateSave);
            row.set_Value(fieldWEA, weaSave);
            row.set_Value(fieldCreator, creatorSave);
            row.set_Value(fieldFirstName, firstNameSave);
            row.set_Value(fieldLastName, lastNameSave);
            row.set_Value(fieldCounty, countySave);
            row.set_Value(fieldState, stateSave);
            row.set_Value(fieldAcres, acresSave);
            row.set_Value(fieldComments, commentsSave);
            row.Store();
            Close();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
