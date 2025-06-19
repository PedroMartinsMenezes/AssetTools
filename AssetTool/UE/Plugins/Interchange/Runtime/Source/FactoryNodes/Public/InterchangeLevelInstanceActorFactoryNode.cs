namespace AssetTool
{
    [JsonAsset("InterchangeLevelInstanceActorFactoryNode")]
    public class UInterchangeLevelInstanceActorFactoryNode : UInterchangeActorFactoryNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}