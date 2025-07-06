namespace AssetTool
{
    [JsonAsset("MovieSceneTakeSection")]
    public class UMovieSceneTakeSection : UMovieSceneSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}