namespace AssetTool
{
    [JsonAsset("MoviePipeline")]
    public class UMoviePipeline : UMoviePipelineBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MoviePipelineCustomTimeStep")]
    public class UMoviePipelineCustomTimeStep : UEngineCustomTimeStep
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}