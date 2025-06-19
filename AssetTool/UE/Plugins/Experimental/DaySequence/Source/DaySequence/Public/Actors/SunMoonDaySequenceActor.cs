namespace AssetTool
{
    [JsonAsset("SunMoonDaySequenceActor")]
    public class ASunMoonDaySequenceActor : ABaseDaySequenceActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}