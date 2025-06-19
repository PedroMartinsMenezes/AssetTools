namespace AssetTool
{
    [JsonAsset("LocalHeightFogComponent")]
    public class ULocalHeightFogComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}