namespace AssetTool
{
    [JsonAsset("SkinnedAsset")]
    public class USkinnedAsset : UStreamableRenderAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}