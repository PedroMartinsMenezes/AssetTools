namespace AssetTool
{
    [JsonAsset("MovieGraphTimeStepBase")]
    public class UMovieGraphTimeStepBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphEngineTimeStep")]
    public class UMovieGraphEngineTimeStep : UEngineCustomTimeStep
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphRendererBase")]
    public class UMovieGraphRendererBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphDataSourceBase")]
    public class UMovieGraphDataSourceBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MovieGraphAudioRendererBase")]
    public class UMovieGraphAudioRendererBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}