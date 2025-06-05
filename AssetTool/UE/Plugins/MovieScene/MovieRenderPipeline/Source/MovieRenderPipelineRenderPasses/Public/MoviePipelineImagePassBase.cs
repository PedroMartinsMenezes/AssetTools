namespace AssetTool
{
    [JsonAsset("MoviePipelineImagePassBase")]
    public class UMoviePipelineImagePassBase : UMoviePipelineRenderPass
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}