namespace AssetTool
{
    [JsonAsset("LevelStreamingLevelInstance")]
    public class ULevelStreamingLevelInstance : ULevelStreamingDynamic
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}