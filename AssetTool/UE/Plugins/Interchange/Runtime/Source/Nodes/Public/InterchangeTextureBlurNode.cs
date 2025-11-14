namespace AssetTool
{
    [JsonAsset("InterchangeTextureBlurNode")]
    public class UInterchangeTextureBlurNode : UInterchangeTexture2DNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}