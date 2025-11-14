namespace AssetTool
{
    [JsonAsset("InterchangeFactoryBase")]
    public class UInterchangeFactoryBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}