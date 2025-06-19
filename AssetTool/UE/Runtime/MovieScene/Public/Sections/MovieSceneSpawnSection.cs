namespace AssetTool
{
    [JsonAsset("MovieSceneSpawnSection")]
    public class UMovieSceneSpawnSection : UMovieSceneBoolSection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}