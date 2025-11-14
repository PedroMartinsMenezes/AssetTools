namespace AssetTool
{
    [JsonAsset("DaySequenceProjectSettings")]
    public class UDaySequenceProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}