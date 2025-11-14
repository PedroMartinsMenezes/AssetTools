namespace AssetTool
{
    [JsonAsset("MovieSceneSlomoTrack")]
    public class UMovieSceneSlomoTrack : UMovieSceneFloatTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}