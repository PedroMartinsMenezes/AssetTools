namespace AssetTool
{
    [JsonAsset("MoviePipelineAntiAliasingSetting")]
    public class UMoviePipelineAntiAliasingSetting : UMoviePipelineSetting
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}