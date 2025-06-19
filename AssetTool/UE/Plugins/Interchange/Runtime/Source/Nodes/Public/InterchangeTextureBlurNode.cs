namespace AssetTool
{
    [JsonAsset("InterchangeTextureBlurNode")]
    public class UInterchangeTextureBlurNode : UInterchangeTexture2DNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}