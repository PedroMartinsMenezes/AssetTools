namespace AssetTool
{
    [JsonAsset("MovieSceneSection")]
    public class UMovieSceneSection : UMovieSceneSignedObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}