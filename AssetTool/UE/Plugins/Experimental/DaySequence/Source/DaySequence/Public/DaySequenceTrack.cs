namespace AssetTool
{
    [JsonAsset("DaySequenceTrack")]
    public class UDaySequenceTrack : UMovieSceneSubTrack
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}