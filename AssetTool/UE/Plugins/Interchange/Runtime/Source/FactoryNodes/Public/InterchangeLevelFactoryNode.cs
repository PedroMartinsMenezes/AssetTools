namespace AssetTool
{
    [JsonAsset("InterchangeLevelFactoryNode")]
    public class UInterchangeLevelFactoryNode : UInterchangeFactoryBaseNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}