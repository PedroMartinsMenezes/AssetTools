namespace AssetTool
{
    [JsonAsset("LocalHeightFogComponent")]
    public class ULocalHeightFogComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}