namespace AssetTool
{
    [JsonAsset("MutableTextureMipDataProviderFactory")]
    public class UMutableTextureMipDataProviderFactory : UTextureMipDataProviderFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}