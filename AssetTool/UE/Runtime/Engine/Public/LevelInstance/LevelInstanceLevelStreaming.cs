namespace AssetTool
{
    [JsonAsset("LevelStreamingLevelInstance")]
    public class ULevelStreamingLevelInstance : ULevelStreamingDynamic
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}