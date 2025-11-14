namespace AssetTool
{
    [JsonAsset("PackageMapClient")]
    public class UPackageMapClient : UPackageMap
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}