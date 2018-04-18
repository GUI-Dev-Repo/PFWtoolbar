using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PRWGISv01
{
    public class btnPDF : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public btnPDF()
        {
        }

        protected override void OnClick()
        {
            //
            //  TODO: Sample code showing how to access button host
            //
            ArcMap.Application.CurrentTool = null;
            System.Diagnostics.Process.Start(@"C:\PFWGISBeta\pfw_data_dictionary.pdf");
        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
