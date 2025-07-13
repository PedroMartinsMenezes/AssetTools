namespace AssetTool
{
    [JsonAsset("LevelInstancePropertyOverridePolicy")]
    public class ULevelInstancePropertyOverridePolicy : UWorldPartitionPropertyOverridePolicy
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}