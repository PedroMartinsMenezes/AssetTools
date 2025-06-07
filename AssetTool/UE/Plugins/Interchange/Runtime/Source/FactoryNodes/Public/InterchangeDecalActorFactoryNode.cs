namespace AssetTool
{
    [JsonAsset("InterchangeDecalActorFactoryNode")]
    public class UInterchangeDecalActorFactoryNode : UInterchangeActorFactoryNode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}