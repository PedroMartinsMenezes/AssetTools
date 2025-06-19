namespace AssetTool
{
    [JsonAsset("MovieSceneTestSequence")]
    public class UMovieSceneTestSequence : UMovieSceneSequence
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}