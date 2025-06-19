namespace AssetTool
{
    [JsonAsset("BaseDaySequenceActor")]
    public class ABaseDaySequenceActor : ADaySequenceActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}