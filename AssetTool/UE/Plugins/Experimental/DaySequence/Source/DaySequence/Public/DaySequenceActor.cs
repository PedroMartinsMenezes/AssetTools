namespace AssetTool
{
    [JsonAsset("DaySequenceActor")]
    public class ADaySequenceActor : AInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}