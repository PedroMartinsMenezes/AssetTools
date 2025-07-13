namespace AssetTool
{
    [JsonAsset("NetBitsTest")]
    public class UNetBitsTest : UUnitTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}