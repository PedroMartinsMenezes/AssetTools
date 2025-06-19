namespace AssetTool
{
    [JsonAsset("LevelSequenceDirector")]
    public class ULevelSequenceDirector : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LegacyLevelSequenceDirectorBlueprint")]
    public class ULegacyLevelSequenceDirectorBlueprint : UBlueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}