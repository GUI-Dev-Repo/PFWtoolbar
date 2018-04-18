using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRWGISv01
{
    class PRWGIS_Config
    {
        static string fileGDBLocation;

        public static string FileGDBLocation
        {
            get
            {
                return fileGDBLocation;
            }

            set
            {
                fileGDBLocation = value;
            }
        }
    }
}
