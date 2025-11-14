namespace AssetTool
{
    [JsonAsset("MovieSceneHookSection")]
    public class UMovieSceneHookSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}