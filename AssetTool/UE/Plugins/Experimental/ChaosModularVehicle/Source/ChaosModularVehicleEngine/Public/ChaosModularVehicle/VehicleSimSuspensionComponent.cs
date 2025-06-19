namespace AssetTool
{
    [JsonAsset("VehicleSimSuspensionComponent")]
    public class UVehicleSimSuspensionComponent : UVehicleSimBaseComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}