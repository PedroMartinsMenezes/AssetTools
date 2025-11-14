namespace AssetTool
{
    [JsonAsset("HLODBuilderMeshSimplifySettings")]
    public class UHLODBuilderMeshSimplifySettings : UHLODBuilderSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HLODBuilderMeshSimplify")]
    public class UHLODBuilderMeshSimplify : UHLODBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}