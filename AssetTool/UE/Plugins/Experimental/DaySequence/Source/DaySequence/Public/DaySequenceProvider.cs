namespace AssetTool
{
    [JsonAsset("DaySequenceProvider")]
    public class ADaySequenceProvider : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}