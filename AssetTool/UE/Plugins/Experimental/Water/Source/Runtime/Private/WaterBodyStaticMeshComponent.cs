namespace AssetTool
{
    [JsonAsset("WaterBodyStaticMeshComponent")]
    public class UWaterBodyStaticMeshComponent : UWaterBodyMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}