namespace AssetTool
{
    [JsonAsset("MovieSceneEventTrack")]
    public class UMovieSceneEventTrack : UMovieSceneNameableTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}