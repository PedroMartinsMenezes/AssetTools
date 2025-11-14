namespace AssetTool
{
    [JsonAsset("FileMediaCapture")]
    public class UFileMediaCapture : UMediaCapture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}