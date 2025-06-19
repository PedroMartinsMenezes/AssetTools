namespace AssetTool
{
    [JsonAsset("InterchangeResultsContainer")]
    public class UInterchangeResultsContainer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}