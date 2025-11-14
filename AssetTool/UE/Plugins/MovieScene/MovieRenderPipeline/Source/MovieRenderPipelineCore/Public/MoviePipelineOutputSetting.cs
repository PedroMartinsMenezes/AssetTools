namespace AssetTool
{
    [JsonAsset("MoviePipelineOutputSetting")]
    public class UMoviePipelineOutputSetting : UMoviePipelineSetting
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}