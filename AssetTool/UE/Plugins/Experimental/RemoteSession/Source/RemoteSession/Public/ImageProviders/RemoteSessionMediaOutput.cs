namespace AssetTool
{
    [JsonAsset("RemoteSessionMediaOutput")]
    public class URemoteSessionMediaOutput : UMediaOutput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RemoteSessionMediaCapture")]
    public class URemoteSessionMediaCapture : UMediaCapture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}