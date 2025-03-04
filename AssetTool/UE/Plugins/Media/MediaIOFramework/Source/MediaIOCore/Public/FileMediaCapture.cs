namespace AssetTool
{
    [JsonAsset("FileMediaCapture")]
    public class UFileMediaCapture : UMediaCapture
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}