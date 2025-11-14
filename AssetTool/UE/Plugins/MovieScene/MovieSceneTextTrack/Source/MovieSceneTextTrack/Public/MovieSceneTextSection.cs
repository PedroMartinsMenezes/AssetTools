namespace AssetTool
{
    [JsonAsset("MovieSceneTextSection")]
    public class UMovieSceneTextSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}