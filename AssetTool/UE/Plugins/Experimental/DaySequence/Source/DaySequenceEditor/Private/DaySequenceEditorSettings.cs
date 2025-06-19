namespace AssetTool
{
    [JsonAsset("DaySequenceEditorSettings")]
    public class UDaySequenceEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}