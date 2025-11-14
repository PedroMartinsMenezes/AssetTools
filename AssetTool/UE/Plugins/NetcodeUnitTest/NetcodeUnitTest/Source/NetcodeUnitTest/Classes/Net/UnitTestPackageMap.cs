namespace AssetTool
{
    [JsonAsset("UnitTestPackageMap")]
    public class UUnitTestPackageMap : UPackageMapClient
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}