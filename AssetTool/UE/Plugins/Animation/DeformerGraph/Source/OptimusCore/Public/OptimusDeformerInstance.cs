namespace AssetTool
{
    [JsonAsset("OptimusDeformerInstanceSettings")]
    public class UOptimusDeformerInstanceSettings : UMeshDeformerInstanceSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OptimusDeformerInstance")]
    public class UOptimusDeformerInstance : UMeshDeformerInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}