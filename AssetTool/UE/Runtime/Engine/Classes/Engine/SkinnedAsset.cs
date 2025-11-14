namespace AssetTool
{
    [JsonAsset("SkinnedAsset")]
    public class USkinnedAsset : UStreamableRenderAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}