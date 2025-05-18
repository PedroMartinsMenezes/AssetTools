namespace AssetTool
{
    [JsonAsset("FleshComponent")]
    public class UFleshComponent : UDeformableGameplayComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}