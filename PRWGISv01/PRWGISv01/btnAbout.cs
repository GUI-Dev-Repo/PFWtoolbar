using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace PRWGISv01
{
    public class btnAbout : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public btnAbout()
        {
        }

        protected override void OnClick()
        {
            ArcMap.Application.CurrentTool = null;
            Fm_About myform = new Fm_About();
            myform.ShowDialog();
        }

        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }
}
