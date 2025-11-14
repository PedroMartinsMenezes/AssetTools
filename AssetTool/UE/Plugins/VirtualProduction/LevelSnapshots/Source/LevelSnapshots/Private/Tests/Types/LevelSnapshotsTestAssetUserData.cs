namespace AssetTool
{
    [JsonAsset("LevelSnapshotsTestAssetUserData_Persistent")]
    public class ULevelSnapshotsTestAssetUserData_Persistent : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LevelSnapshotsTestAssetUserData_MarkedTransient")]
    public class ULevelSnapshotsTestAssetUserData_MarkedTransient : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LevelSnapshotsTestAssetUserData_TransientPackage")]
    public class ULevelSnapshotsTestAssetUserData_TransientPackage : UAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}