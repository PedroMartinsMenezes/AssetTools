namespace AssetTool
{
    [JsonAsset("MoviePipelineCameraSetting")]
    public class UMoviePipelineCameraSetting : UMoviePipelineSetting
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}