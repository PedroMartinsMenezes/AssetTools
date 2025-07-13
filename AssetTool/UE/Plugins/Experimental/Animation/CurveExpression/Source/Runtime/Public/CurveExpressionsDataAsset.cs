namespace AssetTool
{
    [JsonAsset("CurveExpressionsDataAsset")]
    public class UCurveExpressionsDataAsset : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}