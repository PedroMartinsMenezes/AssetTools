namespace AssetTool
{
    [JsonAsset("VPBookmark")]
    public class UVPBookmark : UBookmarkBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}