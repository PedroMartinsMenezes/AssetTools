namespace AssetTool
{
    [JsonAsset("DaySequence")]
    public class UDaySequence : UMovieSceneSequence
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}