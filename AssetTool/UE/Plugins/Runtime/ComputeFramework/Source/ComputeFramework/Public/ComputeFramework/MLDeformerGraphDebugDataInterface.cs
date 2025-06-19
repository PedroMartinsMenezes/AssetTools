namespace AssetTool
{
    [JsonAsset("MLDeformerGraphDebugDataInterface")]
    public class UMLDeformerGraphDebugDataInterface : UOptimusComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MLDeformerGraphDebugDataProvider")]
    public class UMLDeformerGraphDebugDataProvider : UComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}