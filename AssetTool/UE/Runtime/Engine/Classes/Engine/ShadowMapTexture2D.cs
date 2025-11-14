namespace AssetTool
{
    [JsonAsset("ShadowMapTexture2D")]
    public class UShadowMapTexture2D : UTexture2D
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}