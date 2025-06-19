namespace AssetTool
{
    [JsonAsset("AvaGameViewportMediaCapture")]
    public class UAvaGameViewportMediaCapture : UMediaCapture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}