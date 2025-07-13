namespace AssetTool
{
    [JsonAsset("UnitTest")]
    public class UUnitTest : UUnitTestBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}