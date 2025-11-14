namespace AssetTool
{
    [JsonAsset("MoviePipelineVideoOutputBase")]
    public class UMoviePipelineVideoOutputBase : UMoviePipelineOutputBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}