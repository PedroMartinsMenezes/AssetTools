namespace AssetTool
{
    [JsonAsset("DaySequenceTrack")]
    public class UDaySequenceTrack : UMovieSceneSubTrack
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}