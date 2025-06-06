namespace AssetTool
{
    [JsonAsset("DefaultModularVehicleInputModifier")]
    public class UDefaultModularVehicleInputModifier : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VehicleInputProducerBase")]
    public class UVehicleInputProducerBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}