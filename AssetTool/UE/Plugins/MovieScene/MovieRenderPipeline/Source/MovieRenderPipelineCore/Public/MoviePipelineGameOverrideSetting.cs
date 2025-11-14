namespace AssetTool
{
    [JsonAsset("MoviePipelineGameOverrideSetting")]
    public class UMoviePipelineGameOverrideSetting : UMoviePipelineSetting
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}