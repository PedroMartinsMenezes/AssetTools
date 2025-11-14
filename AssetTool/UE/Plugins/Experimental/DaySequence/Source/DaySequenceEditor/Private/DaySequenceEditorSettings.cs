namespace AssetTool
{
    [JsonAsset("DaySequenceEditorSettings")]
    public class UDaySequenceEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}