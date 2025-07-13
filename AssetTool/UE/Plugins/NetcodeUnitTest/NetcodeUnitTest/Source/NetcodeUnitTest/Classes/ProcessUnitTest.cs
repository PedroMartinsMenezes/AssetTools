namespace AssetTool
{
    [JsonAsset("ProcessUnitTest")]
    public class UProcessUnitTest : UUnitTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}