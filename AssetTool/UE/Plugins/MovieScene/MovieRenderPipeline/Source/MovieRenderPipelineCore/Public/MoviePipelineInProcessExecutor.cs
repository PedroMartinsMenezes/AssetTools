namespace AssetTool
{
    [JsonAsset("MoviePipelineInProcessExecutor")]
    public class UMoviePipelineInProcessExecutor : UMoviePipelineLinearExecutorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}