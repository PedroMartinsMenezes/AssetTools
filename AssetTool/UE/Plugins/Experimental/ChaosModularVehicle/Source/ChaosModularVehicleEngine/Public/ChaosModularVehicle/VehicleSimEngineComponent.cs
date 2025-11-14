namespace AssetTool
{
    [JsonAsset("VehicleSimEngineComponent")]
    public class UVehicleSimEngineComponent : UVehicleSimBaseComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}