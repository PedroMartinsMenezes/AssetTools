namespace AssetTool
{
    [JsonAsset("VPBookmark")]
    public class UVPBookmark : UBookmarkBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}