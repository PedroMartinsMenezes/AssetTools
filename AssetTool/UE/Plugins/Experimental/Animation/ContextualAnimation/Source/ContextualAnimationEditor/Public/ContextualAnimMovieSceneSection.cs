namespace AssetTool
{
    [JsonAsset("ContextualAnimMovieSceneSection")]
    public class UContextualAnimMovieSceneSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}