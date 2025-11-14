namespace AssetTool
{
    [JsonAsset("MoviePipelineViewFamilySetting")]
    public class UMoviePipelineViewFamilySetting : UMoviePipelineSetting
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}