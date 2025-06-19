namespace AssetTool
{
    [JsonAsset("VehicleSimAerofoilComponent")]
    public class UVehicleSimAerofoilComponent : UVehicleSimBaseComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}