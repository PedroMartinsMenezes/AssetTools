namespace AssetTool
{
    [JsonAsset("MovieSceneSubTrack")]
    public class UMovieSceneSubTrack : UMovieSceneNameableTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}