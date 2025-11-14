namespace AssetTool
{
    [JsonAsset("MoviePipelineBurnInSetting")]
    public class UMoviePipelineBurnInSetting : UMoviePipelineRenderPass
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}