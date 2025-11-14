namespace AssetTool
{
    [JsonAsset("MovieSceneSequence")]
    public class UMovieSceneSequence : UMovieSceneSignedObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}