namespace AssetTool
{
    [JsonAsset("MoviePipelinePrimaryConfigFactory")]
    public class UMoviePipelinePrimaryConfigFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MoviePipelineShotConfigFactory")]
    public class UMoviePipelineShotConfigFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}