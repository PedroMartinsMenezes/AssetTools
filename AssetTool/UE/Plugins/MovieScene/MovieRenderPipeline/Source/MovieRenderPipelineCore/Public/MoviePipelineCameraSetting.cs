namespace AssetTool
{
    [JsonAsset("MoviePipelineCameraSetting")]
    public class UMoviePipelineCameraSetting : UMoviePipelineSetting
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}