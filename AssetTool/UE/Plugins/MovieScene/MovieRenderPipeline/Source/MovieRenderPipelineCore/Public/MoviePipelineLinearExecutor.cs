namespace AssetTool
{
    [JsonAsset("MoviePipelineLinearExecutorBase")]
    public class UMoviePipelineLinearExecutorBase : UMoviePipelineExecutorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}