namespace AssetTool
{
    [JsonAsset("DaySequenceActorFactory")]
    public class UDaySequenceActorFactory : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}