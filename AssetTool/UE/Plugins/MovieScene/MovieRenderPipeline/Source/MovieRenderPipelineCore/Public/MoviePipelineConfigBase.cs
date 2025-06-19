namespace AssetTool
{
    [JsonAsset("MoviePipelineConfigBase")]
    public class UMoviePipelineConfigBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}