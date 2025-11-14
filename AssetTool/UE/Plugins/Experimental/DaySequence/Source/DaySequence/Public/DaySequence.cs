namespace AssetTool
{
    [JsonAsset("DaySequence")]
    public class UDaySequence : UMovieSceneSequence
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}