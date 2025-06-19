namespace AssetTool
{
    [JsonAsset("DaySequence")]
    public class UDaySequence : UMovieSceneSequence
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}