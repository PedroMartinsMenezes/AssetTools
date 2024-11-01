namespace AssetTool
{
    [JsonAsset("MovieSceneSlomoTrack")]
    public class UMovieSceneSlomoTrack : UMovieSceneFloatTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}