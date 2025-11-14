namespace AssetTool
{
    [JsonAsset("LevelInstancePropertyOverridePolicy")]
    public class ULevelInstancePropertyOverridePolicy : UWorldPartitionPropertyOverridePolicy
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}