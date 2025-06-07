namespace AssetTool
{
    [JsonAsset("DaySequenceTrack")]
    public class UDaySequenceTrack : UMovieSceneSubTrack
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}