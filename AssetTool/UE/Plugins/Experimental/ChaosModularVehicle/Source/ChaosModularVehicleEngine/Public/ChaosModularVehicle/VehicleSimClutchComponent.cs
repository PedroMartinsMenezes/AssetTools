namespace AssetTool
{
    [JsonAsset("VehicleSimClutchComponent")]
    public class UVehicleSimClutchComponent : UVehicleSimBaseComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}