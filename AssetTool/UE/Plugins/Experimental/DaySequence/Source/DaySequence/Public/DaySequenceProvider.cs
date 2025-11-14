namespace AssetTool
{
    [JsonAsset("DaySequenceProvider")]
    public class ADaySequenceProvider : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}