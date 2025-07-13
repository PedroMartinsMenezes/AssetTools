namespace AssetTool
{
    [JsonAsset("WaterBodyInfoMeshComponent")]
    public class UWaterBodyInfoMeshComponent : UWaterBodyMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}