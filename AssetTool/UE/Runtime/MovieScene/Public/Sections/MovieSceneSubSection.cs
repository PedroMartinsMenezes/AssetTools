namespace AssetTool
{
    [JsonAsset("MovieSceneSubSection")]
    public class UMovieSceneSubSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}