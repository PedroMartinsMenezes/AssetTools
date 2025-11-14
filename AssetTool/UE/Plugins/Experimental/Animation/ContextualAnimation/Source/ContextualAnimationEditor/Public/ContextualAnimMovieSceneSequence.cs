namespace AssetTool
{
    [JsonAsset("ContextualAnimMovieSceneSequence")]
    public class UContextualAnimMovieSceneSequence : UMovieSceneSequence
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}