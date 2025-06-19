namespace AssetTool
{
    [JsonAsset("MoviePipelineOutputSetting")]
    public class UMoviePipelineOutputSetting : UMoviePipelineSetting
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}