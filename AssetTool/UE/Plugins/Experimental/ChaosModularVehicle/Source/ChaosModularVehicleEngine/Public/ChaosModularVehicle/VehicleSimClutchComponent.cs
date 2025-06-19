namespace AssetTool
{
    [JsonAsset("VehicleSimClutchComponent")]
    public class UVehicleSimClutchComponent : UVehicleSimBaseComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}