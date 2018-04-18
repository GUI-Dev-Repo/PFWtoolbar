using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.esriSystem;

namespace PRWGISv01
{
    public class attEdit : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public attEdit()
        {
        }

        public object Constants { get; private set; }
        //public string status { get; set; }
        public string statusProject { get; set; }
        public string yearCompleteProject { get; set; }
        public string startDateProject { get; set; }
        public string expDateProject { get; set; }
        public string weaProject { get; set; }
        public string featureProject { get; set; }
        public string creatorProject { get; set; }
        public string firstNameProject { get; set; }
        public string lastNameProject { get; set; }
        public string countyProject { get; set; }
        public string stateProject { get; set; }
        public string commentsProject { get; set; }

        protected override void OnClick()
        {
            UID pUID = new UIDClass();
            pUID.Value = "{40A9E885-5533-11d0-98BE-00805F7CED21}";
            IEnumLayer pMapLayers = ArcMap.Document.FocusMap.get_Layers(pUID, true);
            ILayer pThisLayer = pMapLayers.Next();
            while (pThisLayer != null) //change to for loop
            {
                if (pThisLayer.Valid)
                {
                    if (pThisLayer.Name == "Project Boundary")
                    {
                        try
                        {
                            IFeatureLayer featureLayer = pThisLayer as FeatureLayer;
                            IFeatureSelection featureSelection = featureLayer as IFeatureSelection;
                            ISelectionSet selectionSet = featureSelection.SelectionSet;
                            IFeatureClass featureClass = featureLayer.FeatureClass;
                            ICursor cursor = null;
                            selectionSet.Search(null, true, out cursor);
                            IRow row = cursor.NextRow();
                            int fieldStatus = featureLayer.FeatureClass.FindField("STATUS");
                            int fieldYearComplete = featureLayer.FeatureClass.FindField("YEAR_COMPLETED");
                            int fieldStart = featureLayer.FeatureClass.FindField("START_DATE");
                            int fieldExp = featureLayer.FeatureClass.FindField("EXP_DATE");
                            int fieldRecordNo = featureLayer.FeatureClass.FindField("RECORD_NO");
                            int fieldFeature = featureLayer.FeatureClass.FindField("FEATURE");
                            int fieldOrigin = featureLayer.FeatureClass.FindField("DATAORIGIN");
                            int fieldFirstName = featureLayer.FeatureClass.FindField("FIRST_NAME");
                            int fieldLastName = featureLayer.FeatureClass.FindField("LAST_NAME");
                            int fieldCounty = featureLayer.FeatureClass.FindField("COUNTY");
                            int fieldState = featureLayer.FeatureClass.FindField("STATE");
                            int fieldComments = featureLayer.FeatureClass.FindField("COMMENTS");
                            statusProject = row.get_Value(fieldStatus).ToString();
                            yearCompleteProject = row.get_Value(fieldYearComplete).ToString();
                            startDateProject = row.get_Value(fieldStart).ToString();
                            expDateProject = row.get_Value(fieldExp).ToString();
                            weaProject = row.get_Value(fieldRecordNo).ToString();
                            featureProject = row.get_Value(fieldFeature).ToString();
                            creatorProject = row.get_Value(fieldOrigin).ToString();
                            firstNameProject = row.get_Value(fieldFirstName).ToString();
                            lastNameProject = row.get_Value(fieldLastName).ToString();
                            countyProject = row.get_Value(fieldCounty).ToString();
                            stateProject = row.get_Value(fieldState).ToString();
                            commentsProject = row.get_Value(fieldComments).ToString();
                            break;
                        }
                        catch { MessageBox.Show("You must select a feature class in the Project Boundary layer."); }

                    }
                }
                pThisLayer = pMapLayers.Next();

            }
            object item = ArcMap.Document.SelectedItem; // could probably just set the initial query to always be project boundaries, grab all that data  store it, 
            //then when users select their added features it can reference that
            if (item is IFeatureLayer)
            {
                string insert = null;
                //string prjBndry = "Project Boundary";
                //string prjBorrow = "Borrow";
                //string prjGrazing = "pfwgrazing";
                //string prjPFWLines = "PFW Lines";
                //string prjPFWPoints = "PFW Points";
                //string prjUpland = "Upland Treatments";
                //string prjWetland = "Upland Treatments";
                IFeatureLayer featureLayer = item as FeatureLayer;
                IFeatureSelection featureSelection = featureLayer as IFeatureSelection;
                ISelectionSet selectionSet = featureSelection.SelectionSet;
                IFeatureClass featureClass = featureLayer.FeatureClass;
                string shapeField = featureClass.AliasName.ToString();
                insert = shapeField.ToString();
                if (insert != null)
                {
                    if (insert == "Project Boundary" || insert == "pfwproject_boundary")
                    {
                        try
                        {
                            ICursor cursor = null;
                            selectionSet.Search(null, true, out cursor);
                            IRow row = cursor.NextRow();

                            // define fields here
                            //int fieldStatus = featureLayer.FeatureClass.FindField("STATUS");
                            //int fieldYearComplete = featureLayer.FeatureClass.FindField("YEAR_COMPLETED");
                            //int fieldStart = featureLayer.FeatureClass.FindField("START_DATE");
                            //int fieldExp = featureLayer.FeatureClass.FindField("EXP_DATE");
                            //int fieldRecordNo = featureLayer.FeatureClass.FindField("RECORD_NO");
                            //int fieldFeature = featureLayer.FeatureClass.FindField("FEATURE");
                            //int fieldOrigin = featureLayer.FeatureClass.FindField("DATAORIGIN");
                            //int fieldFirstName = featureLayer.FeatureClass.FindField("FIRST_NAME");
                            //int fieldLastName = featureLayer.FeatureClass.FindField("LAST_NAME");
                            //int fieldCounty = featureLayer.FeatureClass.FindField("COUNTY");
                            //int fieldState = featureLayer.FeatureClass.FindField("STATE");
                            //int fieldComments = featureLayer.FeatureClass.FindField("COMMENTS");

                            // query feature class here
                            //string status = row.get_Value(fieldStatus).ToString();
                            //string yearComplete = row.get_Value(fieldYearComplete).ToString();
                            //string startDate = row.get_Value(fieldStart).ToString();
                            //string expDate = row.get_Value(fieldExp).ToString();
                            //string wea = row.get_Value(fieldRecordNo).ToString();
                            //string feature = row.get_Value(fieldFeature).ToString();
                            //string creator = row.get_Value(fieldOrigin).ToString();
                            //string firstName = row.get_Value(fieldFirstName).ToString();
                            //string lastName = row.get_Value(fieldLastName).ToString();
                            //string county = row.get_Value(fieldCounty).ToString();
                            //string state = row.get_Value(fieldState).ToString();
                            //string comments = row.get_Value(fieldComments).ToString();

                            // will put data searched into appropriate items for menu grid here
                            frm_prjBoundary gridForm = new frm_prjBoundary();
                            gridForm.comboStatus.Text = statusProject;
                            gridForm.comboYear.Text = yearCompleteProject;
                            gridForm.dateStart.Text = startDateProject;
                            gridForm.dateExp.Text = expDateProject;
                            gridForm.textWEA.Text = weaProject;
                            gridForm.textFeature.Text = featureProject;
                            gridForm.textCreator.Text = creatorProject;
                            gridForm.textFirstName.Text = firstNameProject;
                            gridForm.textLastName.Text = lastNameProject;
                            gridForm.comboCounty.Text = countyProject;
                            gridForm.comboState.Text = stateProject;
                            gridForm.richComments.Text = commentsProject;
                            gridForm.ShowDialog();

                        }
                        catch { MessageBox.Show("Select a feature from Project Boundary Layer"); }
                    }
                    else if (insert == "Borrow" || insert == "pfwborrow")
                    {
                        try
                        {

                            ICursor cursor = null;
                            selectionSet.Search(null, true, out cursor);
                            IRow row = cursor.NextRow();

                            // define fields here to find unique fields for Borrow Form
                            int fieldFirstName = featureLayer.FeatureClass.FindField("FIRST_NAME");
                            int fieldLastName = featureLayer.FeatureClass.FindField("LAST_NAME");
                            int fieldFeature = featureLayer.FeatureClass.FindField("FEATURE");
                            int fieldComments = featureLayer.FeatureClass.FindField("COMMENTS");
                            int fieldAcres = featureLayer.FeatureClass.FindField("Acres");

                            //// query feature class here / this is specific to Borrow Form
                            string firstName = row.get_Value(fieldFirstName).ToString();
                            string lastName = row.get_Value(fieldLastName).ToString();
                            string feature = row.get_Value(fieldFeature).ToString();
                            string comments = row.get_Value(fieldComments).ToString();
                            string acres = row.get_Value(fieldAcres).ToString();

                            // will put data searched into appropriate items for menu grid here
                            Frm_borrow borrowForm = new Frm_borrow();

                            //Standardized data from Project Boundary
                            borrowForm.comboStatus.Text = statusProject;
                            borrowForm.comboYear.Text = yearCompleteProject;
                            borrowForm.dateStart.Text = startDateProject;
                            borrowForm.dateExp.Text = expDateProject;
                            borrowForm.textWEA.Text = weaProject;
                            borrowForm.textCreator.Text = creatorProject;
                            borrowForm.comboCounty.Text = countyProject;
                            borrowForm.comboState.Text = stateProject;

                            //Data specific to Borrow Form
                            borrowForm.textFirstName.Text = firstName;
                            borrowForm.textLastName.Text = lastName;
                            borrowForm.textFeature.Text = feature;
                            borrowForm.richComments.Text = comments;
                            borrowForm.textAcres.Text = acres;
                            borrowForm.ShowDialog();
                        }
                        catch { MessageBox.Show("Select a feature from Borrow Layer"); }
                    }
                    else if (insert == "Grazing" || insert == "pfwgrazing")
                    {
                        try
                        {
                            ICursor cursor = null;
                            selectionSet.Search(null, true, out cursor);
                            IRow row = cursor.NextRow();

                            // define fields here to find unique fields for Grazing Form
                            int fieldFirstName = featureLayer.FeatureClass.FindField("FIRST_NAME");
                            int fieldLastName = featureLayer.FeatureClass.FindField("LAST_NAME");
                            int fieldComments = featureLayer.FeatureClass.FindField("COMMENTS");
                            int fieldFeature = featureLayer.FeatureClass.FindField("FEATURE");
                            int fieldAcres = featureLayer.FeatureClass.FindField("Acres");
                            int fieldLandCover = featureLayer.FeatureClass.FindField("LANDCOVER");
                            int fieldLandUse = featureLayer.FeatureClass.FindField("LANDUSE");
                            int fieldWeaAcres = featureLayer.FeatureClass.FindField("WEA_ACRES"); //not in use on form

                            //// query feature class here / this is specific to Grazing Form
                            string firstName = row.get_Value(fieldFirstName).ToString();
                            string lastName = row.get_Value(fieldLastName).ToString();
                            string comments = row.get_Value(fieldComments).ToString();
                            string feature = row.get_Value(fieldFeature).ToString();
                            string acres = row.get_Value(fieldAcres).ToString();
                            string landCover = row.get_Value(fieldLandCover).ToString();
                            string landUse = row.get_Value(fieldLandUse).ToString();
                            string weaAcres = row.get_Value(fieldWeaAcres).ToString(); //not in use on form

                            // will put data searched into appropriate items for menu grid here
                            Frm_Grazing grazingForm = new Frm_Grazing();
                            grazingForm.comboStatus.Text = statusProject;
                            grazingForm.comboYear.Text = yearCompleteProject;
                            grazingForm.dateStart.Text = startDateProject;
                            grazingForm.dateExp.Text = expDateProject;
                            grazingForm.textWEA.Text = weaProject;
                            grazingForm.textCreator.Text = creatorProject;
                            grazingForm.comboCounty.Text = countyProject;
                            grazingForm.comboState.Text = stateProject;

                            //Specific to Grazing form
                            grazingForm.textFirstName.Text = firstName;
                            grazingForm.textLastName.Text = lastName;
                            grazingForm.textFeature.Text = feature;
                            grazingForm.textAcres.Text = acres;
                            grazingForm.comboLandCover.Text = landCover;
                            grazingForm.comboLandUse.Text = landUse;
                            grazingForm.richComments.Text = comments;
                            //WEA ACRES IS NOT ON FORM SET UP BUT NOT IMPLEMENTED
                            //grazingForm.textWeaAcres.Text = weaAcres;
                            grazingForm.ShowDialog();
                        }
                        catch { MessageBox.Show("Select a feature from Grazing Layer"); }
                    }
                    else if (insert == "PFW Points" || insert == "pfwpoints")
                    {
                        try
                        {
                            ICursor cursor = null;
                            selectionSet.Search(null, true, out cursor);
                            IRow row = cursor.NextRow();

                            // define fields here to find unique fields for Grazing Form
                            int fieldFirstName = featureLayer.FeatureClass.FindField("FIRST_NAME");
                            int fieldLastName = featureLayer.FeatureClass.FindField("LAST_NAME");
                            int fieldComments = featureLayer.FeatureClass.FindField("COMMENTS");
                            int fieldFeature = featureLayer.FeatureClass.FindField("FEATURE");

                            // //// query feature class here / this is specific to PFWPoints Form
                            string firstName = row.get_Value(fieldFirstName).ToString();
                            string lastName = row.get_Value(fieldLastName).ToString();
                            string comments = row.get_Value(fieldComments).ToString();
                            string feature = row.get_Value(fieldFeature).ToString();

                            // // will put data searched into appropriate items for menu grid here
                            Frm_PFWPoints pfwPointsForm = new Frm_PFWPoints();
                            pfwPointsForm.comboStatus.Text = statusProject;
                            pfwPointsForm.comboYear.Text = yearCompleteProject;
                            pfwPointsForm.dateStart.Text = startDateProject;
                            pfwPointsForm.dateExp.Text = expDateProject;
                            pfwPointsForm.textWEA.Text = weaProject;
                            pfwPointsForm.textCreator.Text = creatorProject;
                            pfwPointsForm.comboCounty.Text = countyProject;
                            pfwPointsForm.comboState.Text = stateProject;

                            //// //Specific to PFWPoints form
                            pfwPointsForm.textFirstName.Text = firstName;
                            pfwPointsForm.textLastName.Text = lastName;
                            pfwPointsForm.comboFeature.Text = feature;
                            pfwPointsForm.richComments.Text = comments;
                            //WEA ACRES IS NOT ON FORM SET UP BUT NOT IMPLEMENTED
                            pfwPointsForm.ShowDialog();
                        }
                        catch { MessageBox.Show("Select a feature from Grazing Layer"); }
                    }
                }
            }
            //else
            //{
            //    MessageBox.Show("You must highlight the feature in the table of contents and select one matching feature to edit attributes on");
            //    MessageBox.Show(insert);
            //}

        }

        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }

    }

}
