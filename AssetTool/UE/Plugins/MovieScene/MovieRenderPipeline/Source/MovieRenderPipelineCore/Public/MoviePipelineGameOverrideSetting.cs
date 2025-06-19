namespace AssetTool
{
    [JsonAsset("MoviePipelineGameOverrideSetting")]
    public class UMoviePipelineGameOverrideSetting : UMoviePipelineSetting
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}