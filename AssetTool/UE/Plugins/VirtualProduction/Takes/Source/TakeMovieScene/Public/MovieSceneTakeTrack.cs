namespace AssetTool
{
    [JsonAsset("MovieSceneTakeTrack")]
    public class UMovieSceneTakeTrack : UMovieSceneNameableTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}