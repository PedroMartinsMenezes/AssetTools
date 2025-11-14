namespace AssetTool
{
    [JsonAsset("NDIMediaCapture")]
    public class UNDIMediaCapture : UMediaCapture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}