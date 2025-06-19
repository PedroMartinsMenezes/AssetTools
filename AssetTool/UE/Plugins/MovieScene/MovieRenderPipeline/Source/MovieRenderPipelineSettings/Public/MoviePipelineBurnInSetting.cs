namespace AssetTool
{
    [JsonAsset("MoviePipelineBurnInSetting")]
    public class UMoviePipelineBurnInSetting : UMoviePipelineRenderPass
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}