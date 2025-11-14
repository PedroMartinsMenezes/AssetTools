namespace AssetTool
{
    [JsonAsset("DisplayClusterMoviePipelineSettings")]
    public class UDisplayClusterMoviePipelineSettings : UMoviePipelineSetting
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}