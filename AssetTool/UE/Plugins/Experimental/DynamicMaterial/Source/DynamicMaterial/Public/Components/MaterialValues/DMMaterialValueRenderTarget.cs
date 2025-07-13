namespace AssetTool
{
    [JsonAsset("DMMaterialValueRenderTarget")]
    public class UDMMaterialValueRenderTarget : UDMMaterialValueTexture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}