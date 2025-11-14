namespace AssetTool
{
    [JsonAsset("UnitTest")]
    public class UUnitTest : UUnitTestBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}