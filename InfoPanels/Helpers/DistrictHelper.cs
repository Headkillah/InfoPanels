using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColossalFramework;

namespace InfoPanels.Helpers
{
    public class DistrictHelper
    {
        /*
        public List<District> Districts
        {
            
        }
        */

        public static int SomeNumber
        {
            get { return Singleton<DistrictManager>.instance.m_districts.m_buffer[0].m_finalCrimeRate; }
        }
    }
}
