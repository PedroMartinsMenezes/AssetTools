namespace AssetTool
{
    [JsonAsset("NDIMediaCapture")]
    public class UNDIMediaCapture : UMediaCapture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}