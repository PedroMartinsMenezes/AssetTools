namespace AssetTool
{
    [JsonAsset("AvaGameViewportMediaCapture")]
    public class UAvaGameViewportMediaCapture : UMediaCapture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}