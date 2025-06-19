namespace AssetTool
{
    [JsonAsset("MoviePipelineColorSetting")]
    public class UMoviePipelineColorSetting : UMoviePipelineSetting
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}