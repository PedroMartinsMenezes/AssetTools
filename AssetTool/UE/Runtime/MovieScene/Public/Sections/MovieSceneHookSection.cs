namespace AssetTool
{
    [JsonAsset("MovieSceneHookSection")]
    public class UMovieSceneHookSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}