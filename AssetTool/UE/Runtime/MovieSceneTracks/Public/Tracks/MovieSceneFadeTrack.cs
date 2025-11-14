namespace AssetTool
{
    [JsonAsset("MovieSceneFadeTrack")]
    public class UMovieSceneFadeTrack : UMovieSceneFloatTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}