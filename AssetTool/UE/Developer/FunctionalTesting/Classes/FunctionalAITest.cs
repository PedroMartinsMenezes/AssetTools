namespace AssetTool
{
    [JsonAsset("FunctionalAITestBase")]
    public class AFunctionalAITestBase : AFunctionalTest
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FunctionalAITest")]
    public class AFunctionalAITest : AFunctionalAITestBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}