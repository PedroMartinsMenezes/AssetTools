namespace AssetTool
{
    [JsonAsset("MovieSceneTakeTrack")]
    public class UMovieSceneTakeTrack : UMovieSceneNameableTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}