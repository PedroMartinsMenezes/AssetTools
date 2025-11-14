namespace AssetTool
{
    [JsonAsset("MovieSceneSpawnSection")]
    public class UMovieSceneSpawnSection : UMovieSceneBoolSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}