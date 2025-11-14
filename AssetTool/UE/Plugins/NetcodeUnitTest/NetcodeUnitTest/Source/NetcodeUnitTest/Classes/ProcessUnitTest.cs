namespace AssetTool
{
    [JsonAsset("ProcessUnitTest")]
    public class UProcessUnitTest : UUnitTest
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}