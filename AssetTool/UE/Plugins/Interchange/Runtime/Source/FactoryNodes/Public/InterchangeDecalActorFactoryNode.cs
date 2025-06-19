namespace AssetTool
{
    [JsonAsset("InterchangeDecalActorFactoryNode")]
    public class UInterchangeDecalActorFactoryNode : UInterchangeActorFactoryNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}