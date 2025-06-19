namespace AssetTool
{
    [JsonAsset("MoviePipelineRenderPass")]
    public class UMoviePipelineRenderPass : UMoviePipelineSetting
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}