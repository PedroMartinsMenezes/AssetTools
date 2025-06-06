namespace AssetTool
{
    [JsonAsset("VehicleSimWheelComponent")]
    public class UVehicleSimWheelComponent : UVehicleSimBaseComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}