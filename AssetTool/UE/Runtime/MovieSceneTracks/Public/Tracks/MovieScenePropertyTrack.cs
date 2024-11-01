namespace AssetTool
{
    [JsonAsset("MovieScenePropertyTrack")]
    public class UMovieScenePropertyTrack : UMovieSceneNameableTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}