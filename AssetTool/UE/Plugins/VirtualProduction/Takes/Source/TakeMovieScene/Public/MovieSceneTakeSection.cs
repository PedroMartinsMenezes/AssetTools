namespace AssetTool
{
    [JsonAsset("MovieSceneTakeSection")]
    public class UMovieSceneTakeSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}