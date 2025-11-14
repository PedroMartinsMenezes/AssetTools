namespace AssetTool
{
    [JsonAsset("HLODBuilderMeshApproximateSettings")]
    public class UHLODBuilderMeshApproximateSettings : UHLODBuilderSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HLODBuilderMeshApproximate")]
    public class UHLODBuilderMeshApproximate : UHLODBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}