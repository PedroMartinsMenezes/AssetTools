namespace AssetTool
{
    [JsonAsset("MovieSceneMediaSection")]
    public class UMovieSceneMediaSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}