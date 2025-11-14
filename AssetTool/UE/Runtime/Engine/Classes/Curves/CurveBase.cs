namespace AssetTool
{
    [JsonAsset("CurveBase")]
    public class UCurveBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}