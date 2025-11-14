namespace AssetTool
{
    [JsonAsset("RectLight")]
    public class ARectLight : ALight
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}