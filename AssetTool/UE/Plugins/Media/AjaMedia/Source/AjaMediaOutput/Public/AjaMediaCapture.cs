namespace AssetTool
{
    [JsonAsset("AjaMediaCapture")]
    public class UAjaMediaCapture : UMediaCapture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}