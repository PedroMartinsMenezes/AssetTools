namespace AssetTool
{
    [JsonAsset("BlackmagicMediaOutput")]
    public class UBlackmagicMediaOutput : UMediaOutput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}