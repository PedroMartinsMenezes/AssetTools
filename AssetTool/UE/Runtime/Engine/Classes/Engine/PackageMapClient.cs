namespace AssetTool
{
    [JsonAsset("PackageMapClient")]
    public class UPackageMapClient : UPackageMap
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}