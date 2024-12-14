namespace AssetTool
{
    [JsonAsset("InterchangeFactoryBase")]
    public class UInterchangeFactoryBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}