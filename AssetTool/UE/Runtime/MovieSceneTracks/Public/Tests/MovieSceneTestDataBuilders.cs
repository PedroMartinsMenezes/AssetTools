namespace AssetTool
{
    [JsonAsset("MovieSceneTestSequence")]
    public class UMovieSceneTestSequence : UMovieSceneSequence
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}