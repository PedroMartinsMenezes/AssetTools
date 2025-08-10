namespace AssetTool
{
    [JsonAsset("DNAAssetImportFactory")]
    public class UDNAAssetImportFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}