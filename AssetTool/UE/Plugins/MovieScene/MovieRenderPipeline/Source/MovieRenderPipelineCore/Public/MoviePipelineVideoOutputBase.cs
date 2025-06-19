namespace AssetTool
{
    [JsonAsset("MoviePipelineVideoOutputBase")]
    public class UMoviePipelineVideoOutputBase : UMoviePipelineOutputBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}