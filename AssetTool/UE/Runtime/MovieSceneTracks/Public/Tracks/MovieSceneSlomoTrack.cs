namespace AssetTool
{
    [JsonAsset("MovieSceneSlomoTrack")]
    public class UMovieSceneSlomoTrack : UMovieSceneFloatTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}