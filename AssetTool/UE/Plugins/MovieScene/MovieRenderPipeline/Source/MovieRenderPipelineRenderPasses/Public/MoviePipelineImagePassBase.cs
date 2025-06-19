namespace AssetTool
{
    [JsonAsset("MoviePipelineImagePassBase")]
    public class UMoviePipelineImagePassBase : UMoviePipelineRenderPass
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}