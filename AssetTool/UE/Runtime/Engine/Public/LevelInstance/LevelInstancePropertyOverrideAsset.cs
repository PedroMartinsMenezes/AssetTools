namespace AssetTool
{
    [JsonAsset("LevelInstancePropertyOverrideAsset")]
    public class ULevelInstancePropertyOverrideAsset : UWorldPartitionPropertyOverride
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}