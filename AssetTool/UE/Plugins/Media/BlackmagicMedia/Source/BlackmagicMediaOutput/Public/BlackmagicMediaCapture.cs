namespace AssetTool
{
    [JsonAsset("BlackmagicMediaCapture")]
    public class UBlackmagicMediaCapture : UMediaCapture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}