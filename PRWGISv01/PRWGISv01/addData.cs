using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Desktop;
using ESRI.ArcGIS.Editor;
using ESRI.ArcGIS.Geodatabase;


namespace PRWGISv01
{
    public class addData : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public addData()
        {
        }

        protected override void OnClick()
        {
            ArcMap.Application.CurrentTool = null;
            Fm_addData myform = new Fm_addData();
            myform.ShowDialog();
        }

        protected override void OnUpdate()
        {
        }
    }
}
