namespace AssetTool
{
    [JsonAsset("MovieSceneByteSection")]
    public class UMovieSceneByteSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}