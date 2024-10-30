namespace AssetTool
{
    [JsonAsset("MovieSceneTrack")]
    public class UMovieSceneTrack : UMovieSceneSignedObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}