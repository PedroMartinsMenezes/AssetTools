namespace AssetTool
{
    [JsonAsset("RCExternalTexture")]
    public class URCExternalTexture : UTexture2DDynamic
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}