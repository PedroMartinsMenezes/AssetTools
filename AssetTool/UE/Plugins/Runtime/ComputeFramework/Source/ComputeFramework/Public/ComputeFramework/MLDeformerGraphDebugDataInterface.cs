namespace AssetTool
{
    [JsonAsset("MLDeformerGraphDebugDataInterface")]
    public class UMLDeformerGraphDebugDataInterface : UOptimusComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MLDeformerGraphDebugDataProvider")]
    public class UMLDeformerGraphDebugDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}