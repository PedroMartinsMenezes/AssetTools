namespace AssetTool
{
    [JsonAsset("InterchangeActorFactoryNode")]
    public class UInterchangeActorFactoryNode : UInterchangeFactoryBaseNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}