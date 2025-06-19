namespace AssetTool
{
    [JsonAsset("InterchangeBaseNodeContainer")]
    public class UInterchangeBaseNodeContainer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}