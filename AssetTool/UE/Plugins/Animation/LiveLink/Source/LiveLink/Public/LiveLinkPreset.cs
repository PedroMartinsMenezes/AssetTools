namespace AssetTool
{
    [JsonAsset("LiveLinkPreset")]
    public class ULiveLinkPreset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}