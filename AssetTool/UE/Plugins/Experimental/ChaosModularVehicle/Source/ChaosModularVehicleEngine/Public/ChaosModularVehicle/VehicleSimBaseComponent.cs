namespace AssetTool
{
    [JsonAsset("VehicleSimBaseComponent")]
    public class UVehicleSimBaseComponent : UPrimitiveComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VehicleSimBaseSceneComponent")]
    public class UVehicleSimBaseSceneComponent : USceneComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}