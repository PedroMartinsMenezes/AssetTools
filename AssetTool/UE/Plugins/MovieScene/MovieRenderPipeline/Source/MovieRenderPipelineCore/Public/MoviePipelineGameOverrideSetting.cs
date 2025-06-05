namespace AssetTool
{
    [JsonAsset("MoviePipelineGameOverrideSetting")]
    public class UMoviePipelineGameOverrideSetting : UMoviePipelineSetting
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}