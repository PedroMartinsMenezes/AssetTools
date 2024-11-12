namespace AssetTool
{
    [JsonAsset("FXSystemAsset")]
    public class UFXSystemAsset : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
