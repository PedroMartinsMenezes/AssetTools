namespace AssetTool
{
    [JsonAsset("RectLight")]
    public class ARectLight : ALight
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}