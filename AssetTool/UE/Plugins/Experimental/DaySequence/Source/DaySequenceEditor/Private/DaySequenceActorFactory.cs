namespace AssetTool
{
    [JsonAsset("DaySequenceActorFactory")]
    public class UDaySequenceActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}