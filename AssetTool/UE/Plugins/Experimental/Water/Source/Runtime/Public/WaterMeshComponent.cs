namespace AssetTool
{
    [JsonAsset("WaterMeshComponent")]
    public class UWaterMeshComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}