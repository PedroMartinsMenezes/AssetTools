namespace AssetTool
{
    [JsonAsset("MovieSceneSequence")]
    public class UMovieSceneSequence : UMovieSceneSignedObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}