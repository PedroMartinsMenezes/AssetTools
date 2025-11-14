namespace AssetTool
{
    [JsonAsset("InterchangeMeshActorFactoryNode")]
    public class UInterchangeMeshActorFactoryNode : UInterchangeActorFactoryNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}