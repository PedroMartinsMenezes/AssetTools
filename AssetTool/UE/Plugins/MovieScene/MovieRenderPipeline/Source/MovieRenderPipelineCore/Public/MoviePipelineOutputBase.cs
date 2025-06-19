namespace AssetTool
{
    [JsonAsset("MoviePipelineOutputBase")]
    public class UMoviePipelineOutputBase : UMoviePipelineSetting
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}