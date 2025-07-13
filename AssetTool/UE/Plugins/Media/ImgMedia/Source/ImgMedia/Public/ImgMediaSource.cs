namespace AssetTool
{
    [JsonAsset("ImgMediaSource")]
    public class UImgMediaSource : UBaseMediaSource
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}