namespace AssetTool
{
    [JsonAsset("SkinnedAsset")]
    public class USkinnedAsset : UStreamableRenderAsset
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}