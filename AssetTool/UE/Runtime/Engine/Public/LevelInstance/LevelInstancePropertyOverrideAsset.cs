namespace AssetTool
{
    [JsonAsset("LevelInstancePropertyOverrideAsset")]
    public class ULevelInstancePropertyOverrideAsset : UWorldPartitionPropertyOverride
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}