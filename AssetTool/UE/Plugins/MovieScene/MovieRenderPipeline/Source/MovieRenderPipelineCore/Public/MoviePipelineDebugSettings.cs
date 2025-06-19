namespace AssetTool
{
    [JsonAsset("MoviePipelineDebugSettings")]
    public class UMoviePipelineDebugSettings : UMoviePipelineSetting
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}