namespace AssetTool
{
    [JsonAsset("InterchangeTexture2DFactoryNode")]
    public class UInterchangeTexture2DFactoryNode : UInterchangeBaseNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}