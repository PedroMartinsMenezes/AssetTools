namespace AssetTool
{
    [JsonAsset("VehicleSimChassisComponent")]
    public class UVehicleSimChassisComponent : UVehicleSimBaseComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}