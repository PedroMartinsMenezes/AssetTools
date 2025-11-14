namespace AssetTool
{
    [JsonAsset("MoviePipelineInProcessExecutor")]
    public class UMoviePipelineInProcessExecutor : UMoviePipelineLinearExecutorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}