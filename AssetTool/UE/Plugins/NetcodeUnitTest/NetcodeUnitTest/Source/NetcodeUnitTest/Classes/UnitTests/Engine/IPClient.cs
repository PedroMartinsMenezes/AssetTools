namespace AssetTool
{
    [JsonAsset("IPClient")]
    public class UIPClient : UClientUnitTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}