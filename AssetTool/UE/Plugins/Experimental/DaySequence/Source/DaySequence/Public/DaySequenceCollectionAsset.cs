namespace AssetTool
{
    [JsonAsset("DaySequenceCollectionAsset")]
    public class UDaySequenceCollectionAsset : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}