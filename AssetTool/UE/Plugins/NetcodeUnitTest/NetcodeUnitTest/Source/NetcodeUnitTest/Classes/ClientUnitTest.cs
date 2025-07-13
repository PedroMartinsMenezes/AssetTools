namespace AssetTool
{
    [JsonAsset("ClientUnitTest")]
    public class UClientUnitTest : UProcessUnitTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}