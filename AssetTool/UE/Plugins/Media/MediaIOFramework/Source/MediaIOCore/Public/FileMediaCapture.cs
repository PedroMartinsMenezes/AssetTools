namespace AssetTool
{
    [JsonAsset("FileMediaCapture")]
    public class UFileMediaCapture : UMediaCapture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}