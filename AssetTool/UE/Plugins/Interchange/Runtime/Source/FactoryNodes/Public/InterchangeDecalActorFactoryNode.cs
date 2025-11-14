namespace AssetTool
{
    [JsonAsset("InterchangeDecalActorFactoryNode")]
    public class UInterchangeDecalActorFactoryNode : UInterchangeActorFactoryNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}