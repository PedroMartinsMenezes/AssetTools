namespace AssetTool
{
    [JsonAsset("MovieSceneMediaSection")]
    public class UMovieSceneMediaSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}