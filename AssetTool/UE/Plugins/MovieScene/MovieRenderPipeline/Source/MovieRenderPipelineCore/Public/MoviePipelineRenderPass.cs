namespace AssetTool
{
    [JsonAsset("MoviePipelineRenderPass")]
    public class UMoviePipelineRenderPass : UMoviePipelineSetting
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}