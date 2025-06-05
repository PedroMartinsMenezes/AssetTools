namespace AssetTool
{
    [JsonAsset("MoviePipelineOutputSetting")]
    public class UMoviePipelineOutputSetting : UMoviePipelineSetting
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}