namespace AssetTool
{
    [JsonAsset("VehicleSimTransmissionComponent")]
    public class UVehicleSimTransmissionComponent : UVehicleSimBaseComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}