namespace AssetTool
{
    [JsonAsset("FleshComponent")]
    public class UFleshComponent : UDeformableGameplayComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}