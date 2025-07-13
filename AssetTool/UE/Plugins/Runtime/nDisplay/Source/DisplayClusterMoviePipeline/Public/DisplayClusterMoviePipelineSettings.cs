namespace AssetTool
{
    [JsonAsset("DisplayClusterMoviePipelineSettings")]
    public class UDisplayClusterMoviePipelineSettings : UMoviePipelineSetting
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}