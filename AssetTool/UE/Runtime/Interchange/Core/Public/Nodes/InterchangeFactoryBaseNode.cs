namespace AssetTool
{
    [JsonAsset("InterchangeFactoryBaseNode")]
    public class UInterchangeFactoryBaseNode : UInterchangeBaseNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}