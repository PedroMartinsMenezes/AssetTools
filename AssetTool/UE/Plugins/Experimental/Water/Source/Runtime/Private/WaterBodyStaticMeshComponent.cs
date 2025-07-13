namespace AssetTool
{
    [JsonAsset("WaterBodyStaticMeshComponent")]
    public class UWaterBodyStaticMeshComponent : UWaterBodyMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}