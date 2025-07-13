namespace AssetTool
{
    [JsonAsset("UnitTestPackageMap")]
    public class UUnitTestPackageMap : UPackageMapClient
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}