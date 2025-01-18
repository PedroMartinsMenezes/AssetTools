namespace AssetTool
{
    [JsonAsset("OptimusDeformerInstanceSettings")]
    public class UOptimusDeformerInstanceSettings : UMeshDeformerInstanceSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusDeformerInstance")]
    public class UOptimusDeformerInstance : UMeshDeformerInstance
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}