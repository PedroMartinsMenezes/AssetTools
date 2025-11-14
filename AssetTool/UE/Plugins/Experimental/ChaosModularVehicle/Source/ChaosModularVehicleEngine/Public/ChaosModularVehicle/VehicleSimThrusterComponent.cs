namespace AssetTool
{
    [JsonAsset("VehicleSimThrusterComponent")]
    public class UVehicleSimThrusterComponent : UVehicleSimBaseComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}