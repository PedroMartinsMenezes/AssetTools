namespace AssetTool
{
    [JsonAsset("MoviePipelineLinearExecutorBase")]
    public class UMoviePipelineLinearExecutorBase : UMoviePipelineExecutorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}