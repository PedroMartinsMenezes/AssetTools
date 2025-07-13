namespace AssetTool
{
    [JsonAsset("RemoteSessionMediaOutput")]
    public class URemoteSessionMediaOutput : UMediaOutput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoteSessionMediaCapture")]
    public class URemoteSessionMediaCapture : UMediaCapture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}