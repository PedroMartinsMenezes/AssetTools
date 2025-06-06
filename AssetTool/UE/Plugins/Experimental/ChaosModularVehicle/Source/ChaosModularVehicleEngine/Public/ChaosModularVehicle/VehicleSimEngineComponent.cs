namespace AssetTool
{
    [JsonAsset("VehicleSimEngineComponent")]
    public class UVehicleSimEngineComponent : UVehicleSimBaseComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}