namespace AssetTool
{
    [JsonAsset("InterchangeBaseNodeContainer")]
    public class UInterchangeBaseNodeContainer : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}