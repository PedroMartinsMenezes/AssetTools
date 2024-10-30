namespace AssetTool
{
    [JsonAsset("MovieSceneSequence")]
    public class UMovieSceneSequence : UMovieSceneSignedObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}