namespace AssetTool
{
    [JsonAsset("AjaMediaCapture")]
    public class UAjaMediaCapture : UMediaCapture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}