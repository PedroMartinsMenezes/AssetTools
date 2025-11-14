namespace AssetTool
{
    [JsonAsset("CurveVector")]
    public class UCurveVector : UCurveBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}