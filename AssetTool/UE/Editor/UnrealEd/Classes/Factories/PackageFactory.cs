namespace AssetTool
{
    [JsonAsset("PackageFactory")]
    public class UPackageFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}