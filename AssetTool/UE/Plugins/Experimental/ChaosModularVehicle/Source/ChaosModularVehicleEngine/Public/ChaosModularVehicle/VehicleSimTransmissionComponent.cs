namespace AssetTool
{
    [JsonAsset("VehicleSimTransmissionComponent")]
    public class UVehicleSimTransmissionComponent : UVehicleSimBaseComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}