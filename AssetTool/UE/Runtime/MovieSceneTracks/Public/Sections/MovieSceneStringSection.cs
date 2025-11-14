namespace AssetTool
{
    [JsonAsset("MovieSceneStringSection")]
    public class UMovieSceneStringSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}