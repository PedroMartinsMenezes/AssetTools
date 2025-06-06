namespace AssetTool
{
    [JsonAsset("VehicleSimChassisComponent")]
    public class UVehicleSimChassisComponent : UVehicleSimBaseComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}