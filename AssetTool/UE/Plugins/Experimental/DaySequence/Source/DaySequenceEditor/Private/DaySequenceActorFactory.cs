namespace AssetTool
{
    [JsonAsset("DaySequenceActorFactory")]
    public class UDaySequenceActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}