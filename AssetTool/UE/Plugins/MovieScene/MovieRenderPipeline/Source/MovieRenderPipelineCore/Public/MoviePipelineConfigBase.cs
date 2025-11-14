namespace AssetTool
{
    [JsonAsset("MoviePipelineConfigBase")]
    public class UMoviePipelineConfigBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}