namespace AssetTool
{
    [JsonAsset("FleshComponent")]
    public class UFleshComponent : UDeformableGameplayComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}