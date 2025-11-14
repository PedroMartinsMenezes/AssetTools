namespace AssetTool
{
    [JsonAsset("VehicleSimBaseComponent")]
    public class UVehicleSimBaseComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VehicleSimBaseSceneComponent")]
    public class UVehicleSimBaseSceneComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}