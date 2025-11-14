namespace AssetTool
{
    [JsonAsset("DaySequenceSubsystem")]
    public class UDaySequenceSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}