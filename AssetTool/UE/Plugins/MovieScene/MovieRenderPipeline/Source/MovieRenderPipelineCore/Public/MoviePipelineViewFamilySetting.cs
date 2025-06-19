namespace AssetTool
{
    [JsonAsset("MoviePipelineViewFamilySetting")]
    public class UMoviePipelineViewFamilySetting : UMoviePipelineSetting
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}