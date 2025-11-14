namespace AssetTool
{
    [JsonAsset("MoviePipelineExecutorBase")]
    public class UMoviePipelineExecutorBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}