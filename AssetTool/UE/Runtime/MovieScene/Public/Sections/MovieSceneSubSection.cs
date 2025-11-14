namespace AssetTool
{
    [JsonAsset("MovieSceneSubSection")]
    public class UMovieSceneSubSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}