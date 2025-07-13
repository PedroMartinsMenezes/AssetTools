namespace AssetTool
{
    [JsonAsset("UnitTestBase")]
    public class UUnitTestBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}