namespace AssetTool
{
    [JsonAsset("DaySequenceSubsystem")]
    public class UDaySequenceSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}