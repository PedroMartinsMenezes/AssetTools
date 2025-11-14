namespace AssetTool
{
    [JsonAsset("MovieSceneSlomoSection")]
    public class UMovieSceneSlomoSection : UMovieSceneSection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}