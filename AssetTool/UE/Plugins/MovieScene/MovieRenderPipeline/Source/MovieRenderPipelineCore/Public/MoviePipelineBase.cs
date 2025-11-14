namespace AssetTool
{
    [JsonAsset("MoviePipelineBase")]
    public class UMoviePipelineBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}