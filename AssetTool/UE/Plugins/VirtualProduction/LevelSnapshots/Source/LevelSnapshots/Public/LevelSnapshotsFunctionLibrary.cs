namespace AssetTool
{
    [JsonAsset("LevelSnapshotsFunctionLibrary")]
    public class ULevelSnapshotsFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}