namespace AssetTool
{
    [JsonAsset("MovieSceneObjectPropertyTrack")]
    public class UMovieSceneObjectPropertyTrack : UMovieScenePropertyTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}