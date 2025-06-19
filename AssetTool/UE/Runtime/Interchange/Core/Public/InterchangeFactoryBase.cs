namespace AssetTool
{
    [JsonAsset("InterchangeFactoryBase")]
    public class UInterchangeFactoryBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}