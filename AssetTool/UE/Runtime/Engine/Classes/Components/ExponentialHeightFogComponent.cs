namespace AssetTool
{
    [JsonAsset("ExponentialHeightFogComponent")]
    public class UExponentialHeightFogComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}