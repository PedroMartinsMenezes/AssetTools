namespace AssetTool
{
    [JsonAsset("PackageFactory")]
    public class UPackageFactory : UFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}