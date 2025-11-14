namespace AssetTool
{
    [JsonAsset("ClientUnitTest")]
    public class UClientUnitTest : UProcessUnitTest
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}