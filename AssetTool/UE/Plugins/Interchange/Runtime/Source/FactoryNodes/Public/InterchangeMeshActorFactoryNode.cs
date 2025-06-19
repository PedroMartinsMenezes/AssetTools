namespace AssetTool
{
    [JsonAsset("InterchangeMeshActorFactoryNode")]
    public class UInterchangeMeshActorFactoryNode : UInterchangeActorFactoryNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}