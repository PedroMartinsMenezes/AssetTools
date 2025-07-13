namespace AssetTool
{
    [JsonAsset("HealthSnapshotBlueprintLibrary")]
    public class UHealthSnapshotBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}