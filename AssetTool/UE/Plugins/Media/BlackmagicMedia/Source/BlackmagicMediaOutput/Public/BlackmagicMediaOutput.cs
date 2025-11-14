namespace AssetTool
{
    [JsonAsset("BlackmagicMediaOutput")]
    public class UBlackmagicMediaOutput : UMediaOutput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}