namespace AssetTool
{
    [JsonAsset("VehicleSimWheelComponent")]
    public class UVehicleSimWheelComponent : UVehicleSimBaseComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}