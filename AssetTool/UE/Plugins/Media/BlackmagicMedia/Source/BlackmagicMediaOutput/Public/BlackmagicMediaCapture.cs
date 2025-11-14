namespace AssetTool
{
    [JsonAsset("BlackmagicMediaCapture")]
    public class UBlackmagicMediaCapture : UMediaCapture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}