namespace AssetTool
{
    [JsonAsset("MoviePipelineImagePassBase")]
    public class UMoviePipelineImagePassBase : UMoviePipelineRenderPass
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}