namespace AssetTool
{
    [JsonAsset("LevelSequenceDirector")]
    public class ULevelSequenceDirector : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LegacyLevelSequenceDirectorBlueprint")]
    public class ULegacyLevelSequenceDirectorBlueprint : UBlueprint
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}