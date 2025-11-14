namespace AssetTool
{
    [JsonAsset("VehicleSimAerofoilComponent")]
    public class UVehicleSimAerofoilComponent : UVehicleSimBaseComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}