namespace AssetTool
{
    [JsonAsset("MoviePipelineBase")]
    public class UMoviePipelineBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}