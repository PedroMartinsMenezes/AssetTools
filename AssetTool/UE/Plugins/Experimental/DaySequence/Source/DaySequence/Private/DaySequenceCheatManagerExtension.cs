namespace AssetTool
{
    [JsonAsset("DaySequenceCheatManagerExtension")]
    public class UDaySequenceCheatManagerExtension : UCheatManagerExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}