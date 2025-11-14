namespace AssetTool
{
    [JsonAsset("ImgMediaSource")]
    public class UImgMediaSource : UBaseMediaSource
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}