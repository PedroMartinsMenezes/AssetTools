namespace AssetTool
{
    [JsonAsset("PlatformMediaSource")]
    public class UPlatformMediaSource : UMediaSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}