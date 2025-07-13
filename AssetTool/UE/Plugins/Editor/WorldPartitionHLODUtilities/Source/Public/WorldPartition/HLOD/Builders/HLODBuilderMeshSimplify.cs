namespace AssetTool
{
    [JsonAsset("HLODBuilderMeshSimplifySettings")]
    public class UHLODBuilderMeshSimplifySettings : UHLODBuilderSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HLODBuilderMeshSimplify")]
    public class UHLODBuilderMeshSimplify : UHLODBuilder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}