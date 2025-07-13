namespace AssetTool
{
    [JsonAsset("MutableTextureMipDataProviderFactory")]
    public class UMutableTextureMipDataProviderFactory : UTextureMipDataProviderFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}