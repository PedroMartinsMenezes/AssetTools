namespace AssetTool
{
    [JsonAsset("HLODBuilderMeshMergeSettings")]
    public class UHLODBuilderMeshMergeSettings : UHLODBuilderSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HLODBuilderMeshMerge")]
    public class UHLODBuilderMeshMerge : UHLODBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}