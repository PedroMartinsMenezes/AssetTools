namespace AssetTool
{
    [JsonAsset("NetConnectionEOS")]
    public class UNetConnectionEOS : UIpConnection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}