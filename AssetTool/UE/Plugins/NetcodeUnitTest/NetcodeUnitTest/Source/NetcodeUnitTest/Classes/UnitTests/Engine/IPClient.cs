namespace AssetTool
{
    [JsonAsset("IPClient")]
    public class UIPClient : UClientUnitTest
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}