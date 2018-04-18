using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace PRWGISv01
{
    public class btnPref : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public btnPref()
        {
        }

        protected override void OnClick()
        {
            ArcMap.Application.CurrentTool = null;
            Fm_Preferences myform = new Fm_Preferences();
            myform.ShowDialog();
        }

        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }
}
