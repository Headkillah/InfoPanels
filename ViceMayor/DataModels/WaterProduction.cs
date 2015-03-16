using ViceMayor.Helpers;

namespace ViceMayor.DataModels
{
    public static class WaterProduction
    {
        public static int Capacity
        {
            get { return DistrictHelper.CurrentDistrict.GetWaterCapacity(); }
        }

        public static int Consumption
        {
            get { return DistrictHelper.CurrentDistrict.GetWaterConsumption(); }
        }
    }
}
