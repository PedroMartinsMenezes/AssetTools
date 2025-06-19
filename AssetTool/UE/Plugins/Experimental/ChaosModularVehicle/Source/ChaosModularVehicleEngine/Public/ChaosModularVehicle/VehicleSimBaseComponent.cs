namespace AssetTool
{
    [JsonAsset("VehicleSimBaseComponent")]
    public class UVehicleSimBaseComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VehicleSimBaseSceneComponent")]
    public class UVehicleSimBaseSceneComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}