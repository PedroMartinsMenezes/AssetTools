namespace AssetTool
{
    [JsonAsset("VehicleSimThrusterComponent")]
    public class UVehicleSimThrusterComponent : UVehicleSimBaseComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}