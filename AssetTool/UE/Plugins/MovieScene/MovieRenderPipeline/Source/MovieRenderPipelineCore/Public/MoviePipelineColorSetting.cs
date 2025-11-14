namespace AssetTool
{
    [JsonAsset("MoviePipelineColorSetting")]
    public class UMoviePipelineColorSetting : UMoviePipelineSetting
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}