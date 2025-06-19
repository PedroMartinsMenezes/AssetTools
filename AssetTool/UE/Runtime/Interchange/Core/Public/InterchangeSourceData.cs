namespace AssetTool
{
    [JsonAsset("InterchangeSourceData")]
    public class UInterchangeSourceData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}