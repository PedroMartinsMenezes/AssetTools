namespace AssetTool
{
    [JsonAsset("DNAAsset")]
    public class UDNAAsset : UAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}