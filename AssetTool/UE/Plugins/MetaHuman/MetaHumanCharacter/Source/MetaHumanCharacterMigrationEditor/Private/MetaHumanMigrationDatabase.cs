namespace AssetTool
{
    [JsonAsset("MetaHumanMigrationAssetCollection")]
    public class UMetaHumanMigrationAssetCollection : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanMigrationDatabase")]
    public class UMetaHumanMigrationDatabase : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}