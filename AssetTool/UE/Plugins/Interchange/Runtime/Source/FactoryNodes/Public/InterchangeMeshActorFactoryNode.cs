namespace AssetTool
{
    [JsonAsset("InterchangeMeshActorFactoryNode")]
    public class UInterchangeMeshActorFactoryNode : UInterchangeActorFactoryNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}