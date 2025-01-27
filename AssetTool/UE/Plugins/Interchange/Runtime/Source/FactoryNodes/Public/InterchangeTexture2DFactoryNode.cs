namespace AssetTool
{
    [JsonAsset("InterchangeTexture2DFactoryNode")]
    public class UInterchangeTexture2DFactoryNode : UInterchangeTextureFactoryNode
    {
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }
}