namespace AssetTool
{
    [JsonAsset("VehicleSimWheelComponent")]
    public class UVehicleSimWheelComponent : UVehicleSimBaseComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}