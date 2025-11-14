namespace AssetTool
{
    [JsonAsset("WaterBodyInfoMeshComponent")]
    public class UWaterBodyInfoMeshComponent : UWaterBodyMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}