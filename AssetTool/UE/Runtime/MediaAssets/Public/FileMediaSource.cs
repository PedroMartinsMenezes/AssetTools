namespace AssetTool
{
    [JsonAsset("FileMediaSource")]
    public class UFileMediaSource : UBaseMediaSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}