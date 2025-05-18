namespace AssetTool
{
    [JsonAsset("MoviePipelineBase")]
    public class UMoviePipelineBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}