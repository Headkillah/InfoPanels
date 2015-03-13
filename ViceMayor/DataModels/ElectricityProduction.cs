using ViceMayor.Helpers;

namespace ViceMayor.DataModels
{
    public static class ElectricityProduction
    {
        public static int Capacity
        {
            get { return DistrictHelper.CurrentDistrict.GetElectricityCapacity(); }
        }

        public static int Consumption
        {
            get { return DistrictHelper.CurrentDistrict.GetElectricityConsumption(); }
        }
    }
}
