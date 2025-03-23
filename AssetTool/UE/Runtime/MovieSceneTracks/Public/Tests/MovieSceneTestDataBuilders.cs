namespace AssetTool
{
    [JsonAsset("MovieSceneTestSequence")]
    public class UMovieSceneTestSequence : UMovieSceneSequence
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}