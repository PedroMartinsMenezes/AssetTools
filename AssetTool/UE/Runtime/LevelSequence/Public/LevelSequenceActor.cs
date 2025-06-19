namespace AssetTool
{
    [JsonAsset("LevelSequenceBurnInInitSettings")]
    public class ULevelSequenceBurnInInitSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LevelSequenceBurnInOptions")]
    public class ULevelSequenceBurnInOptions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LevelSequenceActor")]
    public class ALevelSequenceActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReplicatedLevelSequenceActor")]
    public class AReplicatedLevelSequenceActor : ALevelSequenceActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}