namespace AssetTool
{
    [JsonAsset("DIFleshDeformer")]
    public class UDIFleshDeformer : UOptimusComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DIFleshDeformerDataProvider")]
    public class UDIFleshDeformerDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}