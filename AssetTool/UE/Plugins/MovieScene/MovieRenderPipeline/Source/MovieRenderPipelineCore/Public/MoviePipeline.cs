namespace AssetTool
{
    [JsonAsset("MoviePipeline")]
    public class UMoviePipeline : UMoviePipelineBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MoviePipelineCustomTimeStep")]
    public class UMoviePipelineCustomTimeStep : UEngineCustomTimeStep
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}