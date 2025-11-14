namespace AssetTool
{
    [JsonAsset("BaseDaySequenceActor")]
    public class ABaseDaySequenceActor : ADaySequenceActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}