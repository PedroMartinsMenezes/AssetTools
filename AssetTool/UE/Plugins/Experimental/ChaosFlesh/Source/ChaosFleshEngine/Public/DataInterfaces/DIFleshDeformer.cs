namespace AssetTool
{
    [JsonAsset("DIFleshDeformer")]
    public class UDIFleshDeformer : UOptimusComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DIFleshDeformerDataProvider")]
    public class UDIFleshDeformerDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}