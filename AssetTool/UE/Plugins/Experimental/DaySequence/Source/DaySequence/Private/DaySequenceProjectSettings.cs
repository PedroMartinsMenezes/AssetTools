namespace AssetTool
{
    [JsonAsset("DaySequenceProjectSettings")]
    public class UDaySequenceProjectSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}