using ColossalFramework;

namespace ViceMayor.Helpers
{
    public class DistrictHelper
    {
        private static DistrictManager _districtManager;

        public static District CurrentDistrict
        {
            get
            {
                return (_districtManager ?? (_districtManager = Singleton<DistrictManager>.instance)).m_districts.m_buffer[0];
            }
        }

        public static int CrimePercent
        {
            get
            {
                return CurrentDistrict.m_finalCrimeRate;
            }
        }

        public static int HappinessLevel
        {
            get
            {
                return CurrentDistrict.m_finalHappiness;
            }
        }
    }
}
