namespace AssetTool
{
    [JsonAsset("CurveVector")]
    public class UCurveVector : UCurveBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}