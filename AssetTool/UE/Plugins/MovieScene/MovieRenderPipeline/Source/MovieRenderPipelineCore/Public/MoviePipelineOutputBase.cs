namespace AssetTool
{
    [JsonAsset("MoviePipelineOutputBase")]
    public class UMoviePipelineOutputBase : UMoviePipelineSetting
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}