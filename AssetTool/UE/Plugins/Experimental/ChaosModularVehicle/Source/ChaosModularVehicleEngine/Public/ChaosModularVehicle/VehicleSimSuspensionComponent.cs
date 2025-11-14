namespace AssetTool
{
    [JsonAsset("VehicleSimSuspensionComponent")]
    public class UVehicleSimSuspensionComponent : UVehicleSimBaseComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}