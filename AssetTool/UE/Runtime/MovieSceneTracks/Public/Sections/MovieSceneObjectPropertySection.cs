namespace AssetTool
{
    [JsonAsset("MovieSceneObjectPropertySection")]
    public class UMovieSceneObjectPropertySection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}