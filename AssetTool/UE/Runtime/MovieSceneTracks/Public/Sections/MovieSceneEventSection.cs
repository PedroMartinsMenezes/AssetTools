namespace AssetTool
{
    [JsonAsset("MovieSceneEventSection")]
    public class UMovieSceneEventSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}