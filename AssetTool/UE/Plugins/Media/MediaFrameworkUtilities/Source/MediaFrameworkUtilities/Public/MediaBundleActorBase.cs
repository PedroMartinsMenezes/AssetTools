namespace AssetTool
{
    [JsonAsset("MediaBundleActorBase")]
    public class AMediaBundleActorBase : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}