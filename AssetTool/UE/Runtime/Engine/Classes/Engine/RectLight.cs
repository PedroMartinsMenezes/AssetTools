namespace AssetTool
{
    [JsonAsset("RectLight")]
    public class ARectLight : ALight
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}