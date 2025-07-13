namespace AssetTool
{
    [JsonAsset("WaterBodyMeshComponent")]
    public class UWaterBodyMeshComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}