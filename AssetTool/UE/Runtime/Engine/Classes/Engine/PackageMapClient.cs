namespace AssetTool
{
    [JsonAsset("PackageMapClient")]
    public class UPackageMapClient : UPackageMap
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}