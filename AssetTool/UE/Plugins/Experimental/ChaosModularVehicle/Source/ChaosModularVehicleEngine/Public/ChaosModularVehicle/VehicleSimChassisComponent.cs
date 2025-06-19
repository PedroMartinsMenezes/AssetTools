namespace AssetTool
{
    [JsonAsset("VehicleSimChassisComponent")]
    public class UVehicleSimChassisComponent : UVehicleSimBaseComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}