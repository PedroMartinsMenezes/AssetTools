namespace AssetTool
{
    [JsonAsset("CurveBase")]
    public class UCurveBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}