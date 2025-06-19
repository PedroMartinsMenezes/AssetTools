namespace AssetTool
{
    [JsonAsset("MovieSceneSlomoSection")]
    public class UMovieSceneSlomoSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}