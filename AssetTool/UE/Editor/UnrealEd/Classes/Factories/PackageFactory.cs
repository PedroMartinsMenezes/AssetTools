namespace AssetTool
{
    [JsonAsset("PackageFactory")]
    public class UPackageFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}