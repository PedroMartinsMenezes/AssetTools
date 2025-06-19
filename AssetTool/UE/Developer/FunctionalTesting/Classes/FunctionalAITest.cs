namespace AssetTool
{
    [JsonAsset("FunctionalAITestBase")]
    public class AFunctionalAITestBase : AFunctionalTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FunctionalAITest")]
    public class AFunctionalAITest : AFunctionalAITestBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}