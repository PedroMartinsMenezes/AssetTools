namespace AssetTool
{
    [JsonAsset("MLDeformerGraphDebugDataInterface")]
    public class UMLDeformerGraphDebugDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MLDeformerGraphDebugDataProvider")]
    public class UMLDeformerGraphDebugDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}