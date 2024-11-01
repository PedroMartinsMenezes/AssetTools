namespace AssetTool
{
    [JsonAsset("MovieSceneTransformTrack")]
    public class UMovieSceneTransformTrack : UMovieScenePropertyTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}