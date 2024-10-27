namespace AssetTool
{
    [JsonAsset("MovieSceneSpawnSection")]
    public class  UMovieSceneSpawnSection : UMovieSceneBoolSection
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}