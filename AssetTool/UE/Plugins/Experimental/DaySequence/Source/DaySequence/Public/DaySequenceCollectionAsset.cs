namespace AssetTool
{
    [JsonAsset("DaySequenceCollectionAsset")]
    public class UDaySequenceCollectionAsset : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}