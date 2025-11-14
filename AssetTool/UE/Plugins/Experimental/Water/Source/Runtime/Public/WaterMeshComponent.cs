namespace AssetTool
{
    [JsonAsset("WaterMeshComponent")]
    public class UWaterMeshComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}