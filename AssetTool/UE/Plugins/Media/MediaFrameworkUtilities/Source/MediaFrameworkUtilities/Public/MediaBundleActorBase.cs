namespace AssetTool
{
    [JsonAsset("MediaBundleActorBase")]
    public class AMediaBundleActorBase : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}