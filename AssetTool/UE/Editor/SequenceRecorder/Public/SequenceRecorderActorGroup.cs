namespace AssetTool
{
    [JsonAsset("SequenceRecorderActorGroup")]
    public class USequenceRecorderActorGroup : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SequenceRecorderGroup")]
    public class ASequenceRecorderGroup : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}