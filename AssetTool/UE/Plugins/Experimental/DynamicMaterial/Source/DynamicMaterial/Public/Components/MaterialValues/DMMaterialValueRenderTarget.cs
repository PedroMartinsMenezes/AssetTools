namespace AssetTool
{
    [JsonAsset("DMMaterialValueRenderTarget")]
    public class UDMMaterialValueRenderTarget : UDMMaterialValueTexture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}