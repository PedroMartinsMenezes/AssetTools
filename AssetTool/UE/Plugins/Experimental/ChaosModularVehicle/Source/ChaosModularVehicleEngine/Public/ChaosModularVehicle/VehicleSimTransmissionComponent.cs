namespace AssetTool
{
    [JsonAsset("VehicleSimTransmissionComponent")]
    public class UVehicleSimTransmissionComponent : UVehicleSimBaseComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}