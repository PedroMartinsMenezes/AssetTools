namespace AssetTool
{
    [JsonAsset("MoviePipelineExecutorBase")]
    public class UMoviePipelineExecutorBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}