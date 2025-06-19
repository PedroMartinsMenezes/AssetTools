namespace AssetTool
{
    [JsonAsset("VehicleSimEngineComponent")]
    public class UVehicleSimEngineComponent : UVehicleSimBaseComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}