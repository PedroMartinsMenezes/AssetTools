namespace AssetTool
{
    [JsonAsset("InterchangeFactoryBaseNode")]
    public class UInterchangeFactoryBaseNode : UInterchangeBaseNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}